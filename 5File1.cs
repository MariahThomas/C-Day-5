using System.IO;
using System;

class Program
{
    Program()
    {
        Console.WriteLine("Constructor am called");
    }
    
    ~Program()
    {
        Console.WriteLine("Destructor am called");
    }
    static void Main()
    {
        Program p = new Program();
        Console.ReadLine();
    }
}