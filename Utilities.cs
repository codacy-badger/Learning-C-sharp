using System;
using System.Threading;

namespace app
{
    static class Utilities
    {
        public static void escribeEnColor(string text, string color)
        {
            switch (color)
            {
                case "Rojo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Azul":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void cambiarColorConsola()
        {
            string color = Console.ReadLine().ToLower();
            switch (color)
            {
                case "gris":
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case "reiniciar":
                    Console.BackgroundColor = ConsoleColor.Black;
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
            escribeEnColor("¡ERROR la opción que ha selecionado no existe!", "Rojo");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
