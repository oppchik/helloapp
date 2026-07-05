using System;

class Program
{
    static void Main(string[] args) => SayHello();
    
    static void SayHello()
    {
        Console.WriteLine("hello everyone");
        GreetWhite();
        GreetBlack();
    }

    static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }

    static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}

