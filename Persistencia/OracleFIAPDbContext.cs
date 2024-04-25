using Microsoft.EntityFrameworkCore;
using BOOK_GENIUS.Models;

namespace BookGenius.Persistencia
{
    public class OracleFIAPDbContext : DbContext
    {
        public OracleFIAPDbContext(DbContextOptions<OracleFIAPDbContext> options) : base(options)
        {
        }

        public DbSet<Autores> Autores { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Editoras> Editoras { get; set; }
        public DbSet<Emprestimos> Emprestimos { get; set; }
        public DbSet<Livros> Livros { get; set; }
    }
}