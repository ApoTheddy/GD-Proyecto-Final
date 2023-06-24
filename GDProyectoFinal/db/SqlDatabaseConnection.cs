using System.Data;
using System.Data.SqlClient;

namespace GDProyectoFinal.db
{
    public class SqlDatabaseConnection
    {

        public static SqlConnection GetConnecion()
        {
            const string url = "Data Source=DESKTOP-4HE0THI\\SQLEXPRESS;Integrated Security=True; database = ;";
            try
            {
                using SqlConnection connection = new(url);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                if (ex is SqlException sqlex)
                    throw new Exception($"Ocurrio un error al conectar a SQL: {sqlex.Message}");
                else
                    throw new Exception($"Ocurrio un error al obtener la conexion: {ex.Message}");
            }
        }
    }
}
