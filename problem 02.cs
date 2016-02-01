using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main()
    {
        //Project Euler #2: Even Fibonacci numbers

        long t = long.Parse(Console.ReadLine());

        for (long i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            long f1 = 2;
            long f2 = 8;
            long sum = f1 + f2;
            long num = 4 * f2 + f1;
            while (num <= n)
            {
                sum += num;
                f1 = f2;
                f2 = num;
                num = 4 * f2 + f1;
            }
            Console.WriteLine(sum);
        }
    }
}