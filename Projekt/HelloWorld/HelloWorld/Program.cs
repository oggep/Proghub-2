﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you alive? Yes or no");
            var yesno = Console.ReadLine();
            Console.WriteLine(name + " " + age + " " + yesno);

            if (18 <= age)
            {
                Console.WriteLine("Du är vuxen");
            };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + "Gruka");
            }
            Console.WriteLine("1, 2 or 3? Hitta korven");
            var cases = Convert.ToInt32(Console.ReadLine());
            switch (cases)
            {
                case 1:
                    Console.WriteLine("Inte korv");
                    break;
                case 2:
                    Console.WriteLine("korv");
                    break;
                case 3:
                    Console.WriteLine("Inte korv");
                    break;


            }
            Console.WriteLine("skriv siffran 1");
            var k = Convert.ToInt32(Console.ReadLine());
            while (k = 1)
            {
                Console.WriteLine("Grattis!");
                k++;
                break
            };

        }
    }
}


