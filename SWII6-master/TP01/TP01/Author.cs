using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    internal class Author
    {
        public int id { get; }
        public String name { get; set; }
        public String email { get; set; }
        public char gender { get; set; }

        public override string? ToString()
        {
            return "\n[Name: " + name + ", Email: " + email + ",Gender: " + gender + "]";
        }
    }
}
