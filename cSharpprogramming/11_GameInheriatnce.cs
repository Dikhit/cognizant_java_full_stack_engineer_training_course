using System;

public class Game{
    public String Name {get; set;}
    public int MaxNumPlayers {get; set;}

    public Game(){}

    public override String ToString() { 
        return "Maximum number of players for " + Name + " is " + MaxNumPlayers;
    }
}

public class GameWithTimeLimit: Game{
    public int TimeLimit {get; set;}

    public GameWithTimeLimit(){}

    public override String ToString() { 
        return "Time Limit for " + Name + " is " + TimeLimit + " minutes";                                    

    }
}

public class Program{
    public static void Main(String[] args){
        Console.WriteLine("Enter a game");
        String gameName = Console.ReadLine();

        Console.WriteLine("Enter the maximum number of players");
        int numOfPlayers = Convert.ToInt32(Console.ReadLine());

        Game g = new Game();
        g.Name = gameName;
        g.MaxNumPlayers = numOfPlayers;
        Console.WriteLine(g.ToString());

        Console.WriteLine("Enter a game that has time limit");
        String gameWithTimeLimit = Console.ReadLine();

        Console.WriteLine("Enter the maximum number of players");
        int numOfPlayersInTimeLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the time limit in minutes");
        int timeLimit = Convert.ToInt32(Console.ReadLine());

        Game h = new Game();
        h.Name = gameWithTimeLimit;
        h.MaxNumPlayers = numOfPlayersInTimeLimit;
        Console.WriteLine(h.ToString());

        GameWithTimeLimit t = new GameWithTimeLimit();
        t.TimeLimit = timeLimit;
        Console.WriteLine(t.ToString());




    }
}