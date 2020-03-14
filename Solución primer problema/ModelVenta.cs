using System;
using System.Collections.Generic;

namespace app
{
    internal class ModelVenta
    {
        private List<Venta> ventas = new List<Venta>();
        private List<Cliente> clientes = new List<Cliente>();

        public void addVenta(double valor, float cantidad)
        {
            Venta venta = new Venta();
            venta.Valor = valor;
            venta.Cantidad = cantidad;
            ventas.Add(venta);
        }

        public void addCliente(double montoTotal)
        {
            Cliente cliente = new Cliente(montoTotal);
            clientes.Add(cliente);
        }

        public double calculateTotal()
        {
            double montoTotal = 0;

            foreach (Cliente element in clientes)
            {
                montoTotal += element._MontoTotal;
            }
            return montoTotal;
        }

        public List<Venta> getVentas()
        {
            return ventas;
        }

        public double getTotalVentas()
        {
            double montoTotal = 0;

            foreach (Venta element in ventas)
            {
                montoTotal += element.getTotal();
            }
            return montoTotal;
        }

        public List<Cliente> getClientes()
        {
            return clientes;
        }

        public void resetVentas()
        {
            ventas.Clear();
        }

        public void resetClientes()
        {
            clientes.Clear();
        }
    }
}