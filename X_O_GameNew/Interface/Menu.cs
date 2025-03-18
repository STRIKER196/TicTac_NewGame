using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_O_GameNew.Consts;

namespace X_O_GameNew.Interface
{
    internal class Menu
    {
        public static void PrintMenuWithProporties(List<Players.Players.Player> playerItem, string typeOfMenu)
        {
            int idWidth = Math.Max(2, playerItem.Max(x => x.PlayerId.ToString().Length));
            int nameWidth = Math.Max(12, playerItem.Max(x => x.PlayerNick.Length));
            int markerWidth = Math.Max(5, playerItem.Max(x => x.PlayerMarker.Length));

            string subTitleText = $"| {"ID".PadRight(idWidth)} | {"Nazwa gracza".PadRight(nameWidth)} | {"Znak gracza".PadRight(markerWidth)}  ";
            int subTitleLenght = subTitleText.Length;
            int titleWidth = Math.Max(subTitleLenght, typeOfMenu.Length);

            string border = "+" + new string('-', titleWidth) + "+";

            string titleBlankSpace = new string(' ', titleWidth - typeOfMenu.Length - 2);
            string subtitleBlankSpace = new string(' ', titleWidth - subTitleLenght);
            string propertiesBlankSpace = new string(' ', titleWidth - (idWidth + nameWidth + 5) - 7);

            Console.WriteLine(border);
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(typeOfMenu);
            Console.ResetColor();
            Console.Write(titleBlankSpace);
            Console.WriteLine(" |");
            Console.WriteLine(border);

            PrintSubTitle(idWidth, nameWidth, markerWidth);

            Console.Write(subtitleBlankSpace);
            Console.WriteLine(" |");
            Console.WriteLine(border);

            foreach (var item in playerItem)
            {
                PrintListProporties(idWidth, nameWidth, markerWidth, item);
                Console.Write(propertiesBlankSpace);
                Console.Write("|\n");
            }

            Console.WriteLine(border);

            static void PrintSubTitle(int idWidth, int nameWidth, int markTitleLenght)
            {
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{"Id".PadRight(idWidth)}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{"Nazwa gracza".PadRight(nameWidth)}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{"Znak gracza  ".PadRight(markTitleLenght)}");
                Console.ResetColor();
            }

            static void PrintListProporties(int idWidth, int nameWidth, int markTitleLenght, Players.Players.Player item)
            {
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{item.PlayerId.ToString().PadRight(idWidth)}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{item.PlayerNick.PadRight(nameWidth)}");
                Console.ResetColor();
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{item.PlayerMarker.PadRight(markTitleLenght)}");
                Console.ResetColor();
            }
        }


        public static void PrintMenu(MenuFields.Menu menu, string typeOfMenu)
        {
            List<string> menuOptions = new List<string> {menu.OptionOne, menu.OptionTwo, menu.OptionThree, menu.OptionFour }.Where(listItem => !string.IsNullOrEmpty(listItem)).ToList();

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
