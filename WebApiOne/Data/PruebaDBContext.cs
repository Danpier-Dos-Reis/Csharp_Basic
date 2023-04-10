using Microsoft.EntityFrameworkCore;
using WebApiOne.Models;

namespace WebApiOne.Data
{
    public class PruebaDBContext : DbContext
    {
        public PruebaDBContext(DbContextOptions<PruebaDBContext> options):base(options) {}

        //Debe tener el mismo nombre de la tabla de Sql Server
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
