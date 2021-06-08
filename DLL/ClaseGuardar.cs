using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
   public class ClaseGuardar
    {
        public bool Guardar(string NE, string Direccion, double Costo)
        {
            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            try
            {
                var guardar = new SqlCommand("INSERT INTO Guardar1 (Nombre, Direccion, Costo) VALUES ('" + NE + "','" + Direccion + "','" + Costo + "')", Conexion);
                Conexion.Open();
                guardar.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
