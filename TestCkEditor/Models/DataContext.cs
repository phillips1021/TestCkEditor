using Microsoft.EntityFrameworkCore;

namespace TestCkEditor.Models
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        
        public DbSet<Employee> Employee { get; set; }

    }
}
