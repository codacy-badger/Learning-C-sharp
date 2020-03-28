﻿using System.Collections.Generic;

namespace app
{
    class Estudiante
    {
        private List<Materia> _Materias = new List<Materia>();

        public List<Materia> Materias 
        {
            get => _Materias;
            set => _Materias = value;
        }

        public float getPromedio()
        {
            if (Materias.Count == 0) { return 0f;}

            float sumNotas = 0;
            int numNotas = 0;
            
            for (int i = 0; i <= Materias.Count -1; i++)
            {
                foreach (float element in Materias[i].Notas)
                {
                    sumNotas += element;
                    numNotas += 1;
                }
            }
            return sumNotas / numNotas;
        }
    }
}
