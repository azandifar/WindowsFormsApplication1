namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.RedScrollBar = new System.Windows.Forms.HScrollBar();
            this.GreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.BlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RedScrollBar
            // 
            this.RedScrollBar.Location = new System.Drawing.Point(53, 26);
            this.RedScrollBar.Maximum = 255;
            this.RedScrollBar.Name = "RedScrollBar";
            this.RedScrollBar.Size = new System.Drawing.Size(297, 21);
            this.RedScrollBar.TabIndex = 100;
            this.RedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedScrollBar_Scroll);
            // 
            // GreenScrollBar
            // 
            this.GreenScrollBar.Location = new System.Drawing.Point(53, 47);
            this.GreenScrollBar.Maximum = 255;
            this.GreenScrollBar.Name = "GreenScrollBar";
            this.GreenScrollBar.Size = new System.Drawing.Size(297, 21);
            this.GreenScrollBar.TabIndex = 1;
            // 
            // BlueScrollBar
            // 
            this.BlueScrollBar.Location = new System.Drawing.Point(53, 68);
            this.BlueScrollBar.Maximum = 255;
            this.BlueScrollBar.Name = "BlueScrollBar";
            this.BlueScrollBar.Size = new System.Drawing.Size(297, 21);
            this.BlueScrollBar.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 22);
            this.textBox1.TabIndex = 101;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 22);
            this.textBox2.TabIndex = 102;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_All);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 22);
            this.textBox3.TabIndex = 103;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(297, 22);
            this.textBox4.TabIndex = 104;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(53, 221);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(297, 22);
            this.textBox5.TabIndex = 105;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(53, 249);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(297, 22);
            this.textBox6.TabIndex = 106;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 501);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BlueScrollBar);
            this.Controls.Add(this.GreenScrollBar);
            this.Controls.Add(this.RedScrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar RedScrollBar;
        private System.Windows.Forms.HScrollBar GreenScrollBar;
        private System.Windows.Forms.HScrollBar BlueScrollBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

