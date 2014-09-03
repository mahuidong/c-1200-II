using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=db_TomeTwo;Integrated Security=True"))
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Employee", conn);
                conn.Open();
                DataSet ds = new DataSet();

                sda.Fill(ds, "Employee");//表名为xsd中表的名称
                ReportDataSource RD = new ReportDataSource("DataSet1", ds.Tables[0]);//DataSet1为建立报表时用到的数据集名称
                
                this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportPath = @"..\..\Report1.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(RD);
                this.reportViewer1.RefreshReport();
            }       
            
        }
    }
}
