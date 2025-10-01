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
    public partial class Login : Form
    {
        public string Nombre = "", Correo = "", Contra = "", Maestro = "";
        public int id = 0;
        public bool Admin = false;

        public Login()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(textBox2);
            sList.Add("Contraseña");
            tList.Add(textBox1);
            sList.Add("Número de control");
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Mostrar Fecha y Hora
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Lblregistro_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            ventana.Show();
            Visible = false;
        }

        private void Btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("El pago se a realizado exitosamente", "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Aceptar_MouseHover(object sender, EventArgs e)
        {
            aceptar.Size = new Size(95, 65);
        }

        private void Aceptar_MouseLeave(object sender, EventArgs e)
        {
            aceptar.BackgroundImageLayout = ImageLayout.Stretch;
            aceptar.Size = new Size(90, 55);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                aceptar.Focus();
            }
        }

        public void Consulta()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;"); 
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select * from usuarios where correo = \"" + textBox1.Text + "\";";
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                id = leer.GetInt32(0);
                Nombre = leer.GetString(1);
                Correo = leer.GetString(2);
                Contra = leer.GetString(3);
                Admin = leer.GetBoolean(4);
                if (Admin)
                {
                    Maestro = leer.GetString(5);
                }
                conectar.Close();

                VariablesGlobales.IdDeUsuarioActivo = id;
                VariablesGlobales.NombreDeUsuarioActivo = Nombre;
                VariablesGlobales.CorreoDelUsuarioActivo = Correo;

                if (textBox1.Text == Correo && textBox2.Text == Contra)
                {
                    if (Admin)
                    {
                        VariablesGlobales.MaestroDeMateria = Maestro;
                        VariablesGlobales.UsuarioAdministrador = true;
                        Admin admin = new Admin();
                        admin.Show();
                        Visible = false;
                    }
                    else
                    {
                        MenuPrincipal mp = new MenuPrincipal();
                        mp.Show();
                        Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña inválida, favor de intentarlo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El correo que ingresó no existe, favor de intentar de nuevo\n" + ex);
            }
        }
    }
}
