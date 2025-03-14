using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;
using X_O_GameNew.Data;
using X_O_GameNew.Interface;

namespace X_O_GameNew.Settings
{
    internal class Options
    {
        public static void LoadSettings()
        {
            Menu.DisplayMenu(SettingsData.OptionMenuPl, MenuTextFields.settingsMenu);

            int userChoise = ConsoleHelper.GetUserChoise();

            TheGame.ValidateMenuChoice(userChoise, MenuTextFields.settingsMenu);

            LoadSettingProgram(userChoise);
        }

        private static void LoadCustomPlayerMarker()
        {
            Console.Clear();
            Menu.DisplayMenu(SettingsData.CustomChangeMenuPL, MenuTextFields.setMarkerForPlayer);



        }

        private static void LoadCustomPlayerName()
        {
            Console.Clear();
            Menu.DisplayMenu(SettingsData.CustomChangeMenuPL, MenuTextFields.setNameForPlayer);



        }

        private static void LoadSettingProgram(int userCHoise)
        {
            switch (userCHoise)
            {
                case 1:
                    LoadCustomPlayerMarker();
                    break;
                case 2:
                    LoadCustomPlayerName();
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
