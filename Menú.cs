using System;

namespace app
{
    internal class Menu
    {
        private readonly static Menu _instance = new Menu(
            ProgramVentas.getInstance
        );
        private ProgramVentas ProgramVentas;
        private Menu(ProgramVentas programVentas) {
            ProgramVentas = programVentas;
        }

        public static Menu getInstance
        {
            get
            {
                return _instance;
            }
        }

        public void menuOptions()
        {
            Console.WriteLine("Ingrese el número del programa que desea ejecutar...");
            Console.WriteLine($"1 para {ProgramVentas.name}.");
            string program = Console.ReadLine();
            
            switch (program)
            {
                case "1":
                    ProgramVentas.run();
                    menuOptions();
                    break;
                default:
                    Console.WriteLine("El valor ingresado no es válido");
                    break;
            }
        }
    }
}