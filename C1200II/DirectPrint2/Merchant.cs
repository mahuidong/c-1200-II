using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectPrint2
{
    class Merchant<T>
        where T:Template
    {
        private List<T> m_products;

        public Merchant(T product)
        {
            m_products = new List<T>();
            m_products.Add(product);
        }

      
        public List<T> GetProducts()
            
        {
            return m_products;
        }
    }
}
