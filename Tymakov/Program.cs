using System;
using System.Linq.Expressions;
class Programm
{
    static void Main()
    {
        Console.WriteLine("Выберите задание:");
        Console.WriteLine("1 - Упражнение 4.1");
        Console.WriteLine("2 - Упражнение 4.2");
        Console.WriteLine("3 - Домашнее задание 4.1");
        Console.WriteLine("Ваш выбор:");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            //Упражнение 4.1
            Console.WriteLine("Введите номер дня в году:");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day <= 31)
                Console.WriteLine(day + "января");
            else if (day <= 59)
                Console.WriteLine((day - 31) + "февраля");
            else if (day <= 90)
                Console.WriteLine((day - 59) + "марта");
            else if (day <= 120)
                Console.WriteLine((day - 90) + "апреля");
            else if (day <= 151)
                Console.WriteLine((day - 120) + "мая");
            else if (day <= 181)
                Console.WriteLine((day - 151) + "июня");
            else if (day <= 212)
                Console.WriteLine((day - 181) + "июля");
            else if (day <= 243)
                Console.WriteLine((day - 212) + "августа");
            else if (day <= 273)
                Console.WriteLine((day - 243) + "сентября");
            else if (day <= 304)
                Console.WriteLine((day - 273) + "октября");
            else if (day <= 334)
                Console.WriteLine((day - 304) + "ноября");
            else
                Console.WriteLine((day - 334) + "декабря");
        }
        else if (choice == 2)
        {
            try
            {
                //Упражнение 4.2
                Console.WriteLine("Введите номер дня в году:");
                int day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 365)
                {
                    throw new Exception("Число должно быть от 1 до 365!");
                }
                if (day <= 31)
                    Console.WriteLine(day + "января");
                else if (day <= 59)
                    Console.WriteLine((day - 31) + "февраля");
                else if (day <= 90)
                    Console.WriteLine((day - 59) + "марта");
                else if (day <= 120)
                    Console.WriteLine((day - 90) + " апреля");
                else if (day <= 151)
                    Console.WriteLine((day - 120) + "мая");
                else if (day <= 181)
                    Console.WriteLine((day - 151) + "июня");
                else if (day <= 212)
                    Console.WriteLine((day - 181) + "июля");
                else if (day <= 243)
                    Console.WriteLine((day - 212) + "августа");
                else if (day <= 273)
                    Console.WriteLine((day - 243) + "сентября");
                else if (day <= 304)
                    Console.WriteLine((day - 273) + "октября");
                else if (day <= 334)
                    Console.WriteLine((day - 304) + "ноября");
                else
                    Console.WriteLine((day - 334) + "декабря");
            }
            catch(Exception error)
            {
                Console.WriteLine("Ошибка:" + error.Message);
            }
        }
        else if (choice == 3)
        {
            try
            {
                //Задание 4.1
                Console.Write("Введите год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер дня в году: ");
                int day = Convert.ToInt32(Console.ReadLine());
                bool leapYear; if (year % 400 == 0)
                    leapYear = true;
                else if (year % 100 == 0)
                    leapYear = false;
                else if (year % 4 == 0)
                    leapYear = true;
                else leapYear = false;
                int daysInYear;
                if (leapYear) daysInYear = 366;
                else daysInYear = 365;
                if (day < 1 || day > daysInYear)
                {
                    throw new Exception("Неверный номер дня!");
                }
                if (day <= 31)
                    Console.WriteLine(day + " января");
                else if (day <= 59 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 31) + " февраля");
                else if (day <= 90 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 59 - (leapYear ? 1 : 0)) + " марта");
                else if (day <= 120 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 90 - (leapYear ? 1 : 0)) + " апреля");
                else if (day <= 151 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 120 - (leapYear ? 1 : 0)) + " мая");
                else if (day <= 181 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 151 - (leapYear ? 1 : 0)) + " июня");
                else if (day <= 212 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 181 - (leapYear ? 1 : 0)) + " июля");
                else if (day <= 243 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 212 - (leapYear ? 1 : 0)) + " августа");
                else if (day <= 273 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 243 - (leapYear ? 1 : 0)) + " сентября");
                else if (day <= 304 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 273 - (leapYear ? 1 : 0)) + " октября");
                else if (day <= 334 + (leapYear ? 1 : 0))
                    Console.WriteLine((day - 304 - (leapYear ? 1 : 0)) + " ноября");
                else
                    Console.WriteLine((day - 334 - (leapYear ? 1 : 0)) + " декабря");
            }
            catch (Exception error)
            {
                Console.WriteLine("Ошибка: " + error.Message);
            }
        }
        else
        {
            Console.WriteLine("Такого задания нет!");
        }
    }
}