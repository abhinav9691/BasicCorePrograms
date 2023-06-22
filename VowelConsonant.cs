using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms1
{
    public class VowelConsonant
    {
        public void VowelConsnt()
        {
            Console.WriteLine("Enter the Alphabet A-Z or a-z");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'e':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'i':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'o':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                case 'u':
                    Console.WriteLine("{0} is Vowel", ch);
                    break;
                default:
                    Console.WriteLine("{0} is not Vowel", ch);
                    break;
            }
        }
    }
}
