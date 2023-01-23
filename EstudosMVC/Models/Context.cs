using Microsoft.EntityFrameworkCore;

namespace EstudosMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=EstudosMVC;Integrated Security=True");
        }
    }
}
