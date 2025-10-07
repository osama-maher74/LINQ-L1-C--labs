using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__L5_WinForm2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Graphics grx = e.Graphics;
            grx.FillEllipse(Brushes.Red, x, 40, 50, 50);
        }
        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                start.Text = "stop";
            else
                start.Text = "start";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;

            this.Invalidate();
            
           Text = x.ToString();
            if (x == 815)
                x = 0;
        }
    }
}
