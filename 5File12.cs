using System;
 
class Class10
{
static void print2largest(int []arr,
                          int arr_size)
{
  int i;
  if (arr_size < 2)
  {
    Console.Write(" Invalid Input ");
    return;
  }
 
  Array.Sort(arr);
  for(i = arr_size - 2; i >= 0; i--)
  {
    if (arr[i] != arr[arr_size - 1])
    {
      Console.Write("The second largest " +
                    "element is {0}\n", arr[i]);
      return;
    }
  }
 
  Console.Write("There is no second " +
                "largest element\n");
}
public static void Main(String[] args)
{
  int []arr = { 12, 35, 1, 10, 34, 1 };
  int n = arr.Length;
   
  print2largest(arr, n);
}
}