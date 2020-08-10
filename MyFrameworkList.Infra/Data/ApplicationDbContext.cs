using Microsoft.EntityFrameworkCore;
using MyFrameworkList.Domain.Entities;

namespace MyFrameworkList.Infra.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Framework> Frameworks { get; set; }
    }
}
