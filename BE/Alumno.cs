using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Alumno
    {
        public string nombre;
        public string apellido;
        public DateTime fecha_nacimiento;
        public int id;

        public Alumno(int id, string nombre, string apellido, DateTime fecha_nacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha_nacimiento = fecha_nacimiento;
        }
    }

    public class Curso
    {
        public string nombre;
        public DateTime fecha_limite;
        public int cupo;
        public float costo;
        public int id;

        public Curso(int id, string nombre, DateTime fecha_limite, int cupo, float costo)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_limite = fecha_limite;
            this.cupo = cupo;
            this.costo = costo;
        }
    }
}
