using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quimica
{
    public partial class ModificarPerfil : Form
    {
        string NombreViejo = "", CorreoViejo = "", ContraVieja = "";

        public ModificarPerfil()
        {
            InitializeComponent();

            ConsultarDatos();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            RealizarCambios();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            p.Show();
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            aceptar.Enabled = true;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            aceptar.Enabled = true;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            aceptar.Enabled = true;
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
                textBox3.Focus();
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox4.Focus();
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                aceptar.Focus();
            }
        }

        public void ConsultarDatos()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "select * from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            NombreViejo = leer.GetString(1);
            CorreoViejo = leer.GetString(2);
            ContraVieja = leer.GetString(3);
            conectar.Close();

            textBox1.Text = NombreViejo;
            textBox2.Text = CorreoViejo;
        }

        public void RealizarCambios()
        {
            if (textBox3.Text == "")
            {
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuarios set nombre = \"" + textBox1.Text + "\", correo = \"" +
                        textBox2.Text + "\" where correo = \"" + CorreoViejo + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    VariablesGlobales.NombreDeUsuarioActivo = textBox1.Text;
                    VariablesGlobales.CorreoDelUsuarioActivo = textBox2.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else if (ContraVieja == textBox3.Text)
            {
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuarios set nombre = \"" + textBox1.Text + "\", correo = \"" +
                        textBox2.Text + "\", Contra = \"" + textBox4.Text + "\" where correo = \"" +
                        CorreoViejo + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    VariablesGlobales.NombreDeUsuarioActivo = textBox1.Text;
                    VariablesGlobales.CorreoDelUsuarioActivo = textBox2.Text;

                    MessageBox.Show("Cambios realizados exitosamente");

                    Perfil p = new Perfil();
                    p.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, favor de intentarlo de nuevo");
            }
        }
    }
}
