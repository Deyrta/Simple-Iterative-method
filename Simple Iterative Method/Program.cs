using System;

namespace Lab1KMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple_Iterative_Method SIM = new Simple_Iterative_Method();
            SIM.Method();
            Console.ReadKey();
        }
    }

    class Simple_Iterative_Method
    {
        private double x;
        private double function;
        private double pohybka;
        private double accuracy;

        public void Method()
        {
            Console.WriteLine("Enter a accuracy and first x:");
            accuracy = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            while (true)
            {
                function = (1 - 2 * x * x * x) / 2; // derivative from function
                pohybka = function - x;
                x = function;
                if (pohybka < accuracy)
                {
                    Console.WriteLine("Result is:" + x);
                    break;
                }
                else
                    continue;
            }
        }
    }
}
