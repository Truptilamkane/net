using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main1(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter String");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("palindrome", s, revs);
            }
            else
            {
                Console.WriteLine("not palindrome", s, revs);
            }
            Console.ReadLine();
        }
    }
}


