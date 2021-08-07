using System;


public interface IOpenable{
    String OpenSesame();
}

class TreasureBox: IOpenable{
    public String OpenSesame(){
        return "Congratulations , Here is your lucky win";
    }
}

class Parachute: IOpenable{
    public String OpenSesame(){
        return "Have a thrilling experience flying in air";
    }
}

class Project{
    public static void Main(String[] args){
        Console.WriteLine("Enter the letter found in the paper");
        string ans = Console.ReadLine();

        if (ans == "T"){
            TreasureBox t = new TreasureBox();
            Console.WriteLine(t.OpenSesame());
        }
        else if (ans == "P"){
            Parachute p = new Parachute();
            Console.WriteLine(p.OpenSesame());
        }
    }
}   