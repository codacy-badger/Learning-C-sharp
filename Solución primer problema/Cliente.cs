namespace app
{
    internal class Cliente
    {
        private double MontoTotal;

        public Cliente(double montoTotal)
        {
            MontoTotal = montoTotal;
        }

        public double _MontoTotal
        {
            get
            {
                return MontoTotal;
            }
        }
    }
}
