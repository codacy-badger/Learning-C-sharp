namespace app
{
    internal class Venta
    {
        private string descripcion;
        private double valor;
        private float cantidad;

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor() 
        {
            return this.valor;
        }

        public void setCantidad(float cantidad)
        {
            this.cantidad = cantidad;
        }

        public float getCantidad()
        {
            return this.cantidad;
        }

        public double getTotal()
        {
            return this.valor * this.cantidad;
        }   
    }
}
