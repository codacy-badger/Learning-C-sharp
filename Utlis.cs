using System;
using System.Threading;

namespace app
{
    internal class Utlis
    {
        public static void writeInColor(string text, string color)
        {
            switch (color)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void changeColorConsola()
        {
            string color = Console.ReadLine().ToLower();
            switch (color)
            {
                case "black":
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case "restart":
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                default:
                    userError();
                    break;
            }
            Console.Clear();
        }

        public static void userError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            writeInColor("¡ERROR la opción que ha selecionado no existe!", "Red");
            Thread.Sleep(1000);
        }
    }
}
