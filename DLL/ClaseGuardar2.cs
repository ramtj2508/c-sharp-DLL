using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
    public class ClaseGuardar2
    {
        public bool Historial(string hora, string NE, string Direccion, double Costo, string fecha)
        {
            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            try
            {
                var guardar = new SqlCommand("INSERT INTO Historial (Hora, Nombre, Direccion, Costo, Fecha) VALUES ('" + hora + "','" + NE + "','" + Direccion + "','" + Costo + "','"+fecha+"')", Conexion);
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
