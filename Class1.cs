﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main1(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter your prime no");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write("prime");
            }
        }
    }
}


  
