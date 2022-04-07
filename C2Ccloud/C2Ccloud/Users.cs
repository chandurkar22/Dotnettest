using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Bcloud
{
    [Table("UsersInfo")]
    public class Users
    {
        public Users() { }
        [Key]
        public int UId { get; set; }
        [Column("Name", TypeName = "ntext")]
        [MaxLength(32)]
        public string Name { get; set; } 
        [NotMapped]
        public int? Age { get; set; }
        public int ClientsID { get; set; }  
        [ForeignKey("ClientsID")]
        public virtual Clients Clients { get; set; }    


    }
}
