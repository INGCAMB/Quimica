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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        PictureBox[] pict;

        int count = 0;

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pict = new PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
        }

        private void Intro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Examen pr = new Examen(); pr.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (count < 5)
            {
                pict[count].BackgroundImage = Quimica.Properties.Resources.Circle2;
                count++;
                label.Text = "Cargando al " + (count * 20) + " %";
            }
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}
