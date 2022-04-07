using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_SCommerceClasses
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int CourseNo { get; set; }   
        public int fees { get; set; }
        public ICollection<Students> Students { get; set; }


    }
}
