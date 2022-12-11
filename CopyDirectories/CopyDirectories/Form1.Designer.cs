namespace CopyDirectories
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.srcDirectory = new System.Windows.Forms.TextBox();
            this.destionationDirectory = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCopy.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnCopy.Location = new System.Drawing.Point(352, 196);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 43);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // srcDirectory
            // 
            this.srcDirectory.Location = new System.Drawing.Point(221, 70);
            this.srcDirectory.Name = "srcDirectory";
            this.srcDirectory.Size = new System.Drawing.Size(345, 23);
            this.srcDirectory.TabIndex = 1;
            this.srcDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.srcDirectory.TextChanged += new System.EventHandler(this.srcDirectory_TextChanged);
            // 
            // destionationDirectory
            // 
            this.destionationDirectory.Location = new System.Drawing.Point(221, 134);
            this.destionationDirectory.Name = "destionationDirectory";
            this.destionationDirectory.Size = new System.Drawing.Size(345, 23);
            this.destionationDirectory.TabIndex = 2;
            this.destionationDirectory.TextChanged += new System.EventHandler(this.destionationDirectory_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(92, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "source:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(92, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Destination:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.destionationDirectory);
            this.Controls.Add(this.srcDirectory);
            this.Controls.Add(this.btnCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCopy;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private TextBox srcDirectory;
        private TextBox destionationDirectory;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}