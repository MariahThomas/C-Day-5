using System;

public static void SubString(string input)  
{  
    string final = "";  
    for (int i = 0; i < input.Length; i++)  
    {  
        string str = "";  
        for (int j = i; j < input.Length; j++)  
        {  
            str += input[j];  
            final += str + ",";  
        }  
    }  
    final = final.Remove(final.Length - 1, 1);  
    string[] arr = final.Split(',');  
    arr = arr.Distinct().ToArray();  
    for (int i = 0; i < arr.Length; i++)  
        Console.Write(arr[i]+" ");  
 }