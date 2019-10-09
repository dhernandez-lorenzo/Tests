using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add: "+Add(4,5));
        Console.WriteLine("IsOdd: "+IsOdd(5));

    }

    public static int Add(int x, int y){
        return x + y;
    }
    public static bool IsOdd(int value){
        return value % 2 == 1;
    }
}

