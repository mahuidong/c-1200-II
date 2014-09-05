using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectPrint2
{
    class DPrint<T>
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        Stream stream;

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            stream = new FileStream(name + "." + fileNameExtension, FileMode.Create);
            m_streams.Add(stream);
            return stream;
        }

        private void Export(LocalReport report,double[] a)
        {
            //string deviceInfo =
            //  "<DeviceInfo>" +
            //  "  <OutputFormat>EMF</OutputFormat>" +
            //  "  <PageWidth>5.5in</PageWidth>" +
            //  "  <PageHeight>3.5in</PageHeight>" +
            //  "  <MarginTop>0.25in</MarginTop>" +
            //  "  <MarginLeft>0.25in</MarginLeft>" +
            //  "  <MarginRight>0.25in</MarginRight>" +
            //  "  <MarginBottom>0.25in</MarginBottom>" +
            //  "</DeviceInfo>";
            string deviceInfo =
              "<DeviceInfo>" +
              "  <OutputFormat>EMF</OutputFormat>" +
              "  <PageWidth>"+a[0]+"cm</PageWidth>" +
              "  <PageHeight>"+a[1]+"cm</PageHeight>" +
              "  <MarginTop>" + a[2] + "cm</MarginTop>" +
              "  <MarginLeft>" + a[3] + "cm</MarginLeft>" +
              "  <MarginRight>" + a[4] + "cm</MarginRight>" +
              "  <MarginBottom>" + a[5] + "cm</MarginBottom>" +
              "</DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            

            foreach (Stream varstream in m_streams)
                varstream.Position = 0;
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
            ev.Graphics.DrawImage(pageImage, ev.PageBounds);
          //  ev.Graphics.DrawImageUnscaledAndClipped(pageImage, ev.PageBounds);

            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print(string printerName)
        {
            //const string printerName = "Microsoft Office Document Image Writer";
            //const string printerName = "ImagePrinter";
            if (m_streams == null || m_streams.Count == 0)
                return;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = printerName;            
            
            if (!printDoc.PrinterSettings.IsValid)
            {
                string msg = String.Format("Can't find printer \"{0}\".", printerName);
                Console.WriteLine(msg);
                return;
            }
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            printDoc.Print();
        }

        public void Run(string printerName, string ReportPath,List<T> list,double[] a )
        {
            
            LocalReport report = new LocalReport();
           // report.ReportPath = @"..\..\Report1.rdlc";
            report.ReportPath = ReportPath;
            report.DataSources.Add(new ReportDataSource("DataSet1", list));
            Export(report,a);
            m_currentPageIndex = 0;
            Print(printerName);
            stream.Close();
        }
    }
}
