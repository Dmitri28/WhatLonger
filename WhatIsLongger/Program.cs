using System;

namespace WhatIsLongger
{
    class Program
    {
        static void Main(string[] args)
        {
            String name1;
            String name2;
            name1 = Console.ReadLine();
            name2 = Console.ReadLine();
            if (name1.Length > name2.Length)
            {
                Console.WriteLine(name1);
            }
            else
            {
                Console.WriteLine(name2);
            }
        }
    }
}
