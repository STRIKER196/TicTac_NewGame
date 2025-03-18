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

        public static char GetcharByReadLine()
        {
            do
            {
                ConsoleKeyInfo inputValue = Console.ReadKey();
                if (!char.IsDigit(inputValue.KeyChar))
                {
                    return inputValue.KeyChar;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWartość nie może być cyfrą.");
                Console.ResetColor();
            } while (true);
        }
    }
}
