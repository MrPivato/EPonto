using Microsoft.EntityFrameworkCore;

namespace EPonto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ponto> Pontos { get; set; }
        public DbSet<RH> RHs { get; set; }

    }
}