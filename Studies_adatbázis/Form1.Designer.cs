namespace Studies_adatbázis
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
            panel1 = new Panel();
            buttonControl1 = new Button();
            buttonControl2 = new Button();
            buttonControl3 = new Button();
            buttonControl4 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Location = new Point(124, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 416);
            panel1.TabIndex = 0;
            // 
            // buttonControl1
            // 
            buttonControl1.Location = new Point(12, 22);
            buttonControl1.Name = "buttonControl1";
            buttonControl1.Size = new Size(107, 57);
            buttonControl1.TabIndex = 1;
            buttonControl1.Text = "User Control1";
            buttonControl1.UseVisualStyleBackColor = true;
            buttonControl1.Click += buttonControl1_Click;
            // 
            // buttonControl2
            // 
            buttonControl2.Location = new Point(12, 85);
            buttonControl2.Name = "buttonControl2";
            buttonControl2.Size = new Size(106, 59);
            buttonControl2.TabIndex = 2;
            buttonControl2.Text = "User Control2";
            buttonControl2.UseVisualStyleBackColor = true;
            buttonControl2.Click += buttonControl2_Click;
            // 
            // buttonControl3
            // 
            buttonControl3.Location = new Point(12, 150);
            buttonControl3.Name = "buttonControl3";
            buttonControl3.Size = new Size(106, 57);
            buttonControl3.TabIndex = 3;
            buttonControl3.Text = "User Control3";
            buttonControl3.UseVisualStyleBackColor = true;
            buttonControl3.Click += buttonControl3_Click;
            // 
            // buttonControl4
            // 
            buttonControl4.Location = new Point(13, 213);
            buttonControl4.Name = "buttonControl4";
            buttonControl4.Size = new Size(105, 55);
            buttonControl4.TabIndex = 4;
            buttonControl4.Text = "User Control4";
            buttonControl4.UseVisualStyleBackColor = true;
            buttonControl4.Click += buttonControl4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonControl4);
            Controls.Add(buttonControl3);
            Controls.Add(buttonControl2);
            Controls.Add(buttonControl1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonControl1;
        private Button buttonControl2;
        private Button buttonControl3;
        private Button buttonControl4;
    }
}