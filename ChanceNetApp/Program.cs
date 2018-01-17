using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChanceNET;

namespace ChanceNetApp
{
    class Program
    {
        static int adultAgeRange = 4;
        static int max = 200;

        static void Main(string[] args)
        {
            int number = 0;

            while (number < max)
            {
                Random random = new Random();
                string seed = RandomString(20);
                //Chance c = new Chance(seed);
                Chance c = new Chance();
                var enumVal = (AgeRanges)adultAgeRange;
                try
                {
                    Console.WriteLine(c.Birthday(enumVal));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Attempt failed after {number} tries");
                    Console.WriteLine(e.Message);
                }

                number++;
            }

            Console.WriteLine($"Completed run of {max} dates");
            Console.ReadLine();
        }

        private static string RandomString(int size)
        {

            System.Threading.Thread.Sleep(25);
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

    }
}
