using System;

namespace Lab_4___Power_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Learn Your Squares and Cubes!\n");

                //Ask the User to Enter a Valid Integer
                GetUserInput("Please enter an integer: ");
                double userNum = double.Parse(Console.ReadLine());

                //Words spaced out to help make it appear more like a table when it is printed to the console.
                Console.WriteLine("\nNumber    \tSquared    \tCubed");
                Console.WriteLine("_________________________________________");


                //Add For loop here. To display squared and cubed numbers.
                for (int i = 1; i <= userNum; i++)
                {
                    Console.WriteLine($"{i}       \t{SquaredNumber(i)}        \t{CubedNumber(i)}\t");
                    Console.WriteLine("_________________________________________");
                }

                

            } while (Continue()); //do-while loop normally doesnt end with a (;) but in this case it must include the semi colon because it is a method.
            
        }
        
        //Created a seperate method for all Squared integers
        public static double SquaredNumber(double number)
        {
            //w
            double squaredNum = Math.Pow(number, 2);
            return squaredNum;
        }

        //Created a seperate method for all cubed integers.
        public static double CubedNumber(double number)
        {
            //math.pow is specifically used to square numbers.
            //note to myself: math.pow returns a double so to cast it as an int, put (int). For a different way to handle this look at the squared method.
            return Math.Pow(number, 3);
        }
        public static string GetUserInput(string input)
        {
            Console.WriteLine(input);
            return input;

        }

        //Seperate Method to ask the user wants to continue or not.
        public static bool Continue()
        {
            //Checking if the user would like to continue...
            Console.WriteLine("\nContinue: y/n");
            string userContinue = Console.ReadLine().ToLower();

            
            if (userContinue == "y" || userContinue == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (userContinue == "n" || userContinue == "no")
            {
                Console.WriteLine("Okiiieeeeee BAAAAAIIIIIIIIIIIEEEEE, thanks for playing!");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Number, Please try again. y/n");
                //This is an example of a RECURSION because it is calling the same method inside of itself. It will only stop once they hit y or yes.
                return Continue();
            }
            
        }
    }
}

