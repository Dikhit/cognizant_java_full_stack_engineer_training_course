using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(){
        Console.WriteLine("Enter the value for x");
        int x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value for y");
        int y = Convert.ToInt32(Console.ReadLine());
        
        string result = "true";
        
        if (x < y){
            result = "true";
        }
        else{
            result = "false";
        }
        
        Console.WriteLine("x is less than y  is {0}", result);
    }
}
