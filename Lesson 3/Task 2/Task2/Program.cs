using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//   Бородянский Евгений
//   С# Lv.1 Урок 3 ДЗ Задача 2.
//  2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
//  Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
//  б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
//    При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
#endregion

namespace Task2
{
    class Program
    {
        static int value;
        static string console_message = "Введите число:";
        static int GetValue(string message)
        {
            int x;
            int count=0;
            string s;
            bool flag;       // Логическая переменная, выступающая в роли "флага". 
                             // Истинно (флаг поднят), ложно (флаг опущен)
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                //  Если перевод произошел неправильно, то результатом будет false
                flag = int.TryParse(s, out x);
                while (flag == false)// обработка некорректных данных
                {
                    Console.WriteLine("Введены неверные данные, попробуйте ещё раз.\nВведите число: ");
                    s = Console.ReadLine();
                    flag = int.TryParse(s, out x);
                }
                if (x % 2 != 0 && x > 0)
                {
                    count = count + x;
                    Console.WriteLine("Введено нечетное положительное число: " + x);
                    
                }
                
            }
            while (s!="0");  
            return count;
        }

        static void Main()
        {
            value = GetValue(console_message);
            Console.WriteLine("Сумма всех введенных нечетных положительных чисел ..." + value);

        }
    }

}
