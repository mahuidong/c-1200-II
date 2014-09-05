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

namespace DirectPrint2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
          
                DPrint<HisenseTemplate> dp = new DPrint<HisenseTemplate>();
                //Product p = new Product("lg", i);
                //Merchant<Product> merchant = new Merchant<Product>(p);
                HisenseTemplate ht = new HisenseTemplate("Germany/Hisense", "M142124", "1133597", "Bracket", @"\RSAG8.078.3573\HB\ROH\SKD", 10, "2014-09-03", @"Hisense co./LHD32D33SEU", "S3TE32M142SM142");
                Merchant<HisenseTemplate> merchant = new Merchant<HisenseTemplate>(ht);
                //ImagePrinter Argox CP-2140 PPLB
                double[] a=new double[6];
                a[0] = 12;
                a[1] = 7.4;
                a[2] = 0.05;
                a[3] = 0.05;
                a[4] = 0.05;
                a[5] = 0.05;
                dp.Run("ImagePrinter", @"..\..\HisenseTemplate.rdlc", merchant.GetProducts(),a);
            
            
            
        }
    }
}
