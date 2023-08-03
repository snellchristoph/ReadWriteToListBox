namespace _315_proj_sol1
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
            txtText = new TextBox();
            btnRead = new Button();
            listBox1 = new ListBox();
            btnWrite = new Button();
            SuspendLayout();
            // 
            // txtText
            // 
            txtText.Location = new Point(78, 126);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(397, 425);
            txtText.TabIndex = 0;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(502, 163);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(235, 113);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(587, 307);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(234, 264);
            listBox1.TabIndex = 3;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(768, 163);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(235, 113);
            btnWrite.TabIndex = 4;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 626);
            Controls.Add(btnWrite);
            Controls.Add(listBox1);
            Controls.Add(btnRead);
            Controls.Add(txtText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtText;
        private Button btnRead;
        private ListBox listBox1;
        private Button btnWrite;
    }
}