using Microsoft.EntityFrameworkCore;

namespace MemberApi
{
    public class MemberDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Class> Class { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
    }

    
    
}
