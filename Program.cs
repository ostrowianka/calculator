using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz działanie:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            int choose = 0;
            double a= 0, b=0;
            choose=int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                {
                    Console.WriteLine("Podaj pierwszą liczbę");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę");
                    b = double.Parse(Console.ReadLine());

                    double result = Addition(a, b);
                    Console.WriteLine($"Wynik dodawania: {result}");
                    break;
                }
               
            }
        }
        public static double Addition (double a, double b)
        {
            double result = a+ b;
            return result;
        }
       
    }
}
