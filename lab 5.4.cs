using System;
using System.Linq;

namespace Task4
{
    public static class Program
    {
        public static void Main()
        {
            //Лучше явно указывать символ сплита, я лично не помню по чему оно сплитит
            string[] input = Console.ReadLine().Split();
            double[] result = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                bool isInt = int.TryParse(input[i], out int element);
                //Условие лучше инвертировать (сначала isInt, C# оптимизирует логические операторы и тебе это сейчас вредит)
                //Либо, учитывая ситуацию, проверку isInt можно было сделать внешним ифом, внутри которого проверяется знак
                //Кстати у тебя не покрыто значение 0
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
                    //Описание действия с дробными числами немного запутанное, но ты потеряла умножение на 100
                    result[i] = result1;
                }
                Console.Write($"{result[i]}  ");//Лайк за интерполяцию строк
            }
        } 

        //А зачем ему тип double... Факториал же определен только для целых положительных чисел и сам принимает такие же значения
        public static double Factorial(double num)
        {
            int factorial = 1;
            for (int i = 2; i <= num; i++)
                factorial *= i;
            return factorial;
        }
    }
}
