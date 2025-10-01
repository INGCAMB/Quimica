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
    public partial class Resultados : Form
    {
        int CalificacionFinal = VariablesGlobales.AcumuladorDePuntos;
        string Examen = VariablesGlobales.TipoDeExamen;
        bool nosalir = false;

        public Resultados()
        {
            InitializeComponent();

            label2.Text = "Resultado = " + CalificacionFinal;

            if (Examen == "dificil" || Examen == "quimico")
            {
                if (CalificacionFinal <= 2)
                {
                    label1.Text = "Ya no te graduastes perdedor y te dices llamar químico";
                    label3.Text = "Gracias por haber acabado el examen, pero lamentablemente no" +
                        " acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia " +
                        "de química.\n\n" + "Gracias por utilizar nuestro servicio";
                }
                else if (CalificacionFinal >= 3 && CalificacionFinal <= 5)
                {
                    label1.Text = "Para química no sirves";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 6 && CalificacionFinal <= 8)
                {
                    label1.Text = "Ni con opción multiple pudiste";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 9 && CalificacionFinal <= 11)
                {
                    label1.Text = "Deja de intentar y cambiate a una licenciatura";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 12 && CalificacionFinal <= 14)
                {
                    label1.Text = "Mejor cambiate a industrial";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else
                {
                    label1.Text = "¡Felicitaciones listo para graduarte!";
                    label3.Text = "Felicidades, logró una excelente calificación en el examen de química"
                        + ". Le recomendamos que consulte dudas con un docente de su escuela sobre la " +
                        "materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
            }
            else
            {
                if (CalificacionFinal <= 2)
                {
                    label1.Text = "JAJAJA y te dices llamar quimico, te recuerdo que hay mas especializades";
                    label3.Text = "Gracias por haber acabado el examen, pero lamentablemente no" +
                        " acumuló suficientes puntos para conseguir una buena calificación. " +
                        "Le recomendamos que consulte dudas con un docente de su escuela sobre la materia " +
                        "de química.\n\n" + "Gracias por utilizar nuestro servicio";
                }
                else if (CalificacionFinal >= 3 && CalificacionFinal <= 5)
                {
                    label1.Text = "¿Estas seguro de que elegiste la carrera correcta?";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 6 && CalificacionFinal <= 8)
                {
                    label1.Text = "Nunca es tarde para cambiar a psicología";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 9 && CalificacionFinal <= 11)
                {
                    label1.Text = "Uh! hasta los de segundo saben mas que tu";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else if (CalificacionFinal >= 12 && CalificacionFinal <= 14)
                {
                    label1.Text = "Si no pudiste con esto menos con la vida";
                    label3.Text = "Felicidades no lo lograste, logró una mala calificación en el examen de química" +
                        ". Lo invitamos a que vuelva a realizar el examen para intentar conseguir una " +
                        "calificación más alta, le recomendamos que consulte dudas con un docente de su escuela " +
                        "sobre la materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
                else
                {
                    label1.Text = "¡Felicitaciones listo para graduarte!";
                    label3.Text = "Felicidades, logró una excelente calificación en el examen de química"
                        + ". Le recomendamos que consulte dudas con un docente de su escuela sobre la " +
                        "materia de química.\n\nGracias por utilizar nuestro servicio.";
                }
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.UsuarioAdministrador == true)
            {
                Admin mostrar = new Admin();
                mostrar.Show();
            }
            else
            {
                MenuPrincipal mostrar = new MenuPrincipal();
                mostrar.Show();
            }
            nosalir = true;
            Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
