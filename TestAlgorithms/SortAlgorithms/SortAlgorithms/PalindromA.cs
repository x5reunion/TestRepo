using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


namespace SortAlgorithms
{
	// Test Palindrom
    public class PalindromA
    {
        public static void ShowPalindromsCount(ulong value)
        {
            List<BigInteger> palindroms = new List<BigInteger>();

            for (BigInteger i = 0; i <= value; i++)
            {
                if (!FoundPalindrom(i))
                {
                    palindroms.Add(i);
                }
            }

            Console.WriteLine("Количество чисел которые не имеют полиндрома за 50 проходов {0}", palindroms.Count);
        }

        public static bool FoundPalindrom(BigInteger value)
        {
            #region FoundPalindrom
            int step = 0;

            BigInteger tempValue = value;

            while (step < 50 && !HavePalindrom(tempValue))
            {
                tempValue = tempValue + BigInteger.Parse(new string(tempValue.ToString().Reverse().ToArray()));

                //Console.WriteLine("Value = {0}", tempValue);
                //Console.WriteLine("Step = {0}", step);

                step++;
            }

            if (step < 50)
            {
                return true;
            }               
            else
            {
                return false;
            }
            #endregion
        }

        private static bool HavePalindrom(BigInteger value)
        {
            #region HavePalindrom
            //Console.WriteLine(value);

            string pal = value.ToString();

            if (pal.Length > 1)
            {
                if (pal.Length % 2 == 0)
                {
                    return EvenNumbered(value);
                }
                else
                {
                    return UnEvenNumbered(value);
                }
            }
            else
            {
                return false;
            }
            #endregion
        }

        private static bool EvenNumbered(BigInteger value)
        {
            #region EvenNumbered
            string pal = value.ToString();

            string first = pal.Substring(0, pal.Length / 2);
            string second = pal.Substring(pal.Length / 2, pal.Length / 2);

            string check = new string(second.Reverse().ToArray());

            if (first == check)
            {
                Console.WriteLine("Palindrom = {0}", value);
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }

        private static bool UnEvenNumbered(BigInteger value)
        {
            #region UnEvenNumbered
            string pal = value.ToString();

            string first = pal.Substring(0, (pal.Length - 1) / 2);
            string second = pal.Substring(((pal.Length - 1) / 2) + 1, pal.Length / 2);

            string check = new string(second.Reverse().ToArray());

            if (first == check)
            {
                Console.WriteLine("Palindrom = {0}", value);
                return true;
            }
            else
            {
                return false;
            }
            #endregion
        }
    }
}
