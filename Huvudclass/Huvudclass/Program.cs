using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Huvudclass
{
    class Program
    {   //Dessa är mina objekt, listor och globala variabler
        Customer customer = new Customer { name = "" };
        Product product = new Product();
        public static List<string> cart = new List<string>();
        public static int Shoppingcart;


        //I min mainmetod så ger den kunden ett namn och kopplar till min beställning
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("The Customers name is " + name);
            
            Program.shop();
        }
        //här väljer du vad du vill köpa eller gå vidare
        static void shop()
        {
            while (true)
            {
                Console.WriteLine("What type of product do you want?");
                Console.WriteLine("1. Shirt," + " 2. Pant" + "3. Shoes" + "4. I want to check out.");
                int Shoppingcart = Convert.ToInt32(Console.ReadLine());

                switch (Shoppingcart)
                {
                    case 1:
                        var Shirts = new Shirts();
                        cart.Add("Shirt");
                        continue;
                    case 2:
                        var Pants = new Pants();
                        cart.Add("Pants");
                        continue;
                    case 3:
                        var Shoes = new Shoes();
                        cart.Add("Shoes");
                        continue;
                    case 4:
                        Console.WriteLine("Your order:");
                        break;
                }
                break;
            }
            //Här printar den ut alla dina produkter som du har valt.
            cart.ToArray();
            foreach (var Shoppingcart in cart)
            {
                Console.WriteLine(Shoppingcart);

            }
        }
    }
}
