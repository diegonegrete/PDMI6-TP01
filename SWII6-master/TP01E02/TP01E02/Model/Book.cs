using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01E02.Model
{
    internal class Book
    {
        public string name { get; }
        public List<Author> authors { get; }
        public double price { get; set; }
        private int qty = 0;

        public Book(string name, List<Author> authors, double price, int qty)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
            this.qty = qty;
        }
        public Book(string name, List<Author> authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public override string? ToString()
        {
            var auth = "";
            foreach (Author author in authors)
                auth += author.ToString();

            return "Book: " + name + "\n" +
                "Authors: " + auth + "\n" +
                "Price: " + price + "\n" +
                "Qty: " + qty + "\n";
        }

        public string getAuthorNames()
        {
            var _repo = "";
            foreach (var author in authors)
            {
                _repo += author.name + ", ";
            }
            return _repo;
        }
        public int getQty() { return qty; }
        public void setQty(int qty) { this.qty = qty; }
    }
}
