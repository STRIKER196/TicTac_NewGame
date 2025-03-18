using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;
using X_O_GameNew.Data;
using X_O_GameNew.Interface;
using X_O_GameNew.Players;

namespace X_O_GameNew.Settings
{
    internal class Options
    {
        public static void LoadSettings()
        {
            Menu.PrintMenu(SettingsData.OptionMenuPl, MenuTextFields.settingsMenu);

            int userChoise = ConsoleHelper.GetIntByReadLine();

            LoadSettingProgram(userChoise);
        }

        private static void LoadCustomPlayerMarker()
        {
            Console.Clear();
            Menu.PrintMenu(SettingsData.CustomChangeMenuPL, MenuTextFields.setMarkerForPlayer);
            int editedPlayer = ConsoleHelper.GetIntByReadLine();
            Console.Write("\nPodaj kształ znacznika jaki będzie wyświetlany dla Gracza.\nNowy znacznik:");
            char newMarker = ConsoleHelper.GetcharByReadLine();
            
            Console.ReadKey();
        }

        private static void LoadCustomPlayerName()
        {
            Console.Clear();
            Menu.PrintMenu(SettingsData.CustomChangeMenuPL, MenuTextFields.setNameForPlayer);
            int userChoise = ConsoleHelper.GetIntByReadLine();


            Console.ReadKey ();
        }

        private static void LoadSettingProgram(int userCHoise)
        {
            switch (userCHoise)
            {
                case 1:
                    LoadCustomPlayerName();
                    break;
                case 2:
                    LoadCustomPlayerMarker();
                    break;
                case 3:
                    TheGame.LoadMenu();
                    break;
                default:
                    TheGame.HandleUnexpectedMenuError();
                    break;
            }
        }
    }
}
