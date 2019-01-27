using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//Бородянский Евгений

//    ДЗ урок 2
//      Задача 5
//      а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
//      нужно ли человеку похудеть, набрать вес или всё в норме.
//      б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

#endregion

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите рост в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес в килогаммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double imt = weight / Math.Pow(height, 2);
            //Console.WriteLine(Math.Pow(height, 2));
            //Console.WriteLine(18.5 * Math.Pow(height, 2));
            //Console.WriteLine(18.5 * Math.Pow(height, 2) - weight);
            Console.WriteLine("Индекс массы вашего тела равен: " +  imt + " кг/кв.м."); // как в данном случае ограничить imt 2-мя знаками после запятой?
            if (imt <= 16) Console.Write("У вас выраженный дефицит массы тела!!! Необходимо набрать вес: " + (18.5 * Math.Pow(height, 2) - weight) + "кг.");
            if (16<imt&&imt<=18.5) Console.Write("У вас недостаточная тела! Необходимо набрать вес: " + (18.5 * Math.Pow(height, 2) - weight) + "кг.");
            if (18.5 < imt && imt <= 25) Console.Write("У вас вес в норме.");
            if (25 < imt && imt <= 30) Console.Write("У вас избыточная масса. Необходимо сбросить вес: " + (weight - 25 * Math.Pow(height, 2) ) + "кг.");
            if (30 < imt && imt <= 35) Console.Write("У вас ожирение! Необходимо сбросить вес: " + (weight - 25 * Math.Pow(height, 2)) + "кг.");
            if (35 < imt && imt <= 40) Console.Write("У вас резкое ожирение!! Необходимо сбросить вес: " + (weight - 25 * Math.Pow(height, 2)) + "кг.");
            if (40 < imt) Console.Write("У вас ОЧЕНЬ резкое ожирение!!! Необходимо сбросить вес: " + (weight - 25 * Math.Pow(height, 2)) + "кг.");
            
        }
    }
}
