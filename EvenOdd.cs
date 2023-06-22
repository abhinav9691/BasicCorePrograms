using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter the Number to Check Even or Odd");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine(" Number {0} is Even", a);
            }
            else
            {
                Console.WriteLine(" Number {0} is Odd", a);
            }
        }
    }
}
