using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    internal class BookCSV
    {
        private static readonly string nomeArquivoCSV = "E:\\books.csv";

        private Library library;
        private AutorCSV autor = new AutorCSV();

        public BookCSV()
        {
            var books = new List<Book>();
            using (var file = File.OpenText(BookCSV.nomeArquivoCSV))
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
