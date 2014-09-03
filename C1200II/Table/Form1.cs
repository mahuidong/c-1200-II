using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = @"rdlc\ctlTableDemo.rdlc";
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ctlsDemo_vSales", LoadData()));
            //

            this.reportViewer1.RefreshReport();
        }
        private DataTable LoadData()
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"data\ctlsDemo.xml");
            return dataSet.Tables[0];
        }

    }
}
