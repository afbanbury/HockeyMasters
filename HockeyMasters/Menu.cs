using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HockeyMasters
{
    class Menu
    {
        enum MainMenuOptions
        {
            PlayGame,
            Exit = 9
        }

        public static int StartMenu()
        {
            WelcomeMessage();
            MainMenu();

            return 0;
        }

        private static short ObtainMenuSelection()
        {
            var userInput = Console.ReadLine();
            try
            {
                return Int16.Parse(userInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                return 0;
            }
            
        }

        private static void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("Welcome to AH Hockey Masters");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private static void MainMenu()
        {
            DisplayMainMenu();
            var option = ObtainMenuSelection();

            var selection = (MainMenuOptions) option;

            switch (selection)
            {
                case MainMenuOptions.PlayGame:
                    {
                        PlayGame();
                        MainMenu();
                        break;
                    }
                case MainMenuOptions.Exit:
                    {
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(1000);
                        break;
                    }
                default:
                    {
                        MainMenu();
                        break;
                    }
            }
        }

        private static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("0: Play Game");
            Console.WriteLine("9: Exit");
            Console.WriteLine();
            Console.Write("Option:");
        }

        private static void PlayGame()
        {
            var myGame = new Game("Westbury", "Firebrands");
            Console.Clear();
            Console.WriteLine("Play Game");
            Console.WriteLine("=========");
            Console.WriteLine(myGame.GameResult());
            Thread.Sleep(1000);

            Console.WriteLine("Press enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}
