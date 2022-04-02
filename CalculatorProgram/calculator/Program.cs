using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");
            
            Console.WriteLine("Enter your first number: ");
            num1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation would you like to do?");
            System.Console.WriteLine("Enter the keyword: a = addition, s = subtraction, m = multiplication, d = division");
            
            answer = Console.ReadLine();

            if (answer =="a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else 
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is: " + result);
            System.Console.WriteLine("\nThank you for using the calculator program! ;D");
            
            Console.ReadKey(); //stop and wait user press a key to continue
        }
    }
}