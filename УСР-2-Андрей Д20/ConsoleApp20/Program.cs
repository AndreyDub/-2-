
using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, result; // не очень хороший способ объявления переменных. Лучше кажую с новой строки. Это не ошибка. И не соответствует правилам именования.
            char option;

            Console.Write("Введите первое число: ");
            N1 = Convert.ToInt32(Console.ReadLine()); // желательно добавить обработку исключения, в случае, если не удастся преобразовать прочитанную строку в int (например, ввели дробное число, или буквы...)

            Console.Write("Введите второе число: ");
            N2 = Convert.ToInt32(Console.ReadLine()); // желательно добавить обработку исключения, в случае, если не удастся преобразовать прочитанную строку в int (например, ввели дробное число, или буквы...)

            Console.WriteLine("Калькулятор");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            Console.Write("Введите номер операции, которую вы хотите выполнить: ");
            option = Convert.ToChar(Console.ReadLine()); // желательно добавить обработку исключения, в случае, если не удастся преобразовать прочитанную строку в int (например, ввели дробное число, или буквы...)

            switch (option)
            {
                case '1':
                    result = N1 + N2;
                    Console.WriteLine($"Результат сложения: {result}");
                    break;

                case '2':
                    result = N1 - N2;
                    Console.WriteLine($"Результат вычитания: {result}");
                    break;

                case '3':
                    result = N1 * N2;
                    Console.WriteLine($"Результат умножения: {result}");
                    break;

                case '4':
                    result = N1 / N2; // // желательно добавить обработку исключения, в случае, если второе число = 0
                    Console.WriteLine($"Результат деления: {result}");
                    break;

                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }

            Console.ReadLine();
        }
    }
}
