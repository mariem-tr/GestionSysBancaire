using Microsoft.EntityFrameworkCore;
using ProjetArchitecture.Models.BankModels;

namespace ProjetArchitecture.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
