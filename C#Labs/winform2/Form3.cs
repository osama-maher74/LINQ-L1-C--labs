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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {

            Graphics grx= CreateGraphics();
            if (e.Button == MouseButtons.Left)
                grx.FillEllipse(Brushes.Red, e.X - 20, e.Y - 20, 40, 40);
            else if (e.Button == MouseButtons.Right)
            {
                SolidBrush b = new SolidBrush(BackColor);
                grx.FillEllipse(b, e.X - 20, e.Y - 20, 40, 40);
            
            
            }

        }
    }
}
