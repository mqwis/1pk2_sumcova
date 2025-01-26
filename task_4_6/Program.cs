using System;

namespace task_4_6
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int[] numbers = new int[10]; // Массив на 10 чисел
            int max = 0; // Для хранения максимума по модулю

            // Заполняем массив
            for (int i = 0; i < numbers.Length; i++)
            {
                int num;
                bool exists;

                // Генерируем число и проверяем его уникальность
                while (true)
                {
                    num = rand.Next(-100, 101); // Случайное число от -100 до 100
                    exists = false;

                    // Проверяем, есть ли такое число по модулю
                    for (int j = 0; j < i; j++)
                    {
                        if (Math.Abs(numbers[j]) == Math.Abs(num))
                        {
                            exists = true;
                            break;
                        }
                    }

                    // Если число уникальное, выходим из цикла
                    if (!exists)
                    {
                        break;
                    }
                }

                numbers[i] = num; // Добавляем уникальное число в массив
            }

            // Ищем максимум по модулю
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(max))
                {
                    max = numbers[i];
                }
            }

            // Выводим массив и результат
            Console.WriteLine("Полученный массив:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Наибольшее число по модулю : " + max);
        }
    }
}