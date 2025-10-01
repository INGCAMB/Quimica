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
    public partial class InfoExamen : Form
    {
        bool nosalir = false;
        int NoDePreguntas = 4;

        public InfoExamen()
        {
            InitializeComponent();

            label1.Text = "Examen " + VariablesGlobales.TipoDeExamen;

            if (VariablesGlobales.TipoDeExamen == "dificil")
            {
                label2.Text = "Esta a punto de realizar el examen de " + VariablesGlobales.TipoDeExamen + ", se le va a presentar 15 "
                + "preguntas y tendrá que seleccionar una de las " + NoDePreguntas + " opciones que tiene " 
                + "como respuesta. No hay límite de tiempo, tómese el tiempo necesario para contestar cada " 
                + "reactivo. \n\nCuando se sienta preparado, presione \"Empezar\" para proseguir a iniciar "
                + "con el examen.";
            }
            else if (VariablesGlobales.TipoDeExamen == "quimico")
            {
                label2.Text = "Esta a punto de realizar el examen de " + VariablesGlobales.TipoDeExamen + ", se le va a presentar 15 "
               + "preguntas y tendrá que seleccionar una de las " + (NoDePreguntas - 2) + " opciones que tiene "
               + "como respuesta. No hay límite de tiempo, tómese el tiempo necesario para contestar cada "
               + "reactivo. \n\nCuando se sienta preparado, presione \"Empezar\" para proseguir a iniciar "
               + "con el examen.";
            }
            else
            {
                label2.Text = "Esta a punto de realizar el examen de " + VariablesGlobales.TipoDeExamen + ", se le va a presentar 15 "
               + "preguntas y tendrá que seleccionar una de las " + (NoDePreguntas - 1) + " opciones que tiene "
               + "como respuesta. No hay límite de tiempo, tómese el tiempo necesario para contestar cada "
               + "reactivo. \n\nCuando se sienta preparado, presione \"Empezar\" para proseguir a iniciar "
               + "con el examen.";
            }
        }

        private void InfoExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nosalir == false)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Intro i = new Intro();
            i.Show();
            nosalir = true;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            nosalir = true;
            Close();
        }

        private void InfoExamen_Load(object sender, EventArgs e)
        {

        }
    }
}
