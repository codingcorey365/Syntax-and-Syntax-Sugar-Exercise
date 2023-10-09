using System.Threading.Channels;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {

            //Given the following code, change the code to implement:

            //  inferred typing
            //  string interpolation
            //  and the ternary operator
            //  int answer = 4;
            //  string response;
            //
            // if (answer< 9) 
            //  {
            //   response = answer + " is less than nine";
            //  }
            //
            // else
            //  {
            //   response = answer + " is greater than or equal to nine";
            //  }

static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var answer = 4;

            string ternary = "";
            //var ternary = (answer < 9 ) ? $"less than nine" : $"greater than 9";

            Console.WriteLine( ternary = (answer < 9) ? "Less than nine" : "Greater than nine");
        }
    }
}
