while(true)
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число: ");
    int b = int.Parse(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine($"Число {a} больше числа {b}.");
    }

    else
    {
        Console.WriteLine($"Число {a} меньше числа {b}.");
    }

}