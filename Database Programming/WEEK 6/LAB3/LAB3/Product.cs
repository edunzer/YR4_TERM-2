using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Product
    {
        private string strName;
        private string strProductCode;

        public Product() { }

        public Product(string n, string c)
        {
            Name = n;
            ProdCode = c;
        }

        public string Name 
        {
            get { return strName; }
            set { strName = value; }
        }

        public string ProdCode
        {
            get { return strProductCode; }
            set { strProductCode = value; }
        }
    }
}
