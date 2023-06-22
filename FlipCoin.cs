using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class FlipCoin
    {
        public void HeadTails()
        {
            int i;
            int headcount = 0;
            int tailscount = 0;
  
            Console.WriteLine("Enter the Number of time You want to Flip the Coin");
            int NumCount = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= NumCount; i++)
            {
                Random random = new Random();
                int randomheadtails = random.Next(0, 1);
                if (randomheadtails < 1)
                {
                    tailscount++;
                }
                else
                {
                    headcount++;
                }
            }
            Console.WriteLine("Percentage of Head and Tails");
            float perhead = headcount / NumCount * 100;
            Console.WriteLine("Percentage of Head Count is --" + perhead);
            float pertails = tailscount / NumCount * 100;
            Console.WriteLine("Percentage of Tails Count is --" + pertails);
        }
    }
}
