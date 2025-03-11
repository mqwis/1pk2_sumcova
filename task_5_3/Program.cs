namespace task_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[3, 3]
            {
                {'a', 'b', 'c'},
                {'d', 'e', 'f'},
                {'g', 'h', 'i'}
            };

            char[,] arr2 = new char[3, 3]
            {
                 {'a', 'm', 'c'},
                {'d', 'e', 'x'},
                {'p', 'q', 'i'}
            };

            bool ravno = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] != arr2[i, j])
                    {
                        ravno = false;
                        break;
                    }
                }

                if (ravno == false)
                {
                    break;
                }
            }

            if (ravno == true)
            {
                Console.WriteLine("Массивы равны");

            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (arr[i, j] == arr2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(arr[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(arr[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (arr[i, j] == arr2[i, j])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(arr2[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(arr2[i, j] + "\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
