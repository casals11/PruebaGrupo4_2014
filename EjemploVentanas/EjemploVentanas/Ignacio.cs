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
        public Ignacio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int top = 50;
            int left = 100;

                Button button = new Button();
                button.Top = top;
                this.Controls.Add(button);

                button1.Visible = false;
        }
    }
}
