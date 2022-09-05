using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01E02.Model;

namespace TP01E02.Repositorio
{
    internal class AuthorCSV
    {
        private static readonly string nomeArquivoCSV = "E:\\autores.csv";

        public List<Author> retornaAuthor(string idAuthor)
        {
            var authores = new List<Author>();

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
                    var ids = idAuthor.Split("+");
                    foreach (var id in ids)
                        if (id == infoLivro[0])
                        {
                            var livro = new Author
                            {
                                name = infoLivro[1],
                                email = infoLivro[2],
                                gender = Convert.ToChar(infoLivro[3])
                            };
                            authores.Add(livro);
                        }
                }
            }
            return authores;
        }
    }
}
