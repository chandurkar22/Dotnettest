using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Bcloud
{
    public class BankDetails
    {
        public int Id { get; set; } 
        public string BankName { get; set; }  
        public string Branch { get; set; }  
        public string ACnumber { get; set; }    

        public bool DebitCard { get; set; } 
        public bool CreditCard { get; set; }

        public int EmployeesID { get; set; }
        public Employees Employees{ get; set; }
    }
}
