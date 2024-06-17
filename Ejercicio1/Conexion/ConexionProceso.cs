using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{

    public class Estudiante
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=academico;User ID=sa;Password=123456;";

        public Conexion GetEstudianteById(int id)
        {
            Conexion estudiante = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = $"SELECT id, nombre, apellido, edad FROM estudiante WHERE id = {id}";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        estudiante = new Conexion
                        {
                            Id = (int)reader["Id"],
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Edad = (int)reader["Edad"]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción o registrar el error
                Console.WriteLine(ex.Message);
                throw;
            }

            return estudiante;
        }
    }

}
