using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("name: ");
        var name = Console.ReadLine();

        Console.Write("age: ");
        var age = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} ({1}歳)さん こんにちは。", name, age);
    }
}