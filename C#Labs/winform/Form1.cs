namespace c__l5_WForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "new form";


            go.Click += (sender, e) => Text = txtname.Text;
            //Button b1 = new Button() { Text = "show" };

            //b1.Width = 100;
            //b1.Height = 100;
            //b1.Location = new Point(100, 100);
            //Controls.Add(b1);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void go_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(txtname.Text, "Name", MessageBoxButtons.OKCancel);

            if (result != DialogResult.Cancel)
            {
                this.Text = txtname.Text;
            }


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
