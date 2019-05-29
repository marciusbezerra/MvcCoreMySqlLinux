using Microsoft.EntityFrameworkCore;

namespace MvcCoreMySqlLinux.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Livro> Livros { get; set; }
    }
}