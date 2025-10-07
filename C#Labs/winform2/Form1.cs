namespace C__L5_WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(((Student)cmbStudents.SelectedItem).Name.ToString());
            //MessageBox.Show(cmbDepartments.SelectedItem.ToString());

            Student s1 = new Student();
            s1.ID = int.Parse(txtId.Text);
            s1.Name = txtName.Text;
            s1.Age = int.Parse(txtAge.Text);

            //if (MessageBox.Show(s1.ToString(), "Name", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //    Text = s1.ToString();

            txtList.Text = s1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        List<Student> students = new List<Student>
        {
            new Student { ID = 101, Name = "Ahmed", Age = 22 },
            new Student { ID = 102, Name = "Fatima", Age = 20 },
            new Student { ID = 103, Name = "Mohamed", Age = 23 },
            new Student { ID = 104, Name = "Ali", Age = 21 },
            new Student { ID = 105, Name = "Zainab", Age = 19 },
            new Student { ID = 106, Name = "Khaled", Age = 22 },
            new Student { ID = 107, Name = "Sara", Age = 24 },
            new Student { ID = 108, Name = "Youssef", Age = 20 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStudents.DataSource = students;
            cmbStudents.ValueMember= "ID";
            cmbStudents.DisplayMember= "Name";

        }
    }
}
