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
    public partial class Ignacio : Form
    {
        Button boton;
        bool desaparece;
        bool primerClick = true;

        public Ignacio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (primerClick == false) { this.boton.Visible = false; }
            
            
            Random random = new Random();

            int top = random.Next(0, 400);
            int left = random.Next(0, 400);

            boton = new Button();
            boton.Left = left;
            boton.Top = top;
               
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 0;
            this.boton.Text = "Toma ya!";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.button1_Click);
            
            this.Controls.Add(boton);

            button1.Visible = false;

            primerClick = false;

        }
    }
}
