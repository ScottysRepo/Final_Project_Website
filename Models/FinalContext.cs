using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final_Project.Models
{
    public class FinalContext : DbContextContext
    {
        public FinalContext (dbContextOptions<FinalContext> options)
            : base(options)
        {
        }
        
        public DbSet<CIDM3312_Final_Project.Models.Client> Clients { get; set; }
        public DbSet<CIDM3312_Final_Project.Models.Projects> Projects { get; set; }
        public DbSet<CIDM3312_Final_Project.Models.Members> Members { get; set; }
    }
}
