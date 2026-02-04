using System;

class Program
{
    static void changeVal(ref int x)
    {
        x = 10;
    }

    static void Main(string[] args)
    {
        int a = 5;
        Console.WriteLine(a);
        changeVal(ref a);
        Console.WriteLine(a);
    }
}
