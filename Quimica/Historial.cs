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
    public partial class Historial : Form
    {
        bool nosalir = false;

        public Historial()
        {
            InitializeComponent();

            ConsultarRegistros();
        }

        private void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            nosalir = true;
            Close();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere borrar el historial?", "¿Borrar historial?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "delete from historial where id_usuario = " + VariablesGlobales.IdDeUsuarioActivo + ";";
                codigo.ExecuteNonQuery();
                conectar.Close();

                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
                nosalir = true;
                Close();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
        }

        private void ConsultarRegistros()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select examen, calificacion, fecha from historial where id_usuario = " + VariablesGlobales.IdDeUsuarioActivo + ";";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos:\n\n" + ex);
            }
        }
    }
}
