using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Registration
    {
        private string strCustomerName;
        private string strProductName;
        private string dateRegistrationDate;

        public Registration() { }

        public Registration(string p, string c, string r)
        {
            ProdName = p;
            CustName = c;
            RegDate = r;
        }

        public string ProdName
        {
            get { return strProductName; }
            set { strProductName = value; }
        }

        public string CustName
        {
            get { return strCustomerName; }
            set { strCustomerName = value; }
        }

        public string RegDate 
        {
            get { return dateRegistrationDate; }
            set { dateRegistrationDate = value; }
        }
    }
}
