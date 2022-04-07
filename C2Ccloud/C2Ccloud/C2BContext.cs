
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2Bcloud
{
    public class C2BContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<BankDetails> BankDetails { get; set; } 
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(s => s.UsersId)
                .HasColumnName("UId")
                .HasDefaultValue(0)
                .IsRequired();


        }

    }
}
