using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Cursos
    {

        public int AltaCurso(
            BE.Curso curso
            )
        {
            Acceso acceso = new Acceso();
            string fecha_string = curso.fecha_limite.ToString("yyyy-MM-dd HH:mm:ss");
            SqlParameter[] parameters = new SqlParameter[4] {
                new SqlParameter("costo", curso.costo) ,
                new SqlParameter("fecha_limite", fecha_string) ,
                new SqlParameter("cupo", curso.cupo),
                new SqlParameter("nombre", curso.nombre)
            };
            int rowsAffected = acceso.ExecuteProcedure("alta_curso", parameters);
            return rowsAffected;
        }

        public BE.Curso MapCurso(int id, string nombre, float costo, int cupo, DateTime fecha_limite)
        {
            return new Curso(id, nombre, fecha_limite, cupo, costo);
        }

        public float GetRecaudacionTotal()
        {
            Acceso acceso = new Acceso();
            DataSet ds = acceso.GetDataSourceForProcedure("recaudacion_por_curso");
            float total = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                total += float.Parse(row.Field<Double>("total").ToString());
            }
            return total;
        }

        public DataSet GetRecaudacionPorCursoDataSource()
        {
            Acceso acceso = new Acceso();
            return acceso.GetDataSourceForProcedure("recaudacion_por_curso");
        }
    }
}
