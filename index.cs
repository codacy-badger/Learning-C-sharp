using System;

namespace app
{
    static class Program
    {
        public static void Main()
        {

            const Boolean run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Utilities.escribeEnColor("*********************   MENÚ PRINCIPAL   *********************", "Rojo");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("-- 1. Para ventas diarias de una tienda  ");
                Console.WriteLine("-- console -color para configurar el color de la consola");
                Console.WriteLine("-- 0. Para salir del programa");
                Console.WriteLine("--------------------------------------------------------------");
                Utilities.escribeEnColor("**************************************************************", "Rojo");
                Console.WriteLine("--------------------------------------------------------------");

                string program = Console.ReadLine();

                switch (program)
                {
                    case "console -color":
                        Utilities.cambiarColorConsola();
                        break;
                    case "0":
                        Environment.Exit(1);
                        break;
                    case "1":
                        ProgramVentas ProgramVentas = new ProgramVentas(new LogicVenta(), new LogicCompraDelCliente());
                        ProgramVentas.run();
                        break;
                    default:
                        Utilities.userError();
                        break;
                }
            }
        }
    }
}

