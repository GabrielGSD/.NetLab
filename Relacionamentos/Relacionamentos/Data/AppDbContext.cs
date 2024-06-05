using Microsoft.EntityFrameworkCore;

namespace Relacionamentos.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

		public DbSet<Models.CasaModel> Casas { get; set; }
		public DbSet<Models.EnderecoModel> Endereco { get; set; }
		public DbSet<Models.QuartoModel> Quarto { get; set; }
		public DbSet<Models.MoradorModel> Moradores { get; set; }
    }
}
