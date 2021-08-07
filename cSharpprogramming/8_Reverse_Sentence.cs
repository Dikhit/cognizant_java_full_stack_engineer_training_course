using System;
using System.Collections.Generic;

public class Program      //DO NOT change the class name
{
    public static void Main() {
        Console.WriteLine("Enter a string");
        string line = Console.ReadLine();
        
        
        string result = "";
        List < string > wordsList = new List < string > ();
            string[] words = line.Split(new [] {
            " "
        }, StringSplitOptions.None);
        for (int i = words.Length - 1; i >= 0; i--) {
            result += words[i] + " ";
        }
        wordsList.Add(result);
        foreach(String s in wordsList) {
            Console.WriteLine(s);
        }
  }
}
