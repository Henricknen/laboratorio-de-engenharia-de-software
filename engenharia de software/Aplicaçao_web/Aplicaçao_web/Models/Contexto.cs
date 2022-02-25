using Microsoft.EntityFrameworkCore;

namespace Aplicaçao_web.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }


    }
}
