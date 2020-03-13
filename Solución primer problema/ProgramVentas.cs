using System;

namespace app
{
    class ProgramVentas : program
    {
        private string _name;
        private ModelVenta Model;

        public ProgramVentas ( ModelVenta model)
        {
            this.Model = model;
            _name = "ventas diarias de una tienda";
        }

        public string name
        {
            get => _name;
            set => _name = value;
        }


        void add()
        {
            Console.WriteLine("Ingrese la descripción de la venta:");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese el Valor unitario:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad:");
            float cantidad = float.Parse(Console.ReadLine());

            Model.add(descripcion, valor, cantidad);
        }

        public void run()
        {
            Menu Menu = Menu.Instance;
            add();
            Console.WriteLine(Model.calculateTotal());

            Console.WriteLine("¿QUIERE SEGUIR REGISTRANDO VENTAS?, ESCRIBA si PARA CONTINUAR, SINO ESCRIBA CUALQUIER TECLA...");
            string terminar = Console.ReadLine();
            terminar.ToLower();

            if (terminar == "si")
            {
                run();
            }

            Console.WriteLine("¿QUIERE VER EL MONTO FINAL?");
            string flagVerMontoFinal = Console.ReadLine();
            flagVerMontoFinal.ToLower();

            if (flagVerMontoFinal == "si")
            {
                calculateTotal();
            }

            Console.WriteLine("¿DESEA VOLVER AL MENÚ PRINCIPAL?, PRECIONE 1...");
            Console.WriteLine("¿DESEA VOLVER A EJECUTAR EL ALGORITMO DESDE CERO?, PRECIONE 2...?");
            Console.WriteLine("¿DESEA SALIR DEL PROGRAMA?, PRECIONE CUALQUIER TECLA");

            string selOpcion = Console.ReadLine();

            switch (selOpcion)
            {
                case "1":
                    Menu.menuOptions();
                    break;
                case "2":
                    Model.resetVentas();
                    run();
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }

        void calculateTotal()
        {
            Venta[] ventas = Model.getVentas();
            for(int i = 0; i <= Model.getTopeVentas(); i++)
            {
                Venta venta = ventas[i];
                if(venta != null)
                {
                    Console.WriteLine($"Descripción: {venta.getDescripcion()}");
                    Console.WriteLine($"valor: {venta.getValor()}");
                    Console.WriteLine($"cantidad: {venta.getCantidad()}");
                    Console.WriteLine($"total: {venta.getTotal()}");
                }
            }
            Console.WriteLine($"Valor total ventas: {Model.calculateTotal()}");
        }
    }
}
