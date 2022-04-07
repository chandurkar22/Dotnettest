using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Bcloud
{
    public class Clients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public string Task { get; set; }


        public ICollection<Employees> Employees{ get; set; }    
    }
}
