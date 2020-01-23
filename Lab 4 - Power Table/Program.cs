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
                Console.WriteLine("Enter an integer: ");
                int userChoice = int.Parse(Console.ReadLine());

                //Helps align the table when its printed out
                Console.WriteLine("Number Squared Cubed");
                Console.WriteLine("====== ====== ======");

                //Add For loop here. To display squared and cubed numbers.
                for (int i = 1; i <= userChoice; i++)
                {
                    Console.WriteLine($"{i} \t{SquaredNumber(i)} \t{CubedNumber(i)}");
                }

            } while (Continue()); //do while loop must include semi colon
            Console.WriteLine("Okiiieeeeee BAAAAAIIIIIIIIIIIEEEEE, thanks for playing!");
        }

        //created a seperate method for all Squared integers
        public static double SquaredNumber(double number)
        {
            return Math.Pow(number, 2);
        }

        //created a seperate method for all cubed integers.
        public static int CubedNumber(int number)
        {
            //math.pow returns a double so to cast it as an int, put (int). For a different way to handle this look at the squared method.
            return (int)Math.Pow(number, 3);
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        //Seperate Method to Ask id the user wants to continue or not.
        public static bool Continue()
        {
            //Checking if the user would like to continue...
            Console.WriteLine("Continue: y/n");
            string userContinue = Console.ReadLine().ToLower();

            
            if (userContinue == "y" || userContinue == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (userContinue == "n" || userContinue == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Number, Please try again. y/n");
                //This is an example of a recursion because it is calling the same method inside of itself. It will only stop once they hit y or yes.
                return Continue();
            }
            
        }
    }
}

