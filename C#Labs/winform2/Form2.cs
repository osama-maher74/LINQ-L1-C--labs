﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

            Graphics grx = CreateGraphics();

            grx.FillEllipse(Brushes.Red,e.X-25,e.Y-25,50,50);

        }
    }
}
