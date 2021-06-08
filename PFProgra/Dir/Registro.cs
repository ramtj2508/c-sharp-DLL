using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFProgra
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string TU, NU, Palabra, Contraseña;

            try
            {
                var CP = new DLL.ClaseRegistro();
                TU = cmbtipo.SelectedItem.ToString();
                NU = txtnombreusuario.Text;
                Contraseña = txtcontraseña.Text;
                Palabra = txtpalabra.Text;

                if (CP.Registro(TU, NU, Contraseña, Palabra))
                {
                    MessageBox.Show("Guardado con éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
