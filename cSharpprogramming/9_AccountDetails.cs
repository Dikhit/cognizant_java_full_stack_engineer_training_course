using System;

public class Account{

    private int id;
    private string accountType;
    private double balance;


    public Account(){

    }

    public Account(int a, string b, double c){
        id = a;
        accountType = b;
        this.balance = c;
    }

    public int Id { 
        get {return id; } 
        set {id = value; } 
    }

    public string AccountType {
        get {return accountType; } 
        set {accountType = value; } 
    }

    public double Balance {
        get {return balance; }
        set {balance = value; }
    }

    public bool WithDraw(double amount){
        if (balance >= amount){
            balance -= amount;
            return true;
        }
        return false;
    }

    public String GetDetails(){
        string details = "Account Id:" +  id + "\ncount Type: " + accountType + "\nBalance: " + balance;
        return details;
    }
}

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter account id");
        int id = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter account type");
        string accountType = Console.ReadLine();

        Console.WriteLine("Enter account balance");
        double balance = Convert.ToDouble(Console.ReadLine());

        Account a = new Account(id, accountType, balance);
        string details = a.GetDetails();
        Console.WriteLine(details);

        Console.WriteLine("Enter amount to withdraw");
        double amount = Convert.ToDouble(Console.ReadLine());

        if(a.WithDraw(amount)){
            Console.WriteLine("New Balance : {0}", a.Balance);
        }

    }
}