using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBookCode      //Do not change the namespace name
{
    public class Program{

        public static String getSubstring(String text, int start, int last){
            String result = "";
            for(int i = start; i < last; i++){
                result += text[i];
            }
            return result;
        }
        public static void Main(string[] args){
            Console.WriteLine("Enter the book code of length 18");
            String bookDetails = Console.ReadLine();
    
            if (bookDetails.Length != 18){
                Console.WriteLine("Invalid Book Code");
            }
            else{
                int deptCode = Convert.ToInt32(getSubstring(bookDetails, 0, 3));
                int publicationYear = Convert.ToInt32(getSubstring(bookDetails, 3, 7));
                int numOfPages = Convert.ToInt32(getSubstring(bookDetails, 7, 12));
                string bookId = getSubstring(bookDetails, 12, 18);
    
    
                if(deptCode == 101 || deptCode == 102 || deptCode == 103){
                    Console.WriteLine("Department Code : {0}", deptCode);
                }
                else{
                    Console.WriteLine("Invalid Department Code");
                }
    
                if (publicationYear >= 1990 && publicationYear <= 2020){
                    Console.WriteLine("Year of Publication : {0}", publicationYear);
                }   
                else{
                    Console.WriteLine("Invalid Year");
                }
    
                if (numOfPages >= 1 && numOfPages <= 99999){
                    Console.WriteLine("Number of Pages : {0}", numOfPages);   
                }
                else{
                    Console.WriteLine(" Invalid Page Numbers");
                }
    
                char letter = bookId[0];
                if (Char.IsLetter(letter)){
                    Console.WriteLine("Book ID : {0}", bookId);
                }
                else{
                    Console.WriteLine("Invalid Book ID");
                }
            }
    
        }
    }
}