using VsystemBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
namespace VsystemBiblioteca.Data
{
    public class ContextoBiblioteca : DbContext
    {
        public ContextoBiblioteca (DbContextOptions<ContextoBiblioteca> options) : base(options) { }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().ToTable("Livro");
        }



    }
}
