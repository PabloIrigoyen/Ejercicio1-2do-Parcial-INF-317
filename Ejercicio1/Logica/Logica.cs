using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Conexion;

namespace Logica
{
    public class Logica
    {
        private Estudiante var;
        public  Logica()
        {
            var = new Estudiante();
        }

        public Conexion.Conexion GetStudentById(int id)
        {
            return var.GetEstudianteById(id);
        }
    }
}
