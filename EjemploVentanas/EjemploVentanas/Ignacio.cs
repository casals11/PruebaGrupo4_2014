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
        int nombre = 1;

        public Ignacio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!primerClick) { this.boton.Visible = false; }
            
            
            Random random = new Random();

            int top = random.Next(0, 400);
            int left = random.Next(0, 500);
            
            boton = new Button();
            boton.Left = left;
            boton.Top = top;
               
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(120, 23);
            this.boton.TabIndex = 1;
            switch (nombre)
            {
                default:
                    this.boton.Text = "¡Feliz verano!";
                    nombre++;
                    break;
                case 1:
                    this.boton.Text = "Toma ya!";
                    nombre++;
                    break;
                case 2:
                    this.boton.Text = "No me pulses";
                    nombre++;
                    break;
                case 3:
                    this.boton.Text = "¿Por que pulsas?";
                    nombre++;
                    break;
                case 4:
                    this.boton.Text = "Esta bien";
                    nombre++;
                    break;
                case 5:
                    this.boton.Text = "Para ya";
                    nombre++;
                    break;
                case 6:
                    this.boton.Text = "¡Que pares!";
                    nombre++;
                    break;
                case 7:
                    this.boton.Text = "Cada vez que pulsas";
                    nombre++;
                    break;
                case 8:
                    this.boton.Text = "Muere un gatito";
                    nombre++;
                    break;
                case 9:
                    this.boton.Text = "pobres gatos";
                    nombre++;
                    break;
                case 10:
                    this.boton.Text = "Haz algo útil";
                    nombre++;
                    break;
                case 11:
                    this.boton.Text = "Pierdes el tiempo";
                    nombre++;
                    break;
                case 12:
                    this.boton.Text = "Nos aprobarás, no?";
                    nombre++;
                    break;
                case 13:
                    this.boton.Text = "Como mola el fondo";
                    nombre++;
                    break;
                case 14:
                    this.boton.Text = "Veo que te gusta";
                    nombre++;
                    break;
                case 15:
                    this.boton.Text = "No vale usar teclado";
                    nombre++;
                    break;
                case 16:
                    this.boton.Text = "Si lo sabré yo";
                    nombre++;
                    break;
                case 17:
                    this.boton.Text = "Corrije a otra persona";
                    nombre++;
                    break;
                case 18:
                    this.boton.Text = "En serio";
                    nombre++;
                    break;
                case 19:
                    this.boton.Text = "No hay más que ver";
                    nombre++;
                    break;
            }
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.button1_Click);
            
            this.Controls.Add(boton);



            button1.Visible = false;

            primerClick = false;

        }
    }
}
