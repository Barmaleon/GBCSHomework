using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//Бородянский Евгений

//    ДЗ урок 2
//      Задача 6
//      *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
//      «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения 
//      программы, используя структуру DateTime.
#endregion

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            long f = 1;
            int count = 0;
            while(f >= 1 && f <= 1000000000) // пока в заданном диапазоне
            {
              
                if (f%Sum(f)==0) count++; // если число делится на сумму своих цифр, обновляем счетчик
                f++;
            }
            Console.WriteLine(count);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start); // осторожно, считает в районе 2-х минут. 
        }
        static long Sum(long a) // метод подсчета суммы цифр числа
        {
            long s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            return s;
        }
    } }
