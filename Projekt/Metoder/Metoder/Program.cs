using System;

namespace Metoder
{
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 4 olika tal");
            var numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(CalculateNumbers(numbers));
            ReverseArray();
            MinMax();
            
        }

        private static int CalculateNumbers(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
        private static void ReverseArray()
        {
            var names = new string[5];
            Console.WriteLine("Skriv 5 namn");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            };
            Console.WriteLine("");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
        }

    
        private static int MinMax(){
            int[] anArray = { 1, 5, 2, 7 };

            var Highestnumber = 0;
            var lowestnumber = 0;
            for (int i = 1; i < anArray.Length; i++)
            {
                if (Highestnumber < anArray[i])
                {
                    Highestnumber = anArray[i];
                }
                if (lowestnumber > anArray[i])
                {
                    lowestnumber = anArray[i];
                    
                }
                if (lowestnumber == 0) {
                lowestnumber = 1;               
            }

            }
            Console.WriteLine(Highestnumber);
            Console.WriteLine(lowestnumber);
            return (lowestnumber + Highestnumber);




        }
    }
}

