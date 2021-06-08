using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
    public class Buscar2
    {
        public DataSet Historial(string fecha)
        {

            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            var Conjunto = new DataSet();
            try
            {
                var Consulta = new SqlDataAdapter("SELECT * FROM Historial WHERE Fecha= '" + fecha + "'", Conexion);

                Conexion.Open();
                Consulta.Fill(Conjunto, "Historial");
                Conexion.Close();
                return Conjunto;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                return Conjunto;
            }
        }
        public DataSet Historial2 (string fecha, string hora)
        {

            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            var Conjunto = new DataSet();
            try
            {
                var Consulta = new SqlDataAdapter("SELECT * FROM Historial WHERE Fecha= '" + fecha + "' AND Hora = '" + hora + "'", Conexion);

                Conexion.Open();
                Consulta.Fill(Conjunto, "Historial");
                Conexion.Close();
                return Conjunto;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                return Conjunto;
            }
        }
        public DataSet OP(string fecha, string hora)
        {

            var Conexion = new SqlConnection("Data Source= LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");
            var Conjunto = new DataSet();
            try
            {
                var Consulta = new SqlDataAdapter("SELECT Hora, Nombre, Direccion FROM Historial WHERE Fecha= '" + fecha + "' AND Hora = '" + hora + "'", Conexion);

                Conexion.Open();
                Consulta.Fill(Conjunto, "Historial");
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
