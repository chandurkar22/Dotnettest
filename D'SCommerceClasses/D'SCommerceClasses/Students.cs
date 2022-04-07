using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_SCommerceClasses
{
    public class Students
    {
        public int Id { get; set; } 
        public string Name { get; set; }  
        public int? Age { get; set; }   
        public int Class { get; set; }  
          
        public int? CoursesId { get; set; }


        public Courses Courses { get; set; }

    }
}
