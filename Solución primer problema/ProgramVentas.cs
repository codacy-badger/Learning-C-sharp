using System;

namespace app
{
    class ProgramVentas : program
    {
        private readonly static ProgramVentas _instance = new ProgramVentas(
            ModelVenta.getInstance
        );
        private string _name;
        private ModelVenta Model;

        private ProgramVentas(ModelVenta model)
        {
            Model = model;
            _name = "ventas diarias de una tienda";
        }

        public static ProgramVentas getInstance
        {
            get
            {
                return _instance;
            }
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
            add();
            questionUsuario();
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

        void questionUsuario()
        {
            Console.WriteLine("Venta agragada, ¿desea agregar otra venta o regresar al menú?");
            Console.WriteLine("presione '1' para terminar y volver al menú principal");
            Console.WriteLine("presione '2' para agregar nueva venta");
            Console.WriteLine("presione '3' para ejecutar desde cero");
            Console.WriteLine("presione '4' para salir");

            string respuesta = Console.ReadLine();

            switch(respuesta)
            {
                case "1":
                    calculateTotal();
                    break;
                case "2":
                    run();
                    break;
                case "3":
                    Model.resetVentas();
                    run();
                    break;
                case "4":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("El número ingresado es inválido");
                    questionUsuario();
                    break;
            }
        }
    }
}
