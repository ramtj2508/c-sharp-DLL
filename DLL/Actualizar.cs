using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
   public class Actualizar
    {
        public DataSet Buscar(string palabra)
        {
            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            var Conjunto = new DataSet();
            try
            {
                var Consulta = new SqlDataAdapter("SELECT * FROM Tabla1 WHERE Palabra= '" + palabra + "'", Conexion);

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
        public bool ActualizarCon(string contraseña, string palabra)
        {   
            var Conexion = new SqlConnection("Data Source = LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "Integrated Security = true;");
            try
            {
                var Actualizar = new SqlCommand("EXEC ActualizarPW '" + contraseña + "','" + palabra + "'", Conexion);
                Conexion.Open();
                Actualizar.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (System.Exception ex)
            {
                Conexion.Close();
                return false;
            }
        }
    }   
}
