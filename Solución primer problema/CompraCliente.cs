namespace app
{
    class CompraCliente
    {
        private double _MontoTotal;

        public CompraCliente(double montoTotal)
        {
            this._MontoTotal = montoTotal;
        }

        public double MontoTotal
        {
            get => _MontoTotal;
        }
    }
}
