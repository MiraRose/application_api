using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace application_api.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; } = null!;
    }
}