using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
namespace SLTMAX
{
    public partial class CSDA : Form
    {
        public CSDA()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutApp = new About();
            AboutApp.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Name: " + label5.Text + "\nAddress: " + label6.Text + "\nTelephone No: " + label7.Text);
        }

        private void CSDA_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void CSDA_Activated(object sender, EventArgs e)
        {
            for (double i = 0; i < 1; )
            {
                this.Opacity = i;
                i = i + 0.01;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = new string[3];

            if (textBox1.Text.Length != 6 )
            {
                MessageBox.Show("Please enter telephone number properly.");
            }
            else
            {
                if (comboBox1.Text == ""  )            
                {
                    MessageBox.Show("Please select a code number.");
                }
                else
                {
                    s = DB.getDetail(comboBox1.Text, textBox1.Text);
                    label5.Text = s[0];
                    label6.Text = s[1];
                    label7.Text = s[2];
                }
            }
        }

        private void CSDA_Load(object sender, EventArgs e)
        {

        }
    }
}