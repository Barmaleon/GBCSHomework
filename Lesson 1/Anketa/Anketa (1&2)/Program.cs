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
            Console.Write("Введите Ваш рост в см: ");
            string height = Console.ReadLine();
            Console.Write("Введите Ваш вес в кг: ");
            string weight = Console.ReadLine();
            //склеивание
            Console.Write(name + " " + surname + " " + age + " " + height + " " + weight);
            Console.ReadLine();
            string nsahw = name + surname + age + height + weight;
            Console.Write(nsahw);
            Console.ReadLine();
            //форматированный вывод
            int aged = Convert.ToInt32(age);
            double heightd = Convert.ToDouble(height);
            double weightd = Convert.ToDouble(weight);
            Console.Write(name + " " + surname);
            Console.Write("{0:N}", aged);
            Console.Write("{0:N}", heightd);
            Console.Write("{0:N}", weightd);
            Console.ReadLine();
            //вывод со знаком $
            Console.Write(name + " " + surname);
            Console.Write("{0:C1}", aged);
            Console.Write("{0:C1}", heightd);
            Console.Write("{0:C1}", weightd);
            Console.ReadLine();
            //         2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле 
            //            I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.WriteLine("Рост " + name + " = " + heightd);
            Console.WriteLine("Вес " + name + " = " + weightd);
            Console.WriteLine("Индекс массы тела = " + weightd / (heightd * heightd*0.01));
            Console.ReadLine();

            //Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            //Console.WriteLine("Hello, World!");
        }
    }
}