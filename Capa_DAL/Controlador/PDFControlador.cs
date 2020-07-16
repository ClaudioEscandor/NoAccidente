
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DAL.Controlador
{
    public class PDFControlador
    {

        public void crearPdf()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\pagos.pdf";

            PdfWriter writer = new PdfWriter(rutaEscritorio);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Documento de Pago PDF")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(20);
            

            Paragraph p = new Paragraph();

            Image img = new Image(ImageDataFactory
            .Create(@"..\\..\\IMG\\Logo-Pagina.png"))
            .SetTextAlignment(TextAlignment.CENTER);
            

            LineSeparator ls = new LineSeparator(new SolidLine());

            Table table = new Table(4, false);
            table.SetWidth(500);
            Table table2 = new Table(2, false);
            table2.SetWidth(500);
            Table table3 = new Table(2, false);
            table3.SetWidth(500);

            Cell nomCli = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Nombre Cliente:"));
            nomCli.SetBorder(Border.NO_BORDER);

            Cell nomCli2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadasdasda"));
            nomCli2.SetBorder(Border.NO_BORDER);

            Cell giroEmp = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Giro Empresa:"));
            giroEmp.SetBorder(Border.NO_BORDER);

            Cell giroEmp2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("tyytuytutyuty"));
            giroEmp2.SetBorder(Border.NO_BORDER);

            Cell rutCli = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Rut Cliente:"));
            rutCli.SetBorder(Border.NO_BORDER);

            Cell rutCli2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("tyytuytutyuty"));
            rutCli2.SetBorder(Border.NO_BORDER);

            Cell tel = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Telefono:"));
            tel.SetBorder(Border.NO_BORDER);

            Cell tel2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadasdsadasdasd"));
            tel2.SetBorder(Border.NO_BORDER);

            Cell serv = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Servicios:"));
            serv.SetBorder(Border.NO_BORDER);

            Cell serv2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadasdsadasdasd"));
            serv2.SetBorder(Border.NO_BORDER);

            Cell fecIni = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Fecha Inicio Contrato:"));
            fecIni.SetBorder(Border.NO_BORDER);

            Cell fecIni2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("213213131312"));
            fecIni2.SetBorder(Border.NO_BORDER);

            Cell fecTer = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Fecha Termino Contrato:"));
            fecTer.SetBorder(Border.NO_BORDER);

            Cell fecTer2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("2132121321313131312"));
            fecTer2.SetBorder(Border.NO_BORDER);

            Cell monto = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Monto:"));
            monto.SetBorder(Border.NO_BORDER);

            Cell monto2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadsadsadasda"));
            monto2.SetBorder(Border.NO_BORDER);

            Cell impuesto = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Impuesto:"));
            impuesto.SetBorder(Border.NO_BORDER);

            Cell impuesto2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadsadsadasda"));
            impuesto2.SetBorder(Border.NO_BORDER);

            Cell monto_total = new Cell(1, 2)
           .SetTextAlignment(TextAlignment.CENTER)
           .Add(new Paragraph("Monto Total:"));
            monto_total.SetBorder(Border.NO_BORDER);

            Cell monto_total2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadsadsadasda"));
            monto_total2.SetBorder(Border.NO_BORDER);

            Cell estado = new Cell(1, 2)
           .SetTextAlignment(TextAlignment.CENTER)
           .Add(new Paragraph("Estado Pago:"));
            estado.SetBorder(Border.NO_BORDER);

            Cell estado2 = new Cell(1, 2)
               .SetTextAlignment(TextAlignment.LEFT)
               .Add(new Paragraph("sadsadsadsadasda"));
            estado2.SetBorder(Border.NO_BORDER);


            table.AddCell(nomCli);
            table.AddCell(nomCli2);
            table.AddCell(giroEmp);
            table.AddCell(giroEmp2);
            table.AddCell(rutCli);
            table.AddCell(rutCli2);
            table.AddCell(tel);
            table.AddCell(tel2);
            table.AddCell(serv);
            table.AddCell(serv2);
            table.AddCell(fecIni);
            table.AddCell(fecIni2);
            table.AddCell(fecTer);
            table.AddCell(fecTer2);

            table.AddCell(monto);
            table.AddCell(monto2);
            table.AddCell(impuesto);
            table.AddCell(impuesto2);
            table.AddCell(monto_total);
            table.AddCell(monto_total2);
            table.AddCell(estado);
            table.AddCell(estado2);


            document.Add(header);
            document.Add(ls);
            document.Add(img);
            document.Add(ls);
            document.Add(p);
            document.Add(table);


            document.Close();
        }

    }
}
