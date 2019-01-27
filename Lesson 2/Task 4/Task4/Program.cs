using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region
//Бородянский Евгений

//    ДЗ 2
//    Задача 4
//    Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
//  На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//  Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
//    программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.


#endregion
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string login, password;
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                count++;
                if (!Access(login, password)) Console.WriteLine("Неверно! Осталось попыток: " + (3-count) + "!");
            }
            while (count<3&&!Access(login,password));
            if (Access(login, password)) Console.WriteLine("Вы прошли!");
            else Console.WriteLine("Вы не прошли!");
        }
        static bool Access (string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else return false;
        }
    }
}
