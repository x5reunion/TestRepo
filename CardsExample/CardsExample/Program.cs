using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Path path = new Path();

            path.Add(new Graph("Москва", "Париж"));
            path.Add(new Graph("Мельбурн", "Кельн"));
            path.Add(new Graph("Кельн", "Москва"));
          
            foreach (var n in path.Sort())
            {
                Console.WriteLine(" -> {0} ", n.ToString());
            }
        }
    }
}
