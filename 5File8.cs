using System.IO;
using System;

class Program
{
    public static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine(String.Format("{0:MMM}",dt));
        Console.ReadLine();
    }
}