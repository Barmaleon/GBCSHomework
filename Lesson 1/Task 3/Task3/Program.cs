using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static public double Range(double a, double b, double c, double d) => Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2));

        static void Main(string[] args)
        {
            Console.Write("Введите Х1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Х2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введены значения:\n Х1 = " + x1 + "\n Y1 = " + y1 + "\n X2 = " + x2 + "\n Y2 = " + y2);
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.Write("Расстояние между точками:");
            Console.WriteLine("{0:N}", r); //вывод из переменной
            Console.WriteLine("{0:N}", Range(x1,y1,x2,y2)); // вывод методом
            Console.ReadKey();

        }
    }
}
