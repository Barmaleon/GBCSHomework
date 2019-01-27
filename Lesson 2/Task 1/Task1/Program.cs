using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region
//Бородянский Евгений

//    ДЗ урок 2
//Задача 1
//    Написать метод, возвращающий минимальное из трёх чисел.
#endregion

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ("Минимальное: "+ Big(x1, x2, x3));

        }

        static double Big (double a, double b, double c)
        {
            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= a && b <= c)
            {
                return b;
            }
            else return c;
        }

    }
}
