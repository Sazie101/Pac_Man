using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frmPacman form2 = new frmPacman();
            form2.Show();
            this.Hide();
            timer2.Enabled = false;
        }
    }
}
