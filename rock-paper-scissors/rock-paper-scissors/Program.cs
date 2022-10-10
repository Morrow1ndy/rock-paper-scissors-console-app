using System;

namespace rock_paper_scissors
{
    class Program
    {
        int AskAndGetUserInput()
        {
            while (1 == 1)
            {
                Console.WriteLine("Please Input Your Choice(1-Rock, 2-Paper, 3-Scissors): ");
                string userChoice = Console.ReadLine();
                if (userChoice == "1" || userChoice == "2" || userChoice == "3")
                {
                    return Int32.Parse(userChoice);
                }
                else
                {
                    Console.WriteLine("Invalid Input! Try Again!");
                }
            }
        }

        int GenerateComputerChoice()
        {
            Random random = new Random();
            int computerChoice = random.Next(1, 4);
            return computerChoice;
        }

        string Judge(int userInput, int computerChoice)
        {
            switch (userInput - computerChoice)
            {
                case 0:
                    return "Draw";

                case 1:
                    return "You Win";

                case -2:
                    return "You Win";

                default:
                    return "You Lose";
            }
        }

        string GetUserResponseForMoreRound()
        {
            Console.WriteLine("Do You Want To Play More? Please Response 'Y' if you want: ");
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        void RunGame()
        {
            while (1==1)
            {
                int userChoice = AskAndGetUserInput();
                int computerChoice = GenerateComputerChoice();
            
                string result = Judge(userChoice, computerChoice);
                Console.WriteLine(result);
                string userChoiceOfMoreRound = GetUserResponseForMoreRound();
                if (userChoiceOfMoreRound != "Y")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Game!");
            Program program = new Program();
            program.RunGame();
        }
    }
}
