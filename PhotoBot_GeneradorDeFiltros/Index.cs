using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace PhotoBot_GeneradorDeFiltros
{
    public partial class Form1 : Form
    {

        private int contador = 0;


        public Form1()
        {
            InitializeComponent();
            contador = 0;
            timer1.Enabled = true;

            this.TransparencyKey = Color.MediumSlateBlue;
            this.BackColor = Color.MediumSlateBlue;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;

            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;

                Pantalla_Principal pantalla_Principal = new Pantalla_Principal();
                pantalla_Principal.Show();
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
