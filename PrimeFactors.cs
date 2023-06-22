using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class PrimeFactors
    {
        public void Factor()
        {
            int a, b;
            Console.WriteLine("Enter your Number to Find Prime Factor");
            a = Convert.ToInt32(Console.ReadLine());

            for (b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine($"{b} is Prime Factor {x} Times");
                }
            }

        }
    }
}
