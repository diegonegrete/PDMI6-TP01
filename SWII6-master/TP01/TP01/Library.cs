using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
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
    }
}
