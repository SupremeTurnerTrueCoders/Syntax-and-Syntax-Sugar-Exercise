using System.ComponentModel.Design;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer =  4; 
            var response = (answer < 9) ? $"{answer} is less than Nine" : $"{answer} Greater than or equal to Nine";
            Console.WriteLine(response);
        }  
       
    }
}



                  