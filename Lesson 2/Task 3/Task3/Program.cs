using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//Бородянский Евгений

//    ДЗ 2
//    Задача 3
//    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.

#endregion

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, count = 0;
            do
            {
                Console.Write("Введите число:");
                a = int.Parse(Console.ReadLine());
                if ((a%2!=0)&&a>0)
                count=count + a;
            }
            while (a != 0);
            Console.WriteLine("Сумма нечетных положительных чисел равна: " + count);

        }
    }
}
