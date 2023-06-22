using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class PowerOf2
    {
        public void powo2()
        {
            Console.WriteLine("Enter the Number to Know the Power of 2");
            int power = Convert.ToInt32(Console.ReadLine());
            double Result = 0;
            int i;

            for (i = 1; i <= power; i++)
            {
                Result = Math.Pow(2, power);
                Console.WriteLine($"2^{i} = {Result}");
            }
            Console.WriteLine("The Power of 2 is--" + Result);
        }
    }
}
