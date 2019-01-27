using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//   Бородянский Евгений
//   С# Lv.1 Урок 3 ДЗ Задача 1.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
#endregion

namespace Task1b
{
    class Complex
    {
        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public Complex Minus(Complex x2)//вычитание комплексных чисел
        {
            Complex x3 = new Complex();
            x3.im =  this.im - x2.im;
            x3.re =  this.re - x2.re;
            return x3;
        }

        public Complex Multi(Complex x2)//произведение комплексных чисел
        {
            Complex x3 = new Complex();
            x3.im = re*x2.im  + this.im*x2.re;
            x3.re = re*x2.re - this.im*x2.im;
            return x3;
        }

       



        public string ToString()
        {
            if (im > 0) // добавим условие, чтобы убрать лишний "+" в случае если мнимая часть отрицательна
                return re + "+" + im + "i";
            else return re + "" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2); // проверяем вычитание
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2); // проверяем умножение
            Console.WriteLine(result.ToString());
        }
    }

}
