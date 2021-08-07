using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2               //DO NOT Change namespace name
{
    public class Program                //DO NOT Change class 'Program' name
    {
        public static void Main(string[] args)        //DO NOT Change 'Main' method Signature
        {
            Console.WriteLine("Enter a Number");
            double num = double.Parse(Console.ReadLine());
            
            double square = FindSquare(num);
            double cube = FindCube(num);
            
            Console.WriteLine("Square of {0} is {1}", num, square);
            Console.WriteLine("Cube of {0} is {1}", num, cube);
            
            
        }

      //Implement methods here. Keep the method 'public' and 'static'
      public static double FindSquare(double num){
          return num * num;
      }
      
      public static double FindCube(double num){
          return num * num * num;
      }
    }
}
