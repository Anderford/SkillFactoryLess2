using System;
IfElse();
ArraySearch();
ForEachFun();
ForEachFunLvlTWo();
MultidimensionalArray();
ArrayTest();
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


static void MultidimensionalArray()
{
    int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
    foreach(var a in array)
    {
        Console.Write(a);
    }

    int[,] Array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

    for (int i = 0; i < Array.GetUpperBound(1) + 1; i++)
    {
        for (int k = 0; k < Array.GetUpperBound(0) + 1; k++)
            Console.Write(Array[k, i] + " ");

        Console.WriteLine();
    }


    var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for(int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    foreach (var item in arr)
    {
        Console.Write(item);
    }

    int[][] rray = new int[3][];

    rray[0] = new int[2] { 1, 2 };
    rray[1] = new int[3] { 1, 2, 3 };
    rray[2] = new int[5] { 1, 2, 3, 4, 5 };

    foreach (var num in rray)
    {
        foreach (var item in num)
        {
            Console.Write(item + " ");
        }
    }


    var Tarray = new int[] { 5, 6, 9, 1, 2, 3, 4 };

    foreach(var item in Tarray)
    {
        if(item % 2 == 0)
        {
            Console.Write(item + " ");
        }
    }

    int[,] Bigarr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

    foreach (var num in Bigarr)
    {
        if(num > 0)
        {
            Console.Write(num);
        }
    }

    int[,] Superarr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
    int stemp;
    for (int i = 0; i <= Superarr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= Superarr.GetUpperBound(1); j++)
            for (int k = j + 1; k <= Superarr.GetUpperBound(1); k++)
                if (Superarr[i, j] > (Superarr[i, k]))
                {
                    stemp = Superarr[i, k];
                    Superarr[i,k] = Superarr[i,j];
                    Superarr[i,j] = stemp;
                }
    }

    foreach(var item in Superarr)
    {
        Console.Write(item);
    }
}


static void ArrayTest()
{


    (string? name, string?[] dishes) User;

    Console.WriteLine("Your name:");
    User.name = Console.ReadLine();
    User.dishes = new string[5];
    Console.WriteLine("Your favorite dishes (5 dishes):");

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"You favorit dishes {i + 1}");
        User.dishes[i] = Console.ReadLine();
       
    }

    Console.WriteLine($"You name {User.name}, yor favorite dishes: {string.Join(" ,", User.dishes)}");


}
