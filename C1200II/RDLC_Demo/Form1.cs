using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLC_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local; 
            this.reportViewer1.LocalReport.ReportPath = "rdlcuserguide.rdlc";  
            this.reportViewer1.RefreshReport();     
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
             LocalReport report = new LocalReport();
             //设置需要打印的报表的文件名称。
             report.ReportPath = @"c:\PrintMe.rdlc";
             //创建要打印的数据源
             ReportDataSource source = new ReportDataSource(SourceTalbe.TableName, SourceTalbe);
             report.DataSources.Add(source);
             //刷新报表中的需要呈现的数据
             report.Refresh();
           string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>EMF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>11in</PageHeight>" +
            "  <MarginTop>0.25in</MarginTop>" +
            "  <MarginLeft>0.25in</MarginLeft>" +
            "  <MarginRight>0.25in</MarginRight>" +
            "  <MarginBottom>0.25in</MarginBottom>" +
            "</DeviceInfo>";
            Warning[] warnings;
            //将报表的内容按照deviceInfo指定的格式输出到CreateStream函数提供的Stream中。
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            
            
        }
         //声明一个Stream对象的列表用来保存报表的输出数据
   //LocalReport对象的Render方法会将报表按页输出为多个Stream对象。
   private List<Stream> m_streams;
   //用来提供Stream对象的函数，用于LocalReport对象的Render方法的第三个参数。
   private Stream CreateStream(string name, string fileNameExtension,
   Encoding encoding, string mimeType, bool willSeek)
   {
   //如果需要将报表输出的数据保存为文件，请使用FileStream对象。
   Stream stream = new MemoryStream();
  m_streams.Add(stream);
  return stream;
   }
       //用来记录当前打印到第几页了
   private int m_currentPageIndex;
    
   private void Print()
    {
        m_currentPageIndex = 0;
     
        if (m_streams == null || m_streams.Count == 0)
           return;
       //声明PrintDocument对象用于数据的打印
       PrintDocument printDoc = new PrintDocument();
      //指定需要使用的打印机的名称，使用空字符串""来指定默认打印机
       printDoc.PrinterSettings.PrinterName = "";
      //判断指定的打印机是否可用
      if (!printDoc.PrinterSettings.IsValid)
      {
           MessageBox.Show("Can't find printer");
           return;
       }
      //声明PrintDocument对象的PrintPage事件，具体的打印操作需要在这个事件中处理。
       printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
       //执行打印操作，Print方法将触发PrintPage事件。
       printDoc.Print();
   }
        private void PrintPage(object sender, PrintPageEventArgs ev)
    {
        //Metafile对象用来保存EMF或WMF格式的图形，
        //我们在前面将报表的内容输出为EMF图形格式的数据流。
          m_streams[m_currentPageIndex].Position = 0;
        Metafile pageImage = new Metafile(m_streams[m_currentPageIndex]);
        //指定是否横向打印
        ev.PageSettings.Landscape = false;
        //这里的Graphics对象实际指向了打印机
        ev.Graphics.DrawImage(pageImage, 0, 0);
       m_streams[m_currentPageIndex].Close();
       m_currentPageIndex++;
       //设置是否需要继续打印
       ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
   }
    }
}
