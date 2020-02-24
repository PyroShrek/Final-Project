using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            pictureBox2.Visible = false;
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
            pictureBox1.Image = Properties.Resources.open_ball;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Top -= 10;
            pictureBox2.Top += 10;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            label3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox4.Image = Properties.Resources.snivy;
            pictureBox2.Image = Properties.Resources.open_ball;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox1.Image = Properties.Resources.pokeball;
            pictureBox2.Image = Properties.Resources.pokeball;
            pictureBox3.Image = Properties.Resources.pokeball;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox6.Visible = true;
            label4.Visible = true;
            pictureBox3.Image = Properties.Resources.open_ball;
            button1.Visible = true;
            button2.Visible = true;
        }
    }
}
