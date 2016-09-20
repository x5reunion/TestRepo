using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SortAlgorithms
{
    class NumberLowerValue
    {
        public static void Show(int a, int b)
        {
            for (BigInteger i = 1; i < 1000000; i++)
            {
                string aStr = (a * i).ToString();
                string bStr = (b * i).ToString();

                string bReverse = new string(bStr.Reverse().ToArray());
                string aReverse = new string(aStr.Reverse().ToArray());

                //Console.WriteLine("A = {0} A reverse = {1}, B = {2} B reverse = {3}", a * i, aReverse, b * i, bReverse);


                //Console.WriteLine("Index = {0}\t [ A = {1}, B = {2} ]", i, aReverse, bReverse);

                if (BigInteger.Parse(aStr) == BigInteger.Parse(bReverse))
                {
                    Console.WriteLine("A = {0}, B = {1}", a * i, b * i);
                }

                if (BigInteger.Parse(bStr) == BigInteger.Parse(aReverse))
                {
                    Console.WriteLine("A = {0}, B = {1}", a * i, b * i);
                }

                if (BigInteger.Parse(aReverse) == BigInteger.Parse(bReverse))
                {
                    Console.WriteLine("A = {0}, B = {1}", a * i, b * i);
                }



            }
        }
    }
}
