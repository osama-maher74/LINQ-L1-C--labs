namespace c__l5_WForm
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
            close = new Button();
            go = new Button();
            txtname = new TextBox();
            SuspendLayout();
            // 
            // close
            // 
            close.Location = new Point(390, 148);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 0;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += button1_Click;
            // 
            // go
            // 
            go.Location = new Point(250, 148);
            go.Name = "go";
            go.Size = new Size(94, 29);
            go.TabIndex = 1;
            go.Text = "go";
            go.UseVisualStyleBackColor = true;
            go.Click += go_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(250, 96);
            txtname.Name = "txtname";
            txtname.Size = new Size(234, 27);
            txtname.TabIndex = 2;
            txtname.Text = "\r\n";
            txtname.TextAlign = HorizontalAlignment.Center;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(txtname);
            Controls.Add(go);
            Controls.Add(close);
            Name = "Form1";
            Text = "Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close;
        private Button go;
        private TextBox txtname;
    }
}
