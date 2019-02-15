using MinVoiCe.Models;
using Microsoft.EntityFrameworkCore;

namespace MinVoiCe.data
{
    public class MinvoiceDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Project> Projects { get; set; }

        public MinvoiceDbContext(DbContextOptions<MinvoiceDbContext> options) : base(options) { }
    }
}
