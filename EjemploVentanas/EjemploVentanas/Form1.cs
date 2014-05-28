using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploVentanas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
            
        }

        //Abre el windows form de Diego
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Diego().ShowDialog();
        }

        //La imagen del pictureBox cambia al introducir el ratón, mostrando el dibujo de cada uno
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
            pictureBox1.Image = EjemploVentanas.Properties.Resources.Diego;
        }

        //El pictureBox vuelve a mostrar la silueta de cada uno con su nombre cuando el ratón sale
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = EjemploVentanas.Properties.Resources.SiluetaDiego;
        }

        //Abre el windows form de Ignacio
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Ignacio().ShowDialog();
        }

        //La imagen del pictureBox cambia al introducir el ratón, mostrando el dibujo de cada uno
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = EjemploVentanas.Properties.Resources.Ignacio;
        }

        //El pictureBox vuelve a mostrar la silueta de cada uno con su nombre cuando el ratón sale
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = EjemploVentanas.Properties.Resources.SiluetaIgnacio;
        }

        //Abre el windows form de Dani
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Dani().ShowDialog();
        }

        //La imagen del pictureBox cambia al introducir el ratón, mostrando el dibujo de cada uno
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = EjemploVentanas.Properties.Resources.dani;
        }

        //El pictureBox vuelve a mostrar la silueta de cada uno con su nombre cuando el ratón sale
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = EjemploVentanas.Properties.Resources.Siluetadani;
        }
    }
}
