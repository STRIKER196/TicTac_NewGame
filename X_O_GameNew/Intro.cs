using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_O_GameNew
{
    internal class Intro
    {
        public static void GameIntro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+---------------------------------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|\tKółko i krzyżyk – gra strategiczna rozgrywana przez dwóch graczy, najczęściej na kartce w kratkę.                                           |\n" +
                              "|\tGracze obejmują pola na przemian dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi.   |\n" +
                              "|\tPole może być objęte przez jednego gracza i nie zmienia swego właściciela przez cały przebieg gry.                                          |\n" +
                              "|\tW najbardziej popularnej w Polsce wersji gra odbywa się na polu o wymiarach 3x3.                                                            |");
            Console.WriteLine("+---------------------------------------------------------------------------------------------------------------------------------------------------+\n");
            Console.ResetColor();
        }
        public static void GameVersion()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("+-------------------+");
            Console.WriteLine("| X  O  Game   v0.1 |");
            Console.WriteLine("+-------------------+");
            Console.ResetColor();
        }
        public static void LoadingScreen()
        {
            Console.WriteLine("\n\n\tGra: X & O WARS\n");
            Console.WriteLine("\tWciśnij dowolny przycisk, aby załadować menu");
            Console.ReadKey();
            Console.ForegroundColor= ConsoleColor.DarkMagenta;

            string[] animationFrames = { "|", "/", "-", "\\", "|", "/", "-", "\\", "Ładowanie zakończone"};

            for (int i = 0; i < 9; i++)
            {
                Console.Clear();
                Console.Write("Ładowanie: [ ");
                Console.Write(animationFrames[i]);
                Console.Write(" ]");
                Thread.Sleep(650);
            }
            Console.Clear();
        }
    }
}

