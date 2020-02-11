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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] myArray;
        Random rand = new Random();


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            myArray = new PictureBox[2] { pictureBox1, pictureBox2};
            int num = rand.Next(0, myArray.Length);
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            {
                
                if (e.KeyCode == Keys.A)
                {

                    //move hand closer to the left  wall
                    if (pictureBox1.Location.X > 0)
                    {
                        pictureBox1.Left -= 10;
                    }

                }
                else if (e.KeyCode == Keys.D)
                {
                    //move the insec father from left

                    if (pictureBox1.Location.X < this.Width - pictureBox1.Width)
                    {
                        pictureBox1.Left += 10;
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    //move the insec father from left
                    pictureBox1.Top -= 10;
                }
                else if (e.KeyCode == Keys.S)
                {
                    //move the insec father from left
                    pictureBox1.Top += 10;
                }
                /*foreach (Label dog in myArray)
                {
                    if (pictureBox1.Bounds.IntersectsWith(dog.Bounds))
                    {
                        dog.BackColor = Color.Red;
                    }
                    else
                    {
                        dog.BackColor = Color.White;
                    }
                }*/

                foreach (PictureBox pokemon in myArray)
                {
                    if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                    {
                        MessageBox.Show("Let me know when your team is a little stronger.");
                        
                    }

                }
            }
        }
    }
}
