using System.Collections.Generic;

namespace app
{
    class ModelEstudiante
    {
        private int[] Counter = new int[] { 0 , 0 };
        private List<Estudiante> _Estudiantes = new List<Estudiante>();

        public List<Estudiante> Estudiantes
        {
            get => _Estudiantes;
        }

        public void addEstudiante()
        {
            Estudiante estudiante = new Estudiante(this.Counter[0]);
            Estudiantes.Add(estudiante);
            Counter[0] += 1;
        }
       
        public void addMateria(int idEstd, string nombre, float[] notas)
        {
            Materia materia = new Materia(nombre, notas);
            Estudiante estudiante = this.searchEstudiante(idEstd);
            estudiante.Materias.Add(materia);
            Counter[1] += 1;
        }

        public void editMaterias(
            int idEstd, 
            string nombre, 
            string nuevoNombre,
            float[] notas
        )
        {
            Materia materia = this.searchMateria(idEstd, nombre);
            materia.Nombre = nuevoNombre;
            materia.Notas = notas;
        }

        public void deleteEstudiante(int idEstd)
        {
            Estudiantes.Remove(this.searchEstudiante(idEstd));
        }

        public void deleteMaterias(int idEstd, string nombre)
        {
            this.searchEstudiante(idEstd).Materias.Remove(
                this.searchMateria(idEstd, nombre)
            );
        }

        public Estudiante searchEstudiante(int idEstd)
        {
            return Estudiantes.Find(Estudiante => Estudiante.Id == idEstd);       
        }

        public Materia searchMateria(int idEstd, string nombre)
        {
            return Estudiantes[idEstd].Materias.Find(Materia => Materia.Nombre == nombre);
        }
    }
}
