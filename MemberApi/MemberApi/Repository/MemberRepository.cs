using Microsoft.EntityFrameworkCore;

namespace MemberApi.Repository
{
    public class MemberRepository:IMemberRepository
    {
       
        public  Members AddMember( Members member)
        {
            var context = new MemberDb();

             var std = new Members()
            {
                Name = member.Name,
                Age = member.Age,
            };

            context.Members.Add(std);

            context.SaveChanges();

            return std;

        }
        public async Task<Members> UpdateMember( int id, Members member)
        {
            
            var context = new MemberDb();
            var std = await context.Members.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (std == null)
            {
                return null;
               
            }
            else
            {
                std.Name = member.Name;
                std.Age = member.Age;
            }

            context.SaveChanges();

            return (std);

        }

        
        public async Task<Members> Removed( int id)
        {
            
                if (id <= 0)
                return null;

            using (var context = new MemberDb())
            {
                var std =await context.Members.Where(x => x.Id == id).FirstOrDefaultAsync();
                context.Members.Remove(std);
                context.SaveChangesAsync();
            }
            return null;
        }
        public async Task<IList<Members>> GetAllMembers()
        {
            
            IList<Members> members = null;

            using (var context = new MemberDb())
            {
                members = await context.Members.ToListAsync();
            }
            if (members == null)
            {
                return null;
            }

            return members;
        }
        public async Task<Members> IncrementAge(int id)
        {

            var context = new MemberDb();
            var std = await context.Members.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (std == null)
            {
                return null;

            }
            else
            {
               
                std.Age++;
            }

            context.SaveChanges();

            return (std);

        }
    }
}
