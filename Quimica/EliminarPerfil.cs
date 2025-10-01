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
    public partial class EliminarPerfil : Form
    {
        public EliminarPerfil()
        {
            InitializeComponent();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            string ContraComp = "";
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select * from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                ContraComp = leer.GetString(3);
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex);
            }

            if (contra.Text == ContraComp)
            {
                BorrarHistorial();
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "delete from usuarios where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
                codigo.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("La cuenta fue eliminada exitosamente");

                Login login = new Login();
                login.Show();
                Close();
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta, intente de nuevo.");
                contra.Text = "";
                contra.Focus();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            p.Show();
            Close();
        }

        private void BorrarHistorial()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "delete from historial where id_usuario = " + VariablesGlobales.IdDeUsuarioActivo + ";";
            codigo.ExecuteNonQuery();
            conectar.Close();
        }
    }
}
