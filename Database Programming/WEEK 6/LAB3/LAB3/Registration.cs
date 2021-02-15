using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Registration
    {
        private int strCustomerID;
        private string strProductCode;
        private string dateRegistrationDate;

        public Registration() { }

        public Registration(string p, int c, string r)
        {
            ProdCode = p;
            CustID = c;
            RegDate = r;
        }

        public int CustID
        {
            get { return strCustomerID; }
            set { strCustomerID = value; }
        }

        public string ProdCode
        {
            get { return strProductCode; }
            set { strProductCode = value; }
        }

        public string RegDate 
        {
            get { return dateRegistrationDate; }
            set { dateRegistrationDate = value; }
        }
    }
}
