using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string userName = PromptUserName();
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int userNumber = PromptUserNumber();
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        int squareNumber = SquareNumber(userNumber);
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        DisplayResult(userName, squareNumber);
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
    }
}