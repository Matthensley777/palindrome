using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
            public static bool Palindrome(string value)
            {
                int min = 0;
                int max = value.Length - 1;
                while(true)
                {
                    if(min > max)
                    {
                    return true;
                    }
                char front = value[min];
                char back = value[max];

                if (char.ToLower(front) != char.ToLower(back))
                {
                    return false;
                }
                min++;
                max--;
                }
            }

        static void Main()
        {
            string[] Array =
            {
                "wow",
                "Hells to the naw",
                "Some Men interpret nine memos",
            };

            foreach (string value in Array)
            {
                Console.WriteLine("{0} = {1}", value, Palindrome(value));
            }
            Console.ReadLine();
        }
    }
    
}
