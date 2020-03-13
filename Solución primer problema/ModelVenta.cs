using System;

namespace app
{
    internal class ModelVenta
    {
        private Venta[] ventas = new Venta[50];
        private int count = 0;

        public void add(string descripcion, double valor, float cantidad)
        {
            Venta venta = new Venta();
            venta.setDescripcion(descripcion);
            venta.setValor(valor);
            venta.setCantidad(cantidad);
            ventas[count] = venta;
            count += 1;
        }

        public double calculateTotal()
        {
            double totalVentas = 0;
            for(int i = 0; i <= getTopeVentas(); i++)
            {
                if (ventas[i] != null)
                {
                    totalVentas += ventas[i].getTotal();
                }
            }
            return totalVentas;
        }

        public Venta[] getVentas()
        {
            return ventas;
        }

        public int getTopeVentas()
        {
            return ventas.Length - 1;
        }

        public void resetVentas()
        {
            Array.Clear(ventas, 0, ventas.Length);
        }
    }
}