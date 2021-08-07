using System;

class Calculator{

    public Calculator(){}
    public int Addition(int a, int b){
        return a+b;
    }

    public int Subtraction(int a, int b){
        return a-b;
    }

    public int Multiplication(int a, int b){
        return a*b;
    }

    public double Division(int a, int b, out double remainder){
        remainder = a % b;
        return (a/b);
    }
}

public class Prgram{
    public static void Main(string[] args){
        Console.WriteLine("Enter the operator");
        string op = Console.ReadLine();

        Console.WriteLine("Enter the operands");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Calculator c = new Calculator();

        switch(op){
            case "+":
                Console.WriteLine("Result of {0} {1} {2} is {3}", a, op, b, c.Addition(a, b));
                break;

            case "-":
                Console.WriteLine("Result of {0} {1} {2} is {3}", a, op, b, c.Subtraction(a, b));
                break;

            case "*":
                Console.WriteLine("Result of {0} {1} {2} is {3}", a, op, b, c.Multiplication(a, b));
                break;
            case "/":
                Console.WriteLine("Result of {0} {1} {2} is {3}", a, op, b, c.Division(a, b, out double remainder));
                Console.WriteLine("Remainder = {0}", remainder);
                break;
                
            default:
                Console.WriteLine("Invalid Operator ");
                break;
        }
    }
}