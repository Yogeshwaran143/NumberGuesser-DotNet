using System;

namespace NumberGuess {
    class Program {

        static void GetAppInfo() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Number Guessing Game version 1.0.0 created by Yogeshwaran143");
            Console.ResetColor();
        }

        static void GetUserInfo() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0} Lets play a game...", userName);
            Console.ResetColor();
        }

        static void ErrorMessage(ConsoleColor color,string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Main(string[] args) {
            GetAppInfo();
            GetUserInfo();
            
            int guessesTaken = 0;
            Random random = new Random();
            int correctNumber = random.Next(1,10);

            for(int i = 0;i < 5;i++ ){
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter the number guessed : ");
                string inputNumber = Console.ReadLine();

                if(!int.TryParse(inputNumber, out guessesTaken)) {
                    ErrorMessage(ConsoleColor.Red, "Please Enter a number");
                    continue;
                }

                int guess = Int32.Parse(inputNumber);

                if(guess != correctNumber) {
                    if(guess > correctNumber) {
                        ErrorMessage(ConsoleColor.Red, "Your Guess is HIGH...");
                        continue;
                    } else {
                        ErrorMessage(ConsoleColor.Red, "Your Guess is LOW...");
                        continue;
                    }
                } else if (guess == correctNumber) {
                    ErrorMessage(ConsoleColor.Green, "Your are CORRECT!!!!...");
                    break;
                }
            }
        }
    }
}
