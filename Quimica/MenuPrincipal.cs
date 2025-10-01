using Quimica;
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
    public partial class MenuPrincipal : Form
    {
        bool nosalir = false;
        public MenuPrincipal()
        {
            InitializeComponent();
            label1.Text = "¡Bienvenido " + VariablesGlobales.NombreDeUsuarioActivo + "!";
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nosalir = true;
            Login regresar = new Login();
            regresar.Show();
            Close();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil p = new Perfil();
            p.Show();
            nosalir = true;
            Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            VariablesGlobales.TipoDeExamen = "dificil";
            IrAExamen();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            VariablesGlobales.TipoDeExamen = "quimico";
            IrAExamen();
        }

        private void IrAExamen()
        {
            InfoExamen examen = new InfoExamen();
            examen.Show();
            nosalir = true;
            Close();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
            nosalir = true;
            Close();
        }
        private void consultadeusuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios consultas1 = new ConsultaUsuarios();
            consultas1.Show();
            nosalir = true;
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
            nosalir = true;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            VariablesGlobales.TipoDeExamen = "balanceo";
            IrAExamen();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
