using ControlePatrimonial.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlePatrimonial.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Setor> Setor { get; set; }
    }
}
