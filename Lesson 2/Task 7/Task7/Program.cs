using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//Бородянский Евгений

//    ДЗ урок 2
//      Задача 7
//      a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//      б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
#endregion

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите первое число:");
            long b = Convert.ToInt64(Console.ReadLine());
            long a1 = a;
            long b1 = b;
            RecursiveShow(a, b);
            RecursiveSum(a, b);
        }
        static void RecursiveShow(long a, long b)                   
        {
            Console.Write("{0,4} ", a);
            if (a < b) RecursiveShow(a + 1, b);

        }
        static void RecursiveSum(long a, long b)
        {
            long sum = a + 1;
            if (a < b) RecursiveSum(a + 1, b); // тут явно что-то не так, но с пониманием рекурсии очень туго, объясните ошибку если можно.
            Console.Write(sum);

        }
    }
}
