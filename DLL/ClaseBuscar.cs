using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
    public class ClaseBuscar
    {
        public DataSet Buscar(string nombre)
        {
            
            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            var Conjunto = new DataSet();
            try
            {
                var Consulta = new SqlDataAdapter("SELECT * FROM Guardar1 WHERE Nombre= '" + nombre + "'", Conexion);

                Conexion.Open();
                Consulta.Fill(Conjunto, "Guardar1");
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
