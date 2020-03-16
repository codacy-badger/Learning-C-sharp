using System;
using System.Collections.Generic;

namespace app
{
    class ProgramVentas : programInterface
    {
        private LogicVenta LogicVenta;
        private LogicCompraDelCliente LogicCompraDelCliente;

        public ProgramVentas ( LogicVenta logicVenta, LogicCompraDelCliente logicCompraDelCliente)
        {
            this.LogicVenta = logicVenta;
            this.LogicCompraDelCliente = logicCompraDelCliente;
        }

        private void add()
        {
            Console.WriteLine("Ingrese el Valor unitario:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad:");
            float cantidad = float.Parse(Console.ReadLine());

            this.LogicVenta.add(valor, cantidad);
        }

        public void run()
        {
            Console.Clear();

            add();

            Console.Clear();

            Utilities.escribeEnColor(this.LogicVenta.getTotal().ToString(), "Azul");
            preguntaTerminarCompraDelCliente();

            Console.Clear();

            preguntaSeguirRegistrandoVentas();

            imprimeMontoClientes();
            preguntaQueHacer();
        }

        private void preguntaTerminarCompraDelCliente()
        {
            Utilities.escribeEnColor("¿Desea terminar la compra del cliente?,s para afirmar, sino n.", "");
            string flagCliente = Console.ReadLine().ToLower();

            switch (flagCliente)
            {
                case "s":
                    this.LogicCompraDelCliente.add(
                        this.LogicVenta.getTotal()
                    );
                    LogicVenta.reset();
                    break;
                case "n":
                    run();
                    break;
                default:
                    Utilities.userError();
                    preguntaTerminarCompraDelCliente();
                    break;
            }
        }
        
        private void preguntaSeguirRegistrandoVentas()
        {
            Utilities.escribeEnColor("¿Quiere seguir registrando ventas?,s para continuar, sino n.", "");
            string flagRegistrarMasVentas = Console.ReadLine().ToLower();

            switch(flagRegistrarMasVentas)
            {
                case "s":
                    run();
                    break;
                case "n":
                    noSeguirResgitrandoVentas();
                    break;
                default:
                    Utilities.userError();
                    preguntaSeguirRegistrandoVentas();
                    break;
            }
        }

        private void noSeguirResgitrandoVentas()
        {
            Utilities.escribeEnColor("¿Quiere ver el monto final?,s para aceptar, sino n.", "");
            string flagVerMontoFinal = Console.ReadLine().ToLower();

            switch(flagVerMontoFinal)
            {
                case "s":
                    Utilities.escribeEnColor($"Valor total ventas: {LogicCompraDelCliente.calculateTotal()}", "Rojo");
                    break;
                case "n":
                    break;
                default:
                    Utilities.userError();
                    noSeguirResgitrandoVentas();
                    break;
            }
        }

        private void preguntaQueHacer()
        {
            Utilities.escribeEnColor("¿Desea volver al menú principal?, PRESIONE 1", "Rojo");
            Utilities.escribeEnColor("¿Desea volver a ejecutar el algoritmo desde cero?, PRESIONE 2", "Rojo");

            string selOpcion = Console.ReadLine();

            switch (selOpcion)
            {
                case "1":
                    Program.Main();
                    break;
                case "2":
                    this.LogicVenta.reset();
                    this.LogicCompraDelCliente.reset();
                    run();
                    break;
                default:
                    Utilities.userError();
                    preguntaQueHacer();
                    break;
            }
        }

        private void imprimeMontoClientes()
        {
            List<CompraCliente> compraClientesList = this.LogicCompraDelCliente.getCompras();
            int cliente = 0;

            foreach (CompraCliente element in compraClientesList)
            {
                cliente += 1;
                Console.WriteLine($"La compra total del cliente {cliente} es {element.MontoTotal}");
            }

            Console.WriteLine($"En número de clientes atendidos es {compraClientesList.Count}.");
        }
    }
}
