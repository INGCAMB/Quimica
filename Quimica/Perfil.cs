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
    public partial class Perfil : Form
    {
        string NombreViejo = "", CorreoViejo = "";
        bool nosalir = false;

        public Perfil()
        {
            InitializeComponent();

            ConsultarDatos();
        }

        private void Perfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            ModificarPerfil modificar = new ModificarPerfil();
            modificar.Show();
            nosalir = true;
            Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            EliminarPerfil ep = new EliminarPerfil();
            ep.Show();
            nosalir = true;
            Close();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            nosalir = true;
            Close();
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
            conectar.Close();

            nombre.Text = NombreViejo;
            correo.Text = CorreoViejo;

            nombre.Text = VariablesGlobales.NombreDeUsuarioActivo;
            correo.Text = VariablesGlobales.CorreoDelUsuarioActivo;
        }
    }
}
