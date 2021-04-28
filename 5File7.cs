using System.IO;
using System;

class Program
{
    public static void Main()
    {
        DateTime dt = new DateTime(2021,5,28,3,25,5);
        Console.WriteLine(String.Format("{0:d/M/yyyy HH:mm:ss}",dt));
        Console.ReadLine();
    }
}