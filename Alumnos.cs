using System;

namespace PR2_Alumnos
{
    class Alumnos
    {
        public string nombre;
        public string apellido;

        public string nombreMatri;
        public int matricula;

        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido + " " + this.nombreMatri + " " + this.matricula;
        }

        public Alumnos(string nombre, string apellido, string nombreMatri, int matricula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreMatri = nombreMatri;
            this.matricula = matricula;
        }     
       
    }
}        