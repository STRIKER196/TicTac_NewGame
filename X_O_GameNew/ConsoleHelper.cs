using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_GameNew
{
    internal class ConsoleHelper
    {
        public static void Countinue()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("### Wciśnij dowolony przycisk, aby kontynuuwać. ###");
            Console.ResetColor();
        }

        public static int GetIntByReadLine() 
        {
            do 
            {
                ConsoleKeyInfo inputValue = Console.ReadKey();

                if (int.TryParse(inputValue.KeyChar.ToString(), out int keyValue))
                {
                    return keyValue;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWprowadź odpowiednią wartość.");
                Console.ResetColor();
            }while (true);

        }
        public static int GetUserChoise()
        {
            Console.Write("\nWybrano opcje: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int userChoice = GetIntByReadLine();
            Console.ResetColor();
            Console.WriteLine("");

            return userChoice;
        }

    }
}
