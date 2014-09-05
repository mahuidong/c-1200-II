using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectPrint2
{
    class HisenseTemplate:Template
    {
        public string Brand { get; set; }
        public string Contract_No { get; set; }
        public string Code_Number { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public string Date_of_Production { get; set; }
        public string Supplier { get; set; }
        public string Ctn_no { get; set; }
        public HisenseTemplate(string Brand, string Contract_No, string Code_Number, string Description, string Model, int Quantity, string Date_of_Production, string Supplier,string Ctn_no)
        {
            this.Brand = Brand;
            this.Contract_No = Contract_No;
            this.Code_Number = Code_Number;
            this.Description = Description;
            this.Model = Model;
            this.Quantity = Quantity;
            this.Date_of_Production = Date_of_Production;
            this.Supplier = Supplier;
            this.Ctn_no = Ctn_no;
        }
    }
}
