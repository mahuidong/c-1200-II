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

namespace RDLC_483
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“db_TomeTwoDataSet.Employee”中。您可以根据需要移动或删除它。
            this.EmployeeTableAdapter.Fill(this.db_TomeTwoDataSet.Employee);

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.ReportPath = "通用(印尼)_单物料.rdlc";
            reportViewer1.ProcessingMode = ProcessingMode.Local;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
