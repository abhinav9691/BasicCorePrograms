using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Finding The N th Hormonic Value");
            Console.WriteLine("Enter the Nth number");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            double Result = 0.0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0}+", i);
                Result += 1 / (float)i;
            }
            Console.WriteLine("The Sum of Harmonic Serier Upto {0} terms--{1}", n, Result);
        }
    }
}
