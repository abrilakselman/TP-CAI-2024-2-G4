using Datos.Ventas;
using Persistencia;
using Datos.Cliente;
using Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Negocio
{
    public class VentaNegocio
    {

        VentaWS ventaWS = new VentaWS();
        public List<Venta> Listar(Guid idCliente)
        {
            
            return ventaWS.Listar<Venta>(idCliente);
        }

        public void CrearVenta(Guid idCliente, Guid idProducto, Guid idUsuario, int cantidad)
        {
            
            VentaPost ventaPost = new VentaPost(idCliente, idUsuario, idProducto, cantidad);

            ventaWS.AgregarVenta(ventaPost);
        }


        /*
         * 
         * Nombre Promoción	Condición	Descuento
Promo Electro Hogar:	Si una venta tiene productos de la categoría Electro Hogar que sumen más de $100.000 se hará 
        un descuento SÓLO sobre estos productos	----> 5%
Promo Cliente Nuevo:	Si un cliente nuevo realiza su primera compra se le dará un descuento. 
        Acumulable con otras promociones  ---->	5%
                 * 
         * */

        public Descuento calcularDescuento(List<VentaLista> ventas)
        {
            Descuento descuento = new Descuento();

            int descuentoElectro = ventas.Where(x => x.Categoria == 3).Sum(x => x.PrecioTotal);

            if (descuentoElectro > 100000)
            {
                descuento = new Descuento("Promo electro hogar", 0, 0.05);
            }

            return descuento;
        }




        //metodo que genera el PDF de la venta (carrito)
        //usamos QuestPDF: una biblioteca de código abierto para la generación de documentos PDF en .NET
        public string GenerarPDF(int id, Clientes cliente, List<VentaLista> ventaLista, Descuento descuento)
        {
            try
            {
                QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                string codigo = id.ToString("D8");
                CrearArchivo();
                string pathArchivo = $@"{Path}\{codigo}.pdf";
                var promociones = new[] { "Promoción 1: Descuento del 10%", "Promoción 2: Envío gratuito" };
                var montoTotal = ventaLista.Sum(d => d.PrecioTotal);

                int descuentos = 0;
                if (descuento != null)
                {
                    descuentos = Convert.ToInt32(montoTotal * descuento.Porcentaje);
                }
                QuestPDF.Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Margin(10);
                        page.Header()
                            .AlignCenter()
                            .Text(text =>
                            {
                                text.Line("ElectroHogar S.A.")
                                    .FontSize(20)
                                    .Italic()
                                    .FontColor(Colors.Red.Medium);

                                text.Line("Una idea de G4")
                                    .FontSize(14)
                                    .FontColor(Colors.Grey.Darken2);
                            });

                        page.Content()
                            .Column(stack =>
                            {
                                stack.Item().Text($"Fecha de Operación: {DateTime.Now:dd/MM/yyyy}");
                                stack.Item().Text($"Cliente: {cliente.Nombre} {cliente.Apellido}").AlignRight();
                                stack.Item().Text($"DNI: {cliente.Dni}").AlignRight();
                                stack.Item().Text($"Dirección: {cliente.Direccion}").AlignRight();
                                stack.Item().Text($"N° de factura: {codigo}").AlignRight();
                                stack.Item().Text("Detalle de Facturación").FontSize(18).FontColor(Colors.Blue.Darken2);

                                stack.Item().Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.ConstantColumn(100);
                                        columns.RelativeColumn(3);
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                    });

                                    table.Header(header =>
                                    {
                                        header.Cell().Element(StyleHeader).Text("Id del Producto");
                                        header.Cell().Element(StyleHeader).Text("Descripción");
                                        header.Cell().Element(StyleHeader).AlignRight().Text("Cantidad");
                                        header.Cell().Element(StyleHeader).AlignRight().Text("Monto Unitario");
                                        header.Cell().Element(StyleHeader).AlignRight().Text("Monto Total");

                                        IContainer StyleHeader(IContainer headerContainer)
                                        {
                                            return headerContainer
                                                .DefaultTextStyle(x => x.SemiBold())
                                                .BorderBottom(1)
                                                .BorderColor(Colors.Grey.Darken2)
                                                .Padding(5);
                                        }
                                    });

                                    foreach (var venta in ventaLista)
                                    {
                                        table.Cell().Element(Style).Text($"{venta.Producto.Id}");
                                        table.Cell().Element(Style).Text($"{venta.Producto.Valor}");
                                        table.Cell().Element(Style).AlignRight().Text($"{venta.Cantidad}");
                                        table.Cell().Element(Style).AlignRight().Text($"{venta.PrecioUnitario}");
                                        table.Cell().Element(Style).AlignRight().Text($"{venta.PrecioTotal}");

                                        IContainer Style(IContainer ventaContainer)
                                        {
                                            return ventaContainer
                                                .BorderBottom(1)
                                                .BorderColor(Colors.Grey.Lighten2)
                                                .Padding(5);
                                        }
                                    }

                                    if (descuentos > 0)
                                    {
                                        table.Cell().Element(Style).Text("");
                                        table.Cell().Element(Style).Text($"{descuento.Nombre}");
                                        table.Cell().Element(Style).AlignRight().Text("");
                                        table.Cell().Element(Style).AlignRight().Text("");
                                        table.Cell().Element(Style).AlignRight().Text($"{descuentos}");

                                        IContainer Style(IContainer descuentoContainer)
                                        {
                                            return descuentoContainer
                                                .BorderBottom(1)
                                                .BorderColor(Colors.Grey.Lighten2)
                                                .Padding(5);
                                        }
                                    }

                                    IContainer StyleFooter(IContainer footerContainer)
                                    {
                                        return footerContainer
                                            .BorderTop(1)
                                            .BorderColor(Colors.Grey.Darken2)
                                            .Padding(5);
                                    }

                                    table.Footer(footer =>
                                    {
                                        footer.Cell().ColumnSpan(4).Element(StyleFooter).AlignRight().DefaultTextStyle(x => x.SemiBold()).Text("Total");
                                        footer.Cell().Element(StyleFooter).DefaultTextStyle(x => x.SemiBold()).AlignRight().Text($"{montoTotal - descuentos}");
                                    });
                                });

                                // Agregar la nota final
                                stack.Item().Text(text =>
                                {
                                    text.Line("Emita todos los cheques a pagar a nombre de ElectroHogar S.A.")
                                        .FontSize(8);
                                    text.Line("Si desea hacer alguna consulta con respecto a esta factura, póngase en contacto con ElectroHogar S.A.")
                                        .FontSize(8);
                                    text.Line("por télefono a 0800-555-ELECTRO (6648868) o por correo electrónico a elctro_sa_argentina@yahoo.com.ar")
                                        .FontSize(8);
                                    text.EmptyLine();
                                    text.Line("Gracias por su Compra")
                                        .Bold()
                                        .FontSize(14);
                                });
                            });
                    });
                }).GeneratePdf(pathArchivo);

                return pathArchivo;
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo una excepcion al generar el comprobante", ex);
            }
        }







        private string Path { get; set; } = $@"C:\G4\PdfPurebas\Template";  //se almacena en la carpeta del equipo por default
        private void CrearArchivo()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }



    }
}
