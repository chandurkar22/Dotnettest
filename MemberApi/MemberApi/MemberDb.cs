using Microsoft.EntityFrameworkCore;

namespace MemberApi
{
    public class MemberDb : DbContext
    {
        public DbSet<Members> Members { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MemberDb;Trusted_Connection=True;");
        }
    }

    
    
}
