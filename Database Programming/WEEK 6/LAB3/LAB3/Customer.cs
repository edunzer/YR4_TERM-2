using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Customer
    {
        private string strCustomerID;
        private string strName;

        public Customer() { }

        public Customer(string c, string n)
        {
            Name = n;
            CustID = c;
        }

        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public string CustID
        {
            get { return strCustomerID; }
            set { strCustomerID = value; }
        }
    }
}
