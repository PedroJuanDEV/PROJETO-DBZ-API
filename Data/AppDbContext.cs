using Microsoft.EntityFrameworkCore; // <--- ESSENCIAL
using WebAPI.Models;                // <--- Para encontrar a classe Personagem

namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Personagem> Personagens { get; set; }
    }
}