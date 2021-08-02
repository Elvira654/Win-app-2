using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Izaberi_Click(object sender, EventArgs e)
        {
            if (Programiranje.Checked)
            {
                MessageBox.Show("Odabrali ste: programiranje");
            }
            if (Web_programiranje.Checked)
            {
                MessageBox.Show("Odabrali ste: web programiranje");
            }
            if (Dig_tehnika.Checked)
            {
                MessageBox.Show("Odabrali ste: Digitalnu tehniku");
            }
                

        }

       

       
    }
}
