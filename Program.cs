using System;

IfElse();
ArraySearch();
ForEachFun();
ForEachFunLvlTWo();

static void IfElse()
{
    string a = "a";
    string b = "b";

    bool c = a != b;

    int A = 2;
    int B = 1;
    double X = 2.3;
    double Y = 2.5;

    int C = A > B ? ++A : B;
    Console.WriteLine(C);

    bool XY = (A < B) || (X > Y);

    Console.WriteLine(c);
    Console.WriteLine(XY);

    var inv = true;
    var result = !inv;
    Console.Write(result);

    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");



    /*if (color == "red")
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Your color is red!");
    }

    else if (color == "green")
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Your color is green!");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Your color is cyan!");
    }*/
    int i = 0;

    for (; i < 5;)
    {
        var color = Console.ReadLine();
        Console.WriteLine($"Iteration {i}");
        switch (color)
        {
            case "yellow":
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            case "blue":
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                break;

        }
        i++;
    }

    int k = 0;

    while (k < 5)
    {
        Console.WriteLine(k);
        k++;
    }


    int t = 0;

    do
    {
        Console.WriteLine(t);

        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        switch (Console.ReadLine())
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }

        t++;
    } while (t < 3);
}

static void ArraySearch()
{
    var MyArray = new int[] { 31, 52, 43, 44, 25, 56 };
    int MinValue = 100000, MaxValue = 0, maxIndex = 0,
    minIndex = 1;

    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] < MinValue)
        {
            MinValue = MyArray[i];
            minIndex = i;
        }
    }

    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] > MaxValue)
        {
            MaxValue = MyArray[i];
            maxIndex = i;
        }
    }

    Console.WriteLine($"Наименьший элемент массива {MinValue}, его индекс {minIndex}");
    Console.WriteLine($"Наибольший элемент массива {MaxValue}, его индекс {maxIndex}");
}


static void ForEachFun()
{
    Console.WriteLine("Ваше имя");
    string? name = Console.ReadLine();
    Console.WriteLine(name);
    Console.WriteLine("Ваше имя по буквам:");
    foreach (var s in name!)
    {
        Console.Write(s + " ");
    }
    Console.WriteLine($"Последняя буква {name[name.Length - 1]}");
}


static void ForEachFunLvlTWo()
{
    Console.WriteLine("Ваше имя");
    string? name = Console.ReadLine();
    
    for (int i = name!.Length - 1; i >= 0; i--)
    {
        Console.Write(name[i] + "");
    }
}
    

