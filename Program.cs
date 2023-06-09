﻿using System;
using System.Linq;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса ZadanieOne и вызываем его метод One()
            ZadanieOne zadanieOne = new ZadanieOne();
            zadanieOne.One();

            // Вызываем статический метод Two() из класса ZadanieTwo
            ZadanieTwo.Two();
        }
    }
    public class ZadanieOne
    {
        // Метод для вывода последовательности чисел от 1 до n через запятую
        public void One()
        {
            // Запрашиваем у пользователя целое число n
            Console.Write("Введите число N: ");
            int n;

            // Считываем строку из консоли и пытаемся преобразовать ее в целое число
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                // Если ввод не удался, выводим сообщение об ошибке и завершаем метод
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                return;
            }

            // Создаем последовательность чисел от 1 до n, затем объединяем ее в строку с разделителем ","
            string result = string.Join(", ", Enumerable.Range(1, n));
            // Выводим полученную строку на экран
            Console.WriteLine(result);
        }
    }

    public class ZadanieTwo
    {
        // Метод для вывода "квадрата" со стороной, заданной пользователем, с отверстием в центре
        public static void Two()
        {
            // Запрашиваем у пользователя нечетное целое число n, больше 3
            Console.Write("Введите нечетное число N (больше 3): ");
            int n;

            // Считываем строку из консоли и пытаемся преобразовать ее в целое число
            // Проверяем, что число не меньше 3 и нечетное
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 3 || n % 2 == 0)
            {
                // Если ввод не удался или число меньше 3 или четное, выводим сообщение об ошибке и завершаем метод
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите нечетное число больше 3.");
                return;
            }

            // Выводим на экран квадрат со стороной n, состоящий из символов "#"
            // Если текущие значения строкового и столбцового индексов равны (n/2 + 1), выводим пробел вместо символа "#"
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == n / 2 + 1 && col == n / 2 + 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
