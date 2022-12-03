using System;
using System.Linq;

namespace Task4
{
    public static class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            double[] result = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                bool isInt = int.TryParse(input[i], out int element);
                if (element > 0 && isInt)
                {
                    result[i] = Factorial(element);
                }
                else if (element < 0 && isInt)
                {
                    result[i] = element;
                }
                else
                {
                    double num = double.Parse(input[i]);
                    Math.Round(num, 2);
                    double result1 = num - (int)num;
                    result[i] = result1;
                }
                Console.Write($"{result[i]}  ");
            }
        } 

        public static double Factorial(double num)
        {
            int factorial = 1;
            for (int i = 2; i <= num; i++)
                factorial *= i;
            return factorial;
        }
    }
}