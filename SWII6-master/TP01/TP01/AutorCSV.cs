using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    internal class AutorCSV
    {
        private static readonly string nomeArquivoCSV = "E:\\autores.csv";

        public List<Author> retornaAuthor(String idAuthor)
        {
            var authores = new List<Author>();

            using (var file = File.OpenText(AutorCSV.nomeArquivoCSV))
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
