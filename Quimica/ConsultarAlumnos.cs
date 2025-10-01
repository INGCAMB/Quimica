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
    public partial class ConsultarAlumnos : Form
    {
        bool nosalir = false;

        public ConsultarAlumnos()
        {
            InitializeComponent();

            Consultainicial();
        }

        private void ConsultarAlumnos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Calificaciones")
            {
                label2.Visible = true;
                comboBox2.Visible = true;

                ConsultarCalificacionesTodos();
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;

                Consultainicial();
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Aprobados")
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "select nombre, calificacion, fecha, examen from usuarios, historial where calificacion > 6 and admin = false and " +
                        "usuarios.id_usuario = historial.id_usuario;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                    DataTable datostabla = new DataTable();
                    adaptador.Fill(datostabla);
                    dataGridView1.DataSource = datostabla;
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n\n" + ex);
                }
            }
            else if (comboBox2.Text == "Reprobados")
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                try
                {
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "select nombre, calificacion, fecha, examen from usuarios, historial where calificacion < 7 and admin = false and usuarios.id_usuario = historial.id_usuario;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                    DataTable datostabla = new DataTable();
                    adaptador.Fill(datostabla);
                    dataGridView1.DataSource = datostabla;
                    conectar.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n\n" + ex);
                }
            }
            else if (comboBox2.Text == "Calificación")
            {
                label3.Visible = true;
                comboBox3.Visible = true;
                ConsultarPorCalificacionExamenes();
            }
            else
            {
                label3.Visible = false;
                comboBox3.Visible = false;
                ConsultarCalificacionesTodos();
            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConsultarPorCalificacionExamenes();
        }

        private void Consultainicial()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select id_usuario, nombre, correo from usuarios where admin = false;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void ConsultarCalificacionesTodos()
        {
            try
            {
                //No hace bien consulta, hay que hacer que haga consulta a dos tablas para
                //conseguir los resultados de los examenes y del nombre de los alumnos;
                //Consultar la tabla de Usuarios con los alumnos, y la tabla Historial.
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select nombre, calificacion, fecha, examen from usuarios, historial where admin = false and usuarios.id_usuario = historial.id_usuario;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                conectar.Close();

                //\"" + VariablesGlobales.MaestroDeMateria + "\" and
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void ConsultarPorCalificacionExamenes()
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=quimicabd; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select nombre, calificacion, fecha, examen from usuarios, historial where calificacion = " + comboBox3.Text + " and admin = false" +
                    " and usuarios.id_usuario = historial.id_usuario;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Admin mp = new Admin();
            mp.Show();
            nosalir = true;
            Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
        }
    }
}
