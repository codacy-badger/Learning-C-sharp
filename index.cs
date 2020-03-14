using System;

namespace app
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            const Boolean run = true;
            do
            {
                Utlis.writeInColor("Menú principal", "Red");
                Console.WriteLine("console -color para configurar el color de la consola");
                Console.WriteLine("1 para ventas diarias de una tienda");
                string program = Console.ReadLine();

                switch (program)
                {
                    case "console -color":
                        Utlis.changeColorConsola();
                        break;
                    case "0":
                        Environment.Exit(1);
                        break;
                    case "1":
                        ProgramVentas ProgramVentas = new ProgramVentas(new ModelVenta());
                        ProgramVentas.run();
                        Console.ReadKey();
                        break;
                    default:
                        Utlis.userError();
                        break;
                }
            } while (run);
        }
    }
}

