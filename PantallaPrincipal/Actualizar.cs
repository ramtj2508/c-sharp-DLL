using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }
        

        private void btningresar_Click(object sender, EventArgs e)
        {
            string palabra, contraseña, p1, c1;
            var Conjunto = new DataSet();
            DataRow Renglon;
            try
            {
                var A = new DLL.Actualizar();
                palabra = txtpalabra.Text;
                contraseña = txtcontraseña.Text;

                Conjunto = A.Buscar(palabra);
                Renglon = Conjunto.Tables["Tabla1"].Rows[0];
                p1 = Renglon["Palabra"].ToString();
             //   c1 = Renglon["Contraseña"].ToString();
                if (palabra==p1)
                {
                    if (A.ActualizarCon(contraseña, palabra))
                        MessageBox.Show("Contraseña actualizada correctamente");
                    else
                    {
                        MessageBox.Show(".");
                    }
                }
                else
                {
                    MessageBox.Show("Palabra clave incorrecta, reintente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
