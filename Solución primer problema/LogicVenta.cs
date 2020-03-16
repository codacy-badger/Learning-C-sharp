using System.Collections.Generic;

namespace app
{
    class LogicVenta
    {
        private List<Venta> ventasList = new List<Venta>();

        public void add(double valor, float cantidad)
        {
            Venta venta = new Venta(valor, cantidad);
            ventasList.Add(venta);
        }

        public List<Venta> getVentas()
        {
            return ventasList;
        }

        public double getTotal()
        {
            double montoTotal = 0;

            foreach (Venta element in ventasList)
            {
                montoTotal += element.getTotal();
            }
            return montoTotal;
        }

        public void reset()
        {
            ventasList.Clear();
        }
    }
}