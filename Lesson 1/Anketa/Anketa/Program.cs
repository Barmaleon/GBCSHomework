using System;
#region
// Бородянский Евгений
//
//         1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
//              В результате вся информация выводится в одну строчку:
//            а) используя склеивание;
//            б) используя форматированный вывод;
//            в) используя вывод со знаком $.
//         2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле 
//            I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
#endregion

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу 'Анкета'!");
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write("Введите Ваш рост: ");
            string height = Console.ReadLine();
            Console.Write("Введите Ваш вес: ");
            string weight = Console.ReadLine();
            Console.Write(name + " " + surname + " " + age + " " + height + " " + weight);
            Console.ReadLine();
            string nsahw = name + surname + age + height + weight;
            Console.Write(nsahw);
            Console.ReadLine();
        }
    }
}