namespace task_10_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем у пользователя размерность массива
            Console.WriteLine("Введите размерность массива (n):");
            int n = int.Parse(Console.ReadLine());

            // Генерируем массив
            char[,] array = GenerateRussianAlphabetArray(n);

            // Выводим массив на консоль
            PrintArray(array);
        }
        static char[,] GenerateRussianAlphabetArray(int n)
        {
            char[,] array = new char[n, n];
            Random random = new Random();

            // Начальный символ русского алфавита (А)
            char startChar = 'А';

            // Заполняем массив символами русского алфавита
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Генерируем случайный символ из русского алфавита
                    array[i, j] = (char)(startChar + random.Next(0, 32)); // 32 символа в русском алфавите
                }
            }

            return array;
        }

        // Метод для вывода двумерного массива на консоль
        static void PrintArray(char[,] array)
        {
            int n = array.GetLength(0); // Получаем размерность массива

            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + "\t"); // Вывод с табуляцией для красоты
                }
                Console.WriteLine(); // Переход на новую строку после каждой строки массива
            }
        }
    }
}