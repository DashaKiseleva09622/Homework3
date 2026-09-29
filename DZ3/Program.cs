using System;

class Program
{
    enum Days
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    static void Main()
    {
        // Задание 1
        Console.WriteLine("Задание 1");
        int[] a = new int[10];
        Console.WriteLine("Введите 10 чисел:");
        for (int i = 0; i < 10; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 1; i < 10; i++)
        {
            if (a[i] <= a[i - 1])
            {
                Console.WriteLine("Последовательность не упорядочена");
                Console.WriteLine("Первое нарушение: " + (i + 1));
                break;
            }
            if (i == 9)
            {
                Console.WriteLine("Последовательность упорядочена");
            }
        }

        // Задание 2
        Console.WriteLine();
        Console.WriteLine("Задание 2");
        try
        {
            Console.WriteLine("Введите номер карты от 6 до 14:");

            int k = Convert.ToInt32(Console.ReadLine());

            if (k == 6)
                Console.WriteLine("Шестерка");
            else if (k == 7)
                Console.WriteLine("Семерка");
            else if (k == 8)
                Console.WriteLine("Восьмерка");
            else if (k == 9)
                Console.WriteLine("Девятка");
            else if (k == 10)
                Console.WriteLine("Десятка");
            else if (k == 11)
                Console.WriteLine("Валет");
            else if (k == 12)
                Console.WriteLine("Дама");
            else if (k == 13)
                Console.WriteLine("Король");
            else if (k == 14)
                Console.WriteLine("Туз");
            else
                throw new Exception();
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
        finally
        {
            Console.WriteLine("Задание 2 завершено");
        }

        // Задание 3
        Console.WriteLine();
        Console.WriteLine("Задание 3");
        Console.WriteLine("Введите профессию:");
        string word = Console.ReadLine().ToLower();
        if (word == "jabronl")
        {
            Console.WriteLine("Patron Tequila");
        }
        else if (word == "school counselor")
        {
            Console.WriteLine("Anything with Alcohol");
        }
        else if (word == "programmer")
        {
            Console.WriteLine("Hipster Craft Beer");
        }
        else if (word == "bike gang member")
        {
            Console.WriteLine("Moonshine");
        }
        else if (word == "politician")
        {
            Console.WriteLine("Your tax dollars");
        }
        else if (word == "rapper")
        {
            Console.WriteLine("Cristal");
        }
        else
        {
            Console.WriteLine("Beer");
        }

        // Задание 4
        Console.WriteLine();
        Console.WriteLine("Задание 4");
        Console.WriteLine("Введите номер дня недели:");
        int number = Convert.ToInt32(Console.ReadLine());
        Days day = (Days)number;
        Console.WriteLine(day);

        // Задание 5
        Console.WriteLine();
        Console.WriteLine("Задание 5");
        string[] dolls =
        {
            "Hello Kitty",
            "Barbie doll",
            "Teddy Bear",
            "Hello Kitty",
            "Barbie doll"
        };
        int bag = 0;
        foreach (string doll in dolls)
        {
            if (doll == "Hello Kitty" || doll == "Barbie doll")
            {
                bag++;
            }
        }
        Console.WriteLine("Количество кукол: " + bag);
    }
}