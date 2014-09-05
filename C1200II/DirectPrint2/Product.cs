using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectPrint2
{
    class Product:Template
    {
        private string m_name;
        private int m_price;

        public Product(string name, int price)
        {
            m_name = name;
            m_price = price;
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public int Price
        {
            get
            {
                return m_price;
            }
        }
    }
}
