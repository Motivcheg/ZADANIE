    Console.WriteLine("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите третье число: ");
    int c = int.Parse(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine($"Число {a} самое большое.");
    }
   
    else if (a > c)
    {
        Console.WriteLine($"Число {a} самое большое.");
    }

    else if (c < b)
    {
        Console.WriteLine($"Число {b} самое большое.");
    }

    else
    {
        Console.WriteLine($"Число {c} самое большое.");
    }