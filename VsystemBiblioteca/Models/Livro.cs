using System;
namespace VsystemBiblioteca.Models
{
    public class Livro
    {
        public int ID { get; set; }
        public string TituloLivro { get; set; }
        public string CodigoISBN { get; set; }
        public string AutorLivro  { get; set; }
        public string NomeEditora { get; set; }
        public int QtdPaginas { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
