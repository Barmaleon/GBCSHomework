using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region
// Бородянский Евгений
//
//4. Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.
//
// Работает только для числовых значений
#endregion
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите переменную а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите переменную b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            a = a + b; //без использования 3-й переменной
            b = a - b;
            a = a - b;
            Console.WriteLine("a теперь = " + a + ", b теперь = " + b);
            Console.ReadKey();
            double c; // с использованием 3-й переменной
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Поменяли обратно: a теперь = " + a + ", b теперь = " + b);
            Console.ReadKey();
        }
    }
}
