namespace app
{
    class Materia
    {
        private string _Nombre;
        private float[] _Notas = new float[3];

        public Materia(string nombre, float[] notas)
        {
            this._Nombre = nombre;
            this._Notas = notas;
        }

        public string Nombre
        {
            get => this._Nombre;
            set => this._Nombre = value;
        }
        
        public float[] Notas
        {
            get => this._Notas;
            set => this._Notas = value;
        }
    }
}
