using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region
//Бородянский Евгений
//    Д3 2
//    Задача 2
//    Написать метод подсчета количества цифр числа.


#endregion

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            long x = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Количесвто цифр в нем равно: " + Calc(x));
        }
        static long Calc (long a)
        {
            int b=0;

            while (a != 0)
            {
                b++;
                a = a / 10;
            }
            return b;
        }
    }
}
