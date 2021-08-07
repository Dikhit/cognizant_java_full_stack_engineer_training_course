using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args){
        Console.WriteLine("Enter first name ");
        string firstName = Console.ReadLine();
        
        Console.WriteLine("Enter last name ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine("Full Name : {0} {1}", firstName, lastName);
    }
}
