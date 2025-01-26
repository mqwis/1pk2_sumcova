namespace task_3_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Начальная сумма вклада");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Проценты");
        double p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Желаемая сумма вклада");
        double y = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        while (x < y)
        {
            x = Math.Floor(x * (1 + p / 100));
            count++;
        }

        Console.WriteLine(count);
    }
}