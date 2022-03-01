using System;

class Program
{
    static void Main(string[] args)
    {
        double a_double, b_double;
        a_double = 1.0;
        b_double = 81.0;

        Console.WriteLine("###double###");
        Console.WriteLine(a_double / b_double);
        
        
        decimal a_decimal, b_decimal;
        a_decimal = 1.0m;
        b_decimal = 81.0m;

        Console.WriteLine("###decimal###");
        Console.WriteLine(a_decimal / b_decimal);
    }
}