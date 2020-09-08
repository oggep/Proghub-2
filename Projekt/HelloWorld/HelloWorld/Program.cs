using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("Are you alive? Yes or no");
            var yesno = Console.ReadLine();

            Console.WriteLine(name + " " + age + " " + yesno);



        }

    } 
}


