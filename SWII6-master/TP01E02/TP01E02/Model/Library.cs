using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01E02.Model
{
    internal class Library
    {
        private List<Book> book;

        public Library(List<Book> book)
        {
            this.book = book;
        }
        public IEnumerable<Book> Livros
        {
            get { return book; }
        }
        public override string ToString()
        {
            var linhas = new StringBuilder();
            foreach (var livro in Livros)
            {
                linhas.AppendLine(livro.ToString());
            }
            return linhas.ToString();
        }
        public Book buscaLivroNome(string nome)
        {
            foreach (var livro in Livros)
                if (livro.name == nome)
                    return livro;
            return null;
        }
        public string buscaLivroNomeAuthor(string nome)
        {
            string retorno = "";
            foreach (var livro in Livros)
                if (livro.name == nome)
                    retorno = livro.getAuthorNames();
            return retorno;
        }
    }
}
