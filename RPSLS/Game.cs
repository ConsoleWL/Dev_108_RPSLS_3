using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        int numberOfHumanPlayers;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");

            Console.WriteLine("Rock crushes Schissors");
            Console.WriteLine("Rock crushes Lizard");

            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");

            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Scissors cuts Paper");

            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");

            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Spock smashes Scissors");

            Console.WriteLine("\nGame will be best out of 3!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nChoose number of players 1 or 2:");

            while (true)
            {
                string temp = Console.ReadLine();

                if (temp == "1")
                {
                    return 1;
                }
                if (temp == "2")
                {
                    return 2;
                }
                else
                {
                    Console.WriteLine("\nWrong input. Choose between 1 or 2:");
                }
            }
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("Nikita");
                playerTwo = new ComputerPlayer("Computer");
            }
            if (numberOfHumanPlayers == 2)
            {
                playerOne = new HumanPlayer("Nikita");
                playerTwo = new HumanPlayer("Michael");
            }
        }

        public void CompareGestures()
        {
            while(playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                Console.WriteLine();

                if (playerOne.chosenGesture.WillWLT(playerTwo.chosenGesture) == 1)
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                if (playerOne.chosenGesture.WillWLT(playerTwo.chosenGesture) == -1)
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                Console.WriteLine("________________________________________________");
            }
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"\nCongratulation {playerOne.name} is a winner!");
            }
            else
            {
                Console.WriteLine($"\nCongratulation {playerTwo.name} is a winner!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            CompareGestures();
            DisplayGameWinner();
        }
    }
}
