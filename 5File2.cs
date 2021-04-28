using System;
namespace Day_5
{
class Program
{
//responsible for generation of objects
Program()
{
Console.WriteLine("Constructor am called");\\first it will show this
}
//responsible for death of the program
~Program()
{
Console.WriteLine("Destructor am called");\\finally it will destruct those programs
}
static void Main(string[] args)
{
//new operator acquires a new heap mmemory/memory space in heap
//convert heap memory allocation into object
Program p = new Program();
Console.ReadLine();
}
}
}