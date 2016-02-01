using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main()
    {
        //Project Euler #1: Multiples of 3 and 5
        long t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());

            long mid3 = (n - 1) / 3;
            long mid5 = (n - 1) / 5;
            long mid15 = (n - 1) / 15;

            long sum = 3 * mid3 * (mid3 + 1) / 2;
            sum += 5 * mid5 * (mid5 + 1) / 2;
            sum -= 15 * mid15 * (mid15 + 1) / 2;

            Console.WriteLine(sum);
        }
    }
}