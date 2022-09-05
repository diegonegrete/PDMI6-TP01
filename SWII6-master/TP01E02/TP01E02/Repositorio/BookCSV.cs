using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01E02.Model;

namespace TP01E02.Repositorio

{
    internal class BookCSV
    {
        private static readonly string nomeArquivoCSV = "E:\\books.csv";

        private Library library;
        private AuthorCSV autor = new AuthorCSV();

        public BookCSV()
        {
            var books = new List<Book>();
            using (var file = File.OpenText(nomeArquivoCSV))
            {
                while (!file.EndOfStream)
                {
                    var textoLivro = file.ReadLine();
                    if (string.IsNullOrEmpty(textoLivro))
                    {
                        continue;
                    }
                    var infoLivro = textoLivro.Split(',');

                    var name = infoLivro[0];
                    var author = infoLivro[1];
                    double price = Convert.ToDouble(infoLivro[2]);
                    if (infoLivro[3] != "")
                    {
                        int qty = Convert.ToInt32(infoLivro[3]);
                        var autoresRet = autor.retornaAuthor(author);
                        books.Add(new Book(name, autoresRet, price, qty));
                    }
                    else
                    {
                        var autoresRet = autor.retornaAuthor(author);
                        books.Add(new Book(name, autoresRet, price));
                    }
                }
            }
            library = new Library(books);
        }
        public Library Library => library;
    }
}
