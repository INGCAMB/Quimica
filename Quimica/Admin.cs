using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quimica
{
    public partial class Admin : Form
    {
        bool nosalir = false;

        public Admin()
        {
            InitializeComponent();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            nosalir = true;
            Login regresar = new Login();
            regresar.Show();
            Close();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            nosalir = true;
            ConsultarAlumnos consulta = new ConsultarAlumnos();
            consulta.Show();
            Close();
        }

        private void IrAExamen()
        {
            InfoExamen examen = new InfoExamen();
            examen.Show();
            nosalir = true;
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            VariablesGlobales.TipoDeExamen = "dificil";
            IrAExamen();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            VariablesGlobales.TipoDeExamen = "quimico";
            IrAExamen();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VariablesGlobales.TipoDeExamen = "balanceo";
            IrAExamen();
        }
    }
}
