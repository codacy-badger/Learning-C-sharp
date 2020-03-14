using System.Collections.Generic;

namespace app
{
    class LogicCompraDelCliente
    {
        private List<CompraCliente> comprasClientesList = new List<CompraCliente>();

        public void add(double montoTotal)
        {
            CompraCliente cliente = new CompraCliente(montoTotal);
            comprasClientesList.Add(cliente);
        }

        public double calculateTotal()
        {
            double montoTotal = 0;

            foreach (CompraCliente element in comprasClientesList)
            {
                montoTotal += element.MontoTotal;
            }
            return montoTotal;
        }

        public List<CompraCliente> getCompras()
        {
            return comprasClientesList;
        }

        public void reset()
        {
            comprasClientesList.Clear();
        }
    }
}
