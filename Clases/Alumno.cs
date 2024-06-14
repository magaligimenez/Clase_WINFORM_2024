using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Alumno
    {
        string _nombre; //esto era entes pero da igual usarlo
        string localidad;
        int edad;
        string genero;
        bool habilitado;

        public Alumno(string nombre, string localidad, int edad, string genero, bool habilitado)
        {
            _nombre = nombre;
            this.localidad = localidad;
            this.edad = edad;
            this.genero = genero;
            this.habilitado = habilitado;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("edad: " + this.edad);
            sb.AppendLine("localidad: " + this.localidad);
            sb.AppendLine("genero: " + this.genero);
            if (this.habilitado)
            {
                sb.AppendLine("Estado de habilitacion: " + this.habilitado);
            }
            sb.AppendLine("******************");

            return sb.ToString();
        }

    }
}
