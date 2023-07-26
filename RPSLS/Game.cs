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

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
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

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
