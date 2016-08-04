using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardsExample
{
    public class Path
    {
        private List<Graph> Data;

        public Path()
        {
            Data = new List<Graph>();
        }

        public void Add(Graph item)
        {
            if (item != null)
                Data.Add(item);
        }

        public void Remove(Graph item)
        {
            Data.Remove(item);
        }

        public List<Graph> Sort()
        {
            foreach (var n in Data.ToArray())
            {
                foreach (var x in Data.ToArray())
                {
                    if (n.A == x.B)
                    {
                        Insert(n, x);
                    }
                }
            }

            return this.Data;
        }

        private void Insert(Graph one, Graph two)
        {
            Graph temp = two;
            Data.Remove(two);
            Data.Insert(Data.IndexOf(one), temp);
        }
    }
}
