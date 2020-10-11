using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Huvudclass
{
    class Program
    {
        Customer customer = new Customer { name = "" };
        Product product = new Product();
        public static List<string> cart = new List<string>();
        public static int Shoppingcart;



        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("The Customers name is " + name);
            
            Program.shop();
        }
        static void shop()
        {
            while (true)
            {
                Console.WriteLine("What type of product do you want?");
                Console.WriteLine("1. Shirt," + " 2. Pant" + " 3. I want to check out.");
                int Shoppingcart = Convert.ToInt32(Console.ReadLine());

                switch (Shoppingcart)
                {
                    case 1:
                        cart.Add("shirt");
                        continue;
                    case 2:
                        cart.Add("pant");
                        continue;
                    case 3:
                        Console.WriteLine("Your order:");
                     
                     break;
                }
                break;
            }
            cart.ToArray();
            foreach (var Shoppingcart in cart)
            {
                Console.WriteLine(Shoppingcart);

            }
        }
    }
}
