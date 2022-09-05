using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01E02.Model
{
    internal class Author
    {
        public int id { get; }
        public string name { get; set; }
        public string email { get; set; }
        public char gender { get; set; }

        public override string? ToString()
        {
            return "\n[Name: " + name + ", Email: " + email + ",Gender: " + gender + "]";
        }
    }
}
