using Microsoft.EntityFrameworkCore;
using WikiClase.Models;

namespace WikiClase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        // ciclos de vida razor page investigar TAREA
        // dotnet ef migrations add correction --project WikiClase.csproj
        // dotnet ef database update posts --project WikiClase.csproj

    }
}
