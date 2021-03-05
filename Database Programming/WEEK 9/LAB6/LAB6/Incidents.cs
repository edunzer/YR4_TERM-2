using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
    public class Incidents
    {
        public Incidents() { }

        public int CustomerID { get; set; }
        public int IncidentID { get; set; }
        public string ProductCode { get; set; }
        public int? TechID { get; set; }
        public DateTime? DateCLosed { get; set; }
        public DateTime? DateOpened { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
