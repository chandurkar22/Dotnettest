using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Bcloud
{
    public class Employees
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Task { get; set; }
        public int CompanyId { get; set; }
        public int Salary { get; set; } 


        public Clients Clients { get; set; }    
        public int? ClientsID { get; set; } 

        public BankDetails BankDetails { get; set; }
        

    }
}
