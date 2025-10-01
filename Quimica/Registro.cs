using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Quimica
{
    public partial class Registro : Form
    {
        bool nosalir = false;

        public Registro()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(nombre);
            sList.Add("Nombre");
            SetCueBanner(ref tList, sList);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }



        private void ConsultaCorreo()
        {
            string comparacion = "";
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();

                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select * from usuarios where correo = \"" + correo.Text + "\"";
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                comparacion = leer.GetString(2);
                conectar.Close();
                MessageBox.Show("No se puede dar de alta al usuario porque el correo que intenta utilizar ya está registrado");
            }
            catch (Exception)
            {
                AltaUsuario();
            }
        }

        private void AltaUsuario()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "insert into usuarios (nombre, correo, contra) values (" + "\"" + nombre.Text + "\", \"" +
                    correo.Text + "\", \"" + contra.Text + "\");";
                codigo.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado");
                conectar.Close();
                Login login = new Login();
                login.Show();
                nosalir = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la alta del usuario...\n" + ex);
                return;
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            nosalir = true;
            Login regresar = new Login();
            regresar.Show();
            Close();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string cadena = nombre.Text;
            //nombre.Text = Convert.ToString(cadena.Length);
            if (nombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario!");
                nombre.Focus();
            }
            else if (contra.Text == "")
            {
                MessageBox.Show("Ponga una contraseña a su cuenta");
                contra.Focus();
            }
            else if (conf_contra.Text == "")
            {
                MessageBox.Show("Favor de confirmar la contraseña");
                conf_contra.Focus();
            }
            else if (correo.Text == "")
            {
                MessageBox.Show("Por favor ingrese su correo electrónico");
                correo.Focus();
            }
            else if (conf_correo.Text == "")
            {
                MessageBox.Show("Favor de confirmar el correo");
                conf_correo.Focus();
            }
            else if (contra.Text != conf_contra.Text)
            {
                MessageBox.Show("La confirmación de contraseña no coincide");
            }
            else if (correo.Text != conf_correo.Text)
            {
                MessageBox.Show("La confirmación de correo no coincide");
            }
            else
            {
                ConsultaCorreo();
            }
        }
    }
}
