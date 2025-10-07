using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__L5_WinForm2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Users u1=new Users();

            u1.Email = txtEmail.Text;
            u1.Pasword = txtPasword.Text;

            //if (MessageBox.Show(u1.ToString(), "Loged in", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    Text = u1.ToString();

            MessageBox.Show(u1.ToString(), "Loged in", MessageBoxButtons.OKCancel);
        }
    }
}

