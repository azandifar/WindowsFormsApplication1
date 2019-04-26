using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Hello Amir");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_MouseCaptureChanged_All(object sender, EventArgs e)
        {
//            System.Windows.Forms.
        }

        private void button_Click_For_All(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Hello Would!");
//            if this.button1.Name
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_MouseEnter_For_All(object sender, EventArgs e)
        {
            System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Red;
            }
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
//            System.Windows.Forms.Button.BackColor = Color.Purple;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button currentButton = (System.Windows.Forms.Button)sender;
            currentButton.BackColor = Color.Beige;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox currentTextbox = sender as System.Windows.Forms.TextBox;
            if (currentTextbox!=null)
            {
                currentTextbox.Font = new Font(currentTextbox.Font, FontStyle.Bold);
            }
        }

        private void hello(object sender, EventArgs e)
        {

        }

        private void RedScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
 //           int red = RedScrollBar_Scroll.Value;
 //           int green = GreenScrollBar_Scroll.Value;
 //           int blue = BlueScrollBar_Scroll.Value;
 //           Color.FromArgb = (red,green,blue);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress_All(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case '0':
                case '1':
                    {
                        break;
                    }
                default:
                    {
                        e.Handled = true;
                        break;
                    }
            }

        }
    }
}
