namespace task_10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива (n):");
            int n = int.Parse(Console.ReadLine()); // Чтение числа n
            ArrayGeneration(n); // Вызов метода для генерации и вывода массива
        }
        static void ArrayGeneration(int n)
        {
            // Создаем массив размерности n*n
            int[,] array = new int[n, n];

            // Заполняем массив случайными числами
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(1, 100); // Случайные числа от 1 до 99
                }
            }

            // Выводим массив на консоль
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