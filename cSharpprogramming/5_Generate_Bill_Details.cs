using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
            int pizzaPrice = 200;
            int puffsPrice = 40;
            int pepsiPrice = 120;
            
            Console.WriteLine("Enter the number of pizzas bought : ");
            int numOfPizza = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the number of puffs bought : ");
            int numOfPuffs = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the number of pepsi bought : ");
            int numOfPepsi = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Bill Details \n");
            
            Console.WriteLine("Cost of Pizzas : {0}", pizzaPrice*numOfPizza);
            Console.WriteLine("Cost of Puffs : {0}", puffsPrice*numOfPuffs);
            Console.WriteLine("Cost of Pepsis : {0}", pepsiPrice*numOfPepsi);
            
            double gst = (pizzaPrice*numOfPizza * 0.12) + (puffsPrice*numOfPuffs * 0.12) + (pepsiPrice*numOfPepsi * 0.12);
            double cess = (pizzaPrice*numOfPizza * 0.05) + (puffsPrice*numOfPuffs * 0.05) + (pepsiPrice*numOfPepsi * 0.05);
            int totalPrice = (pizzaPrice*numOfPizza) + (puffsPrice*numOfPuffs) + (pepsiPrice*numOfPepsi);
            
            Console.WriteLine("GST 12% : {0}", gst);
            Console.WriteLine("CESS 5% : {0}", cess);
            
            Console.WriteLine("Total Price : {0}", totalPrice);
            
            
        }
    }
}
