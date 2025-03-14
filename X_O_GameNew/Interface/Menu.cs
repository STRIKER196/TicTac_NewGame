using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_GameNew.Interface
{
    internal class Menu
    {
        public static void DisplayMenu(MenuFields.Menu menu, string typeOfMenu)
        {
            List<string> menuOptions = new List<string> { menu.OptionOne, menu.OptionTwo, menu.OptionThree, menu.OptionFour }.Where(listItem => !string.IsNullOrEmpty(listItem)).ToList();

            menuOptions = menuOptions.Select(listItem => $"\t{listItem}").ToList();
            int maxItemLength = menuOptions.Max(listItem => listItem.Length) + 8;
            int typeofMenuLenght = typeOfMenu.Length;
            string border = "+" + new string('-', maxItemLength + 11) + "+";
            string menuNameLabel = "\t" + typeOfMenu + new string(' ', maxItemLength - typeofMenuLenght + 4);

            Console.Write($"{border}\n|");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(menuNameLabel);
            Console.ResetColor();
            Console.WriteLine($"|\n{border}");
            foreach (var option in menuOptions)
            {
                Console.WriteLine($"|{option.PadRight(maxItemLength)}|");
            }
            Console.Write(border);
        }
    }
}
