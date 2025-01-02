using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class DacDBContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DacDBContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
