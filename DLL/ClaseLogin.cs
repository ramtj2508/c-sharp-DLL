using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
    public class ClaseLogin
    {
        public DataSet Login(string usuario)
        {
            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            var Conjunto = new DataSet();
            try
            {
                var Consulta = new SqlDataAdapter("SELECT * FROM Tabla1 WHERE Usuario= '" + usuario + "'", Conexion);

                Conexion.Open();
                Consulta.Fill(Conjunto, "Tabla1");
                Conexion.Close();
                return Conjunto;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                return Conjunto;
            }
        }
    }
}
