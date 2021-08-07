using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
    
            Console.WriteLine("Enter your age : ");
            string age = Console.ReadLine();
    
            Console.WriteLine("Enter your country : ");
            string country = Console.ReadLine();
            
            Console.WriteLine("Welcome {0}. Your age is {1} and you are from {2}", name, age, country);
        }
    }
}
