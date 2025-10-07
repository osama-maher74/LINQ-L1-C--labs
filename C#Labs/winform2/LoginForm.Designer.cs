namespace C__L5_WinForm2
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            submit = new Button();
            txtEmail = new TextBox();
            txtPasword = new TextBox();
            label1 = new Label();
            pasword = new Label();
            SuspendLayout();
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaption;
            submit.Location = new Point(357, 275);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 0;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(302, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPasword
            // 
            txtPasword.Location = new Point(302, 223);
            txtPasword.Name = "txtPasword";
            txtPasword.Size = new Size(211, 27);
            txtPasword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(373, 99);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // pasword
            // 
            pasword.AutoSize = true;
            pasword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pasword.Location = new Point(359, 181);
            pasword.Name = "pasword";
            pasword.Size = new Size(92, 28);
            pasword.TabIndex = 4;
            pasword.Text = "pasword";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pasword);
            Controls.Add(label1);
            Controls.Add(txtPasword);
            Controls.Add(txtEmail);
            Controls.Add(submit);
            ForeColor = Color.Azure;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private TextBox txtEmail;
        private TextBox txtPasword;
        private Label label1;
        private Label pasword;
    }
}