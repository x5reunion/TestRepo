using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardsExample
{
    public class Graph
    {
        public string A { get; set; }
        public string B { get; set; }

        public Graph(string a, string b)
        {
            this.A = a;
            this.B = b;
        }

        public override string ToString()
        {
            return "Graph : " + this.A + " " + this.B;
        }
    }
}
