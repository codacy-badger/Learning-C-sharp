using System;
using System.Collections.Generic;

namespace app
{
    class ProgramVentas : program
    {
        private ModelVenta Model;

        public ProgramVentas ( ModelVenta model)
        {
            this.Model = model;
        }

        private void add()
        {
            Console.WriteLine("Ingrese el Valor unitario:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad:");
            float cantidad = float.Parse(Console.ReadLine());

            Model.addVenta(valor, cantidad);
        }

        public void run()
        {
            add();
            Utlis.writeInColor(Model.getTotalVentas().ToString(), "Blue");
            preguntaDarPorServidoAlCliente();
            preguntaSeguirRegistrandoVentas();
            printClientes();
        }

        private void preguntaDarPorServidoAlCliente()
        {
            Utlis.writeInColor("¿Desea dar por servido el cliente?,s para afirmar, sino n.", "");
            string flagCliente = Console.ReadLine().ToLower();

            if (flagCliente == "s") {
                Model.addCliente(Model.getTotalVentas());
                Model.resetVentas();
            }
            else if (flagCliente == "n"){ 
                run(); 
            } else {
                Utlis.userError();
                preguntaDarPorServidoAlCliente();
            }
        }
        
        private void preguntaSeguirRegistrandoVentas()
        {
            Utlis.writeInColor("¿Quiere seguir registrando ventas?,s para continuar, sino n.", "");
            string flagRegistrarMasVentas = Console.ReadLine().ToLower();

            if (flagRegistrarMasVentas == "s") {
                run();

            } else if (flagRegistrarMasVentas == "n") {
                noSeguirResgitrandoVentas();

            } else {
                Utlis.userError();
                preguntaSeguirRegistrandoVentas();
            }
        }

        private void noSeguirResgitrandoVentas()
        {
            Utlis.writeInColor("¿Quiere ver el monto final?,s para aceptar, sino n.", "");
            string flagVerMontoFinal = Console.ReadLine().ToLower();

            if (flagVerMontoFinal == "s")
            {
                Utlis.writeInColor($"Valor total ventas: {Model.calculateTotal()}", "Red");
            } else if (flagVerMontoFinal == "n") {
                noMostrarMontoFinal();
            } else {
                Utlis.userError();
                noSeguirResgitrandoVentas();
            }
        }

        private void noMostrarMontoFinal()
        {
            Console.WriteLine("¿Desea volver al menú principal?, PRESIONE 1");
            Console.WriteLine("¿Desea volver a ejecutar el algoritmo desde cero?, PRESIONE 2");
            Console.WriteLine("¿Desea salir del programa?, PRESIONE 0");

            string selOpcion = Console.ReadLine();

            switch (selOpcion)
            {
                case "1":
                    return;
                case "2":
                    Model.resetVentas();
                    Model.resetClientes();
                    run();
                    break;
                case "0":
                    Environment.Exit(1);
                    break;
                default:
                    Utlis.userError();
                    noMostrarMontoFinal();
                    break;
            }
        }

        private void printClientes()
        {
            List<Cliente> clientes = Model.getClientes();
            int cliente = 0;

            foreach (Cliente element in clientes)
            {
                cliente += 1;
                Console.WriteLine($"La compra total del cliente {cliente} es {element._MontoTotal}");
            }

            Console.WriteLine($"En número de clientes atendidos es {clientes.Count}.");
        }
    }
}
