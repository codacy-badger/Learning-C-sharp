namespace app
{
    internal class Venta
    {
        private double valor;
        private float cantidad;

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }        

        public float Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double getTotal()
        {
            return this.valor * this.cantidad;
        }   
    }
}
