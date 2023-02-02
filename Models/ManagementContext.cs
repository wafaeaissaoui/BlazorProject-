using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Models
{
    public class ManagementContext : DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options)
        {

        }
        public virtual DbSet<employe> Employes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
           
                optionsBuilder.UseSqlServer("Server =OUJ5MHVSG3\\SQLEXPRESS; Database = emp; Integrated Security = True");
            

        }

    }
}

