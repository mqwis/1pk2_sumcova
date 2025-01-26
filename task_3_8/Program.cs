namespace task_3_8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите начальное натуральное число");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите конечное натуральное число");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int temp = num2 - num1;
        for (int i = 0; i < temp; i++)
        {
            if (num1 % 3 == 0 && num1 % 5 != 0)
            {
                Console.WriteLine(num1);
            }

            num1 = num1 + 1;
        }
    }
}