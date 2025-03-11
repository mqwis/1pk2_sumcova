﻿namespace task_4_8;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] numbers = new int[50]; // массив на 50 чисел
        int pairCount = 0;

        // вводим циклы

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    pairCount++;
                }
            }
        }

        // вводим текст в консоль

        Console.WriteLine("Массив:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Количество пар равных чисел: " + pairCount);
    }
}