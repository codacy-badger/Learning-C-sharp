using System;

namespace app
{
    internal class Menu : MenuInterface
    {
        private ProgramVentas ProgramVentas;
        private readonly static Menu _instance = new Menu();

        private Menu()
        {
            ProgramVentas = new ProgramVentas(new ModelVenta());
        }

        public static Menu Instance
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
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }
    }
}