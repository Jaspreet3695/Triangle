using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleAssignment
{
    class Program
    {
        
        public static int ValidateUserInput(string SideofTriangle)
        {
            
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                
                Console.WriteLine("Please enter the {0} of your Triangle :", SideofTriangle);
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("Please enter a valid input");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Please enter an integer greater than 0");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine("The {0} of your triangle is now {1} unit(s).", SideofTriangle, number);
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            bool validSelect = false;
            string selectionString;
            //int selection;
            
            while (validSelect == false)
            {
                do
                {
                    Console.WriteLine("Welcome to Triangle Validator Application");
                    Console.WriteLine();
                    Console.WriteLine("1. Enter the Dimensions of the Triangle.");
                    Console.WriteLine("2. Exit");

                    Console.WriteLine("Please select from the options given above by entering the corresponding number.");
                    selectionString = Console.ReadLine();
                    Console.WriteLine();

                    if (selectionString != "1" && selectionString != "2")
                    {
                        Console.WriteLine("That's not a valid selection");
                    }
                    else if (selectionString == "1")
                    {
                        validSelect = true;
                        int s1;
                        int s2;
                        int s3;

                        s1 = ValidateUserInput("s1");
                        s2 = ValidateUserInput("s2");
                        s3 = ValidateUserInput("s3");

                        Console.WriteLine("Your triangle is {0}", TriangleSolver.Analyze(s1, s2, s3));
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                    else if (selectionString == "2")
                    {
                        validSelect = true;
                    }
                }while(selectionString != "2");
                
            }
        }
    }
}
