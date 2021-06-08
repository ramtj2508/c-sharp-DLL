using System;
using System.Data;
using System.Data.SqlClient;


namespace DLL
{
    public class ClaseRegistro
    {
        public bool Registro(string TU, string NU, string Contraseña, string Palabra)
        {
            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            try
            {
                var guardar = new SqlCommand("INSERT INTO Tabla1 (Tipo, Usuario, Contraseña, Palabra) VALUES ('" + TU + "','" + NU + "','" + Contraseña + "','"+Palabra+"')", Conexion);
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
