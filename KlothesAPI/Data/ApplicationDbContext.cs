using Microsoft.EntityFrameworkCore;
using KlothesAPI.Models;

namespace KlothesAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<KlothesAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<KlothesAPI.Models.Produtos> Produtos { get; set; } = default!;
        public DbSet<KlothesAPI.Models.Fornecedores> Fornecedores { get; set; } = default!;
        public DbSet<KlothesAPI.Models.Vendas> Vendas { get; set; } = default!;
    }
}
