using System;
using System.IO;

class Person{
    private string firstName;
    private string lastName;
    DateTime dob;
    
    public Person(){}

    public Person(string firstName, string lastName, DateTime dob){
        this.firstName = firstName;
        this.lastName = lastName;
        this.dob = dob;
    }


    public string FirstName { 
        get { 
            return this.firstName; 
        }  
        set { 
            this.firstName = value; 
        } 
    }
    public string LastName { 
        get{
            return this.lastName; 
        }
        set { 
            this.lastName = value; 
        }
    }
    public DateTime Dob { 
        get{
            return this.dob;
        }
        set { 
            this.dob = value; 
        }
    }

    public string Adult{
        get {
            int age = 0;  
            age = DateTime.Now.Subtract(dob).Days;  
            age = age / 365;  
            
            if (age >= 18){
                return "Adult";
            }
            else{
                return "Child";
            }
        }
    }

    public void DisplayDetails(){
        Console.WriteLine("First Name : {0}", this.FirstName);
        Console.WriteLine("Last Name : {0}", this.LastName);
        Console.WriteLine("Age is : {0}", this.GetAge(this.dob));
        Console.WriteLine(this.Adult);
    }

    public int GetAge(DateTime dob){
        int age = 0;  
        age = DateTime.Now.Subtract(dob).Days;  
        age = age / 365; 
        return age;
    }
}

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter first name");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter last name");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter rdate of birth in yyyy/mm/dd/ format");
        DateTime dob = Convert.ToDateTime(Console.ReadLine());
        Person p = new Person(firstName, lastName, dob);
        p.DisplayDetails();
    }
}