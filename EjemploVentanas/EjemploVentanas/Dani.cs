//
//Daniel Casals
//1º de DAM
//Programación
//


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
    public partial class Dani : Form
    {

        bool rojas = true;
        //Los contadores de cada columna
        int contador1 = 0;
        int contador2 = 0;
        int contador3 = 0;
        int contador4 = 0;
        int contador5 = 0;
        int contador6 = 0;
        int contador7 = 0;
        int contador8 = 0;
        int contador9 = 0;
        int contador10 = 0;

        public Dani()
        {
            InitializeComponent();
        }

        //Cambia el valor del booleano rojas. Si es verdadero es el turno de las rojas, si es falso, el de las amarillas.
        //Avisa en los labels de la derecha de quién es el turno.
        public void cambiaTurno() {
            if (rojas)
            {
                rojas = false;
                label5.Text = "";
                label6.Text = "Turno Amarillas";
            }
            else {
                rojas = true;
                label6.Text = "";
                label5.Text = "Turno Rojas";
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (contador1 < 8)
            {
                pictureBox1.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (contador1 != 9)
            {
                pictureBox1.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            if (contador2 < 9)
            {
                pictureBox10.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            if (contador2 != 9)
            {
                pictureBox10.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            if (contador3 < 9)
            {
                pictureBox19.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            if (contador3 != 9)
            {
                pictureBox19.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {
            if (contador4 < 9)
            {
                pictureBox28.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            if (contador4 != 9)
            {
                pictureBox28.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox37_MouseEnter(object sender, EventArgs e)
        {
            if (contador5 < 9)
            {
                pictureBox37.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox37_MouseLeave(object sender, EventArgs e)
        {
            if (contador5 != 9)
            {
                pictureBox37.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox46_MouseEnter(object sender, EventArgs e)
        {
            if (contador6 < 9)
            {
                pictureBox46.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox46_MouseLeave(object sender, EventArgs e)
        {
            if (contador6 != 9)
            {
                pictureBox46.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox55_MouseEnter(object sender, EventArgs e)
        {
            if (contador7 < 9)
            {
                pictureBox55.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox55_MouseLeave(object sender, EventArgs e)
        {
            if (contador7 != 9)
            {
                pictureBox55.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox64_MouseEnter(object sender, EventArgs e)
        {
            if (contador8 < 9)
            {
                pictureBox64.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox64_MouseLeave(object sender, EventArgs e)
        {
            if (contador8 != 9)
            {
                pictureBox64.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox73_MouseEnter(object sender, EventArgs e)
        {
            if (contador9 < 9)
            {
                pictureBox73.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox73_MouseLeave(object sender, EventArgs e)
        {
            if (contador9 != 9)
            {
                pictureBox73.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si hay sitio en la columna, al pasar por la primera casilla, te muestra una flecha.
        //Al salir de la primera casilla vuelve a ponerla vacía en el caso de que no tenga una ficha.
        private void pictureBox82_MouseEnter(object sender, EventArgs e)
        {
            if (contador10 < 9)
            {
                pictureBox82.Image = EjemploVentanas.Properties.Resources.conecta4flecha;
            }
        }

        private void pictureBox82_MouseLeave(object sender, EventArgs e)
        {
            if (contador10 != 9)
            {
                pictureBox82.Image = EjemploVentanas.Properties.Resources.conecta4;
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador1 == 0)
                {
                    pictureBox9.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 1)
                {
                    pictureBox8.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 2)
                {
                    pictureBox7.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 3)
                {
                    pictureBox6.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 4)
                {
                    pictureBox5.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 5)
                {
                    pictureBox4.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 6)
                {
                    pictureBox3.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 7)
                {
                    pictureBox2.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 8)
                {
                    pictureBox1.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador1 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else {
                if (contador1 == 0)
                {
                    pictureBox9.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 1)
                {
                    pictureBox8.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 2)
                {
                    pictureBox7.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 3)
                {
                    pictureBox6.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 4)
                {
                    pictureBox5.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 5)
                {
                    pictureBox4.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 6)
                {
                    pictureBox3.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 7)
                {
                    pictureBox2.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                }
                else if (contador1 == 8)
                {
                    pictureBox1.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador1 += 1;
                    cambiaTurno();
                } 
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador2 == 0)
                {
                    pictureBox18.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 1)
                {
                    pictureBox17.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 2)
                {
                    pictureBox16.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 3)
                {
                    pictureBox15.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 4)
                {
                    pictureBox14.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 5)
                {
                    pictureBox13.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 6)
                {
                    pictureBox12.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 7)
                {
                    pictureBox11.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 8)
                {
                    pictureBox10.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador2 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador2 == 0)
                {
                    pictureBox18.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 1)
                {
                    pictureBox17.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 2)
                {
                    pictureBox16.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 3)
                {
                    pictureBox15.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 4)
                {
                    pictureBox14.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 5)
                {
                    pictureBox13.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 6)
                {
                    pictureBox12.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 7)
                {
                    pictureBox11.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
                else if (contador2 == 8)
                {
                    pictureBox10.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador2 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador3 == 0)
                {
                    pictureBox27.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 1)
                {
                    pictureBox26.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 2)
                {
                    pictureBox25.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 3)
                {
                    pictureBox24.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 4)
                {
                    pictureBox23.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 5)
                {
                    pictureBox22.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 6)
                {
                    pictureBox21.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 7)
                {
                    pictureBox20.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 8)
                {
                    pictureBox19.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador3 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador3 == 0)
                {
                    pictureBox27.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 1)
                {
                    pictureBox26.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 2)
                {
                    pictureBox25.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 3)
                {
                    pictureBox24.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 4)
                {
                    pictureBox23.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 5)
                {
                    pictureBox22.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 6)
                {
                    pictureBox21.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 7)
                {
                    pictureBox20.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
                else if (contador3 == 8)
                {
                    pictureBox19.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador3 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador4 == 0)
                {
                    pictureBox36.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 1)
                {
                    pictureBox35.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 2)
                {
                    pictureBox34.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 3)
                {
                    pictureBox33.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 4)
                {
                    pictureBox32.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 5)
                {
                    pictureBox31.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 6)
                {
                    pictureBox30.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 7)
                {
                    pictureBox29.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 8)
                {
                    pictureBox28.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador4 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador4 == 0)
                {
                    pictureBox36.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 1)
                {
                    pictureBox35.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 2)
                {
                    pictureBox34.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 3)
                {
                    pictureBox33.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 4)
                {
                    pictureBox32.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 5)
                {
                    pictureBox31.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 6)
                {
                    pictureBox30.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 7)
                {
                    pictureBox29.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
                else if (contador4 == 8)
                {
                    pictureBox28.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador4 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador5 == 0)
                {
                    pictureBox45.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 1)
                {
                    pictureBox44.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 2)
                {
                    pictureBox43.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 3)
                {
                    pictureBox42.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 4)
                {
                    pictureBox41.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 5)
                {
                    pictureBox40.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 6)
                {
                    pictureBox39.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 7)
                {
                    pictureBox38.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 8)
                {
                    pictureBox37.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador5 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador5 == 0)
                {
                    pictureBox45.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 1)
                {
                    pictureBox44.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 2)
                {
                    pictureBox43.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 3)
                {
                    pictureBox42.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 4)
                {
                    pictureBox41.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 5)
                {
                    pictureBox40.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 6)
                {
                    pictureBox39.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 7)
                {
                    pictureBox38.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
                else if (contador5 == 8)
                {
                    pictureBox37.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador5 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox46_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador6 == 0)
                {
                    pictureBox54.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 1)
                {
                    pictureBox53.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 2)
                {
                    pictureBox52.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 3)
                {
                    pictureBox51.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 4)
                {
                    pictureBox50.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 5)
                {
                    pictureBox49.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 6)
                {
                    pictureBox48.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 7)
                {
                    pictureBox47.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 8)
                {
                    pictureBox46.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador6 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador6 == 0)
                {
                    pictureBox54.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 1)
                {
                    pictureBox53.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 2)
                {
                    pictureBox52.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 3)
                {
                    pictureBox51.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 4)
                {
                    pictureBox50.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 5)
                {
                    pictureBox49.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 6)
                {
                    pictureBox48.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 7)
                {
                    pictureBox47.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
                else if (contador6 == 8)
                {
                    pictureBox46.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador6 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox55_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador7 == 0)
                {
                    pictureBox63.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 1)
                {
                    pictureBox62.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 2)
                {
                    pictureBox61.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 3)
                {
                    pictureBox60.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 4)
                {
                    pictureBox59.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 5)
                {
                    pictureBox58.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 6)
                {
                    pictureBox57.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 7)
                {
                    pictureBox56.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 8)
                {
                    pictureBox55.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador7 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador7 == 0)
                {
                    pictureBox63.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 1)
                {
                    pictureBox62.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 2)
                {
                    pictureBox61.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 3)
                {
                    pictureBox60.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 4)
                {
                    pictureBox59.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 5)
                {
                    pictureBox58.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 6)
                {
                    pictureBox57.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 7)
                {
                    pictureBox56.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
                else if (contador7 == 8)
                {
                    pictureBox55.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador7 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox64_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador8 == 0)
                {
                    pictureBox72.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 1)
                {
                    pictureBox71.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 2)
                {
                    pictureBox70.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 3)
                {
                    pictureBox69.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 4)
                {
                    pictureBox68.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 5)
                {
                    pictureBox67.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 6)
                {
                    pictureBox66.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 7)
                {
                    pictureBox65.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 8)
                {
                    pictureBox64.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador8 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador8 == 0)
                {
                    pictureBox72.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 1)
                {
                    pictureBox71.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 2)
                {
                    pictureBox70.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 3)
                {
                    pictureBox69.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 4)
                {
                    pictureBox68.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 5)
                {
                    pictureBox67.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 6)
                {
                    pictureBox66.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 7)
                {
                    pictureBox65.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
                else if (contador8 == 8)
                {
                    pictureBox64.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador8 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox73_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador9 == 0)
                {
                    pictureBox81.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 1)
                {
                    pictureBox80.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 2)
                {
                    pictureBox79.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 3)
                {
                    pictureBox78.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 4)
                {
                    pictureBox77.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 5)
                {
                    pictureBox76.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 6)
                {
                    pictureBox75.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 7)
                {
                    pictureBox74.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 8)
                {
                    pictureBox73.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador9 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador9 == 0)
                {
                    pictureBox81.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 1)
                {
                    pictureBox80.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 2)
                {
                    pictureBox79.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 3)
                {
                    pictureBox78.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 4)
                {
                    pictureBox77.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 5)
                {
                    pictureBox76.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 6)
                {
                    pictureBox75.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 7)
                {
                    pictureBox74.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
                else if (contador9 == 8)
                {
                    pictureBox73.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador9 += 1;
                    cambiaTurno();
                }
            }
        }

        //Si pulsas en la primera casilla comprueba si hay sitio en la columna y coloca la ficha en caso de haberlo.
        private void pictureBox82_Click(object sender, EventArgs e)
        {
            if (rojas)  //Pone la ficha de color rojo.
            {
                if (contador10 == 0)
                {
                    pictureBox90.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 1)
                {
                    pictureBox89.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 2)
                {
                    pictureBox88.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 3)
                {
                    pictureBox87.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 4)
                {
                    pictureBox86.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 5)
                {
                    pictureBox85.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 6)
                {
                    pictureBox84.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 7)
                {
                    pictureBox83.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 8)
                {
                    pictureBox82.Image = EjemploVentanas.Properties.Resources.conecta4rojo;
                    contador10 += 1;
                    cambiaTurno();
                }
            }
            //Pone la ficha de color amarillo.
            else
            {
                if (contador10 == 0)
                {
                    pictureBox90.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 1)
                {
                    pictureBox89.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 2)
                {
                    pictureBox88.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 3)
                {
                    pictureBox87.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 4)
                {
                    pictureBox86.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 5)
                {
                    pictureBox85.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 6)
                {
                    pictureBox84.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 7)
                {
                    pictureBox83.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
                else if (contador10 == 8)
                {
                    pictureBox82.Image = EjemploVentanas.Properties.Resources.conecta4amarillo;
                    contador10 += 1;
                    cambiaTurno();
                }
            }
        }



    }
}
