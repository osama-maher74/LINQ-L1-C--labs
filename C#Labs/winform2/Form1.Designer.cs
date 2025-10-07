namespace C__L5_WinForm2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            btnClose = new Button();
            btnShow = new Button();
            txtName = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbDepartments = new ComboBox();
            cmbStudents = new ComboBox();
            txtList = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(193, 69);
            txtId.Name = "txtId";
            txtId.Size = new Size(271, 27);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(370, 232);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(193, 232);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show\r\n";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 27);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(193, 174);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(271, 27);
            txtAge.TabIndex = 4;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 72);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 125);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 177);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // cmbDepartments
            // 
            cmbDepartments.FormattingEnabled = true;
            cmbDepartments.Items.AddRange(new object[] { ".NET", "Front", "BI", "MG" });
            cmbDepartments.Location = new Point(495, 72);
            cmbDepartments.Name = "cmbDepartments";
            cmbDepartments.Size = new Size(271, 28);
            cmbDepartments.TabIndex = 8;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Items.AddRange(new object[] { ".NET", "Front", "BI", "MG" });
            cmbStudents.Location = new Point(495, 125);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(271, 28);
            cmbStudents.TabIndex = 9;
            // 
            // txtList
            // 
            txtList.Location = new Point(495, 174);
            txtList.Name = "txtList";
            txtList.Size = new Size(271, 27);
            txtList.TabIndex = 10;
            txtList.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(884, 405);
            Controls.Add(txtList);
            Controls.Add(cmbStudents);
            Controls.Add(cmbDepartments);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(btnShow);
            Controls.Add(btnClose);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Button btnClose;
        private Button btnShow;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDepartments;
        private ComboBox cmbStudents;
        private TextBox txtList;
    }
}
