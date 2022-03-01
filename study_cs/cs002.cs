using System;


class Program
{
    static void Main(string[] args)
    {
        bool    b = true;
        int     n = 123456;
        double  d = 3.141592653589793238;
        char    c = 'a';
        string  s = "キョえぇぇぇ\uff9f\u0434\uff9f";
        Console.WriteLine(s);           // キョえぇぇぇﾟдﾟ

        // 型の推論もやってくれるらしい

        var     b_ = true;
        var     n_ = 123456;
        var     d_ = 3.141592653589793238;
        var     c_ = 'a';
        var     s_ = "キョえぇぇぇ\uff9f\u0434\uff9f";

        // タプル
        
        /*
        var x = 123;
        var y = 456;
        Console.WriteLine("x->{0}, y->{1}", x, y);

        (x, y) = (y, x);            // 変数の入れ替えに一時変数を用意しなくてもいいらしい

        Console.WriteLine("x->{0}, y->{1}", x, y);
        */

    }
}