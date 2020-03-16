namespace app
{
    internal class Venta
    {
        private double valor;
        private float cantidad;

        public Venta(double valor, float cantidad)
        {
            this.valor = valor;
            this.cantidad = cantidad;
        }

        public double getTotal()
        {
            return this.valor * this.cantidad;
        }   
    }
}
