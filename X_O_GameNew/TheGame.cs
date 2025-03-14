using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;
using X_O_GameNew.Data;
using X_O_GameNew.Interface;
using X_O_GameNew.Settings;


namespace X_O_GameNew
{
    internal class TheGame
    {
        static void Main(string[] args)
        {
            LoadIntro();

            LoadMenu();
        }

        public static void LoadMenu()
        {
            Menu.DisplayMenu(MenuData.MainMenuPl, MenuTextFields.mainManu);
            do
            {
                int userChoise = ConsoleHelper.GetUserChoise();
                ValidateMenuChoice(userChoise, MenuTextFields.mainManu);
            }
            while (true);
        }
        public static void HandleUnexpectedMenuError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tWykryto nieznany błąd związany z obsługą menu.");
            Console.WriteLine("\tNastapi restart programu");
            Console.ResetColor();
            ConsoleHelper.Countinue();
            Main(new string[0]);
        }
        public static void ValidateMenuChoice(int userChoise, string typeOfMenu)
        {
            if (typeOfMenu == MenuTextFields.mainManu)
            {
                if (userChoise > 0 && userChoise < 4)
                {
                    Console.Clear();
                    LoadProgram(userChoise);
                }
            }
            else if (typeOfMenu == MenuTextFields.settingsMenu)
            {
                if (userChoise > 0 && userChoise < 3)
                {
                    Console.Clear();
                    LoadProgram(userChoise);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nBrak takiej opcji w menu.");
                Console.ResetColor();
                return;
            }
        }

        private static void LoadProgram(int userChoise)
        {
            switch (userChoise)
            {
                case 1:
                {
                    ConsoleHelper.Countinue();
                    Console.ReadLine();
                    break;
                }
                case 2:
                {
                    Options.LoadSettings();
                    break;
                }
                case 3:
                {
                    Environment.Exit(0);
                    break;
                }
                default:
                {
                    HandleUnexpectedMenuError();
                    break;
                }
            }
        }

        private static void LoadIntro()
        {
            Intro.LoadingScreen();
            Intro.GameVersion();
            Intro.GameIntro();
        }
    }
}
