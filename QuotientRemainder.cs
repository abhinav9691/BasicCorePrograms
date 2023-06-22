using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class QuotientRemainder
    {
        public void QandR()
        {
            Console.WriteLine("Enter the Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividenr--{0} and Divisor--{1}", dividend, divisor);
            Console.WriteLine("Quotient--" + quotient);
            Console.WriteLine("Reminder--" + remainder);
        }
    }
}
