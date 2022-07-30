using VsystemBiblioteca.Models;
using System;
using System.Linq;
namespace VsystemBiblioteca.Data
{
    public static class DbInitializer
    {
        public static void Initialize (ContextoBiblioteca contexto)
        {
            contexto.Database.EnsureCreated();

            if (contexto.Livros.Any())
            {
                return;
            }

            var livros = new Livro[]
            {
                new Livro{ TituloLivro = "História do Futuro: O Horizonte do Brasil no Século XXI",
                    CodigoISBN="8580577853", AutorLivro="Míriam Leitão", NomeEditora= "Intrínseca", QtdPaginas = 496, DataCadastro =DateTime.Parse("2022-07-30") },
                new Livro{ TituloLivro = "Os Miseráveis",
                    CodigoISBN="B09GPV5SCZ", AutorLivro="Aljâhiz", NomeEditora= "Literatura Livre", QtdPaginas = 363, DataCadastro =DateTime.Parse("2022-07-30") },
                new Livro{ TituloLivro = "Os sertões",
                    CodigoISBN="B00SFS2PNO", AutorLivro="Euclydes da Cunha", NomeEditora= "SciELO", QtdPaginas = 389, DataCadastro =DateTime.Parse("2022-07-30") },
            };
            foreach (Livro s in livros)
            {
                contexto.Livros.Add(s);
            }
            contexto.SaveChanges();
        }
    }
}
