using System;


namespace JaggedArray      //DO NOT Change the namespace name
{
    public class Program    //DO NOT Change the class name
    {
        public static void Main(string[] args)    //DO NOT change the method signature
        {
	        Console.WriteLine("Enter the number of teams:");
            int numOfTeams = Convert.ToInt32(Console.ReadLine());
    
            int[][] array = new int[numOfTeams][];
            int maxValue = 500;
            int minValue = 0;
    
    
            for (int i = 0; i < array.Length; i++){
                Console.WriteLine("No.of attempts for team {0}:", i+1);
                int size = Convert.ToInt32(Console.ReadLine());
    
                array[i] = new int[size];
    
            }
    
            for (int i = 0; i < array.Length; i++){
                Console.WriteLine("Enter the score for team {0}:", i+1);
                for (int j = 0; j < array[i].Length; j++){
    
                    int marks = Convert.ToInt32(Console.ReadLine());
    
                    if (marks >= minValue && marks <= maxValue){
                        array[i][j] = marks;
                    }
                }
            }
    
            String result = GetTotalScore(array);
            Console.WriteLine(result);
        }
        
        public static String GetTotalScore(int[][] array)        //DO NOT change the method signature
        {
            String result = "";
            for (int i = 0; i < array.Length; i++){
                int sum = 0;
                for (int j = 0; j < array[i].Length; j++){
                    sum += array[i][j];
                }
                int a = i+1;
                result += "Team " + a + "Total Score is "+ sum + ". ";
            }
            return result;
        }

    }
}
