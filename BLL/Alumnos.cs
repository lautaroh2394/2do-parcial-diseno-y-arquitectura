using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Alumnos
    {
        public BE.Alumno GetAlumno(int id)
        {
            Acceso acceso = new Acceso();
            SqlParameter[] parameters = new SqlParameter[1] { new SqlParameter("id", id) };
            DataSet ds = acceso.GetDataSourceForCommand("select nombre, apellido, fecha_nacimiento from alumnos where id = @id", parameters);
            DataRow firstRow = ds.Tables[0].Rows[0];
            
            BE.Alumno alumno = null;
            string nombre = firstRow.Field<string>("nombre");
            string apellido = firstRow.Field<string>("apellido");
            DateTime fecha_nacimiento = firstRow.Field<DateTime>("fecha_nacimiento");
            alumno = new BE.Alumno(id, nombre, apellido, fecha_nacimiento);

            return alumno;
        }

        public int BajaAlumno(BE.Alumno alumno)
        {
            int id = alumno.id;
            Acceso acceso = new Acceso();
            SqlParameter[] parameters = new SqlParameter[1] { new SqlParameter("id", id) };
            int rowsAffected = acceso.ExecuteProcedure("baja_alumno", parameters);
            return rowsAffected;
        }

        public int AltaAlumno(BE.Alumno alumno)
        {
            string fecha_string = alumno.fecha_nacimiento.ToString("yyyy-MM-dd HH:mm:ss");
            Acceso acceso = new Acceso();
            SqlParameter[] parameters = new SqlParameter[3] { 
                new SqlParameter("nombre", alumno.nombre) ,
                new SqlParameter("apellido", alumno.apellido) ,
                new SqlParameter("fecha_nacimiento", fecha_string)
            };
            int rowsAffected = acceso.ExecuteProcedure("alta_alumno", parameters);
            return rowsAffected;
        }

        public int ModificarAlumno(BE.Alumno alumno)
        {
            string fecha_string = alumno.fecha_nacimiento.ToString("yyyy-MM-dd HH:mm:ss");
            Acceso acceso = new Acceso();
            SqlParameter[] parameters = new SqlParameter[4] {
                new SqlParameter("id", alumno.id),
                new SqlParameter("nombre", alumno.nombre) ,
                new SqlParameter("apellido", alumno.apellido) ,
                new SqlParameter("fecha_nacimiento", fecha_string)
            };
            int rowsAffected = acceso.ExecuteProcedure("modificar_alumno", parameters);
            return rowsAffected;
        }

        public DataSet GetAlumnos()
        {
            return new DAL.Acceso().GetDataSourceForCommand("select id, CONCAT(nombre, ' ', apellido, ' ', ' (', id, ')') as show_text from alumnos");
        }

        public BE.Alumno MapAlumno(int id, string nombre, string apellido, DateTime fecha_nacimiento)
        {
            return new BE.Alumno(id, nombre, apellido, fecha_nacimiento);
        }
    }
}
