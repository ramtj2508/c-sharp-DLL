using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class Form1 : Form
    {
        PFProgra.Operador o;
        PFProgra.Opciones op;
        PFProgra.Sup.Opciones2 op2;
        PFProgra.NvoRegistro nvo;
        PFProgra.Historial h;
        PFProgra.ST st;
        PantallaPrincipal.Actualizar a;

        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, u1, c1, tipo, verifica1, verifica2;
            int USER, PW;
            var Conjunto = new DataSet();
            var Conexion = new SqlConnection("Data Source = LAPTOP-MAT34GR8;" + "Initial Catalog = BDExamen;" + "User=sa; Password= 2508Tony!!");


            DataRow Renglon;
            try
            {
                verifica1 = txtusuario.Text;
                verifica2 = txtcontraseña.Text;
                var Verificar1 = new SqlCommand
                ("SELECT COUNT(*) From " + "Tabla1 WHERE Usuario ='" + verifica1 + "'", Conexion);
                Conexion.Open();
                var contador1 = Verificar1.ExecuteScalar();
                USER = int.Parse(contador1.ToString());

                var Verificar2 = new SqlCommand
               ("SELECT COUNT(*) From " + "Tabla1 WHERE Contraseña ='" + verifica2 + "'", Conexion);

                var contador2 = Verificar2.ExecuteScalar();
                PW = int.Parse(contador2.ToString());
                Conexion.Close();

                if (USER > 0 && PW > 0) { MessageBox.Show("Bienvenido"); }
                if (USER == 0 && PW > 0) { MessageBox.Show("Usuario Incorrecto"); }
                if (USER > 0 && PW == 0) { MessageBox.Show("Contraseña Incorrecta"); }
            }
            catch (Exception ex)
            {
                Conexion.Close();
                MessageBox.Show(ex.Message);
            }
            try
            {
                var CP = new DLL.ClaseLogin();
                usuario = txtusuario.Text;
                contraseña = txtcontraseña.Text;

                Conjunto = CP.Login(usuario);
                Renglon = Conjunto.Tables["Tabla1"].Rows[0];
                tipo = Renglon["Tipo"].ToString();
                u1 = Renglon["Usuario"].ToString();
                c1 = Renglon["Contraseña"].ToString();
                if (contraseña == c1 && usuario==u1)
                {
                    if (tipo == "DIR") { op = new PFProgra.Opciones(); op.Show(); }
                    if (tipo == "SUP") { op2 = new PFProgra.Sup.Opciones2(); op2.Show(); }
                    if (tipo == "OP") { o = new PFProgra.Operador(); o.Show(); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Actualizar();
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

