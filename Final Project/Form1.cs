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
        Label[] treeArray;
        Random rand = new Random();


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

            myArray = new PictureBox[2] { pictureBox1, pictureBox2};
            int num = rand.Next(0, myArray.Length);
            treeArray = new Label[20] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
            //hi stof

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

                    foreach (Label border in treeArray)
                    {
                        if (border.Bounds.IntersectsWith(pictureBox1.Bounds)&& e.KeyCode == Keys.A)
                        {
                            pictureBox1.Left += 10;


                        }
                    }

                }
                else if (e.KeyCode == Keys.D)
                {
                    //move the insec father from left

                    if (pictureBox1.Location.X < this.Width - pictureBox1.Width)
                    {
                        pictureBox1.Left += 10;
                    }
                    foreach (Label border in treeArray)
                    {
                        if (border.Bounds.IntersectsWith(pictureBox1.Bounds) && e.KeyCode == Keys.D)
                        {
                            pictureBox1.Left -= 10;


                        }
                    }

                }
                else if (e.KeyCode == Keys.W)
                {
                    //move the insec father from left
                    pictureBox1.Top -= 10;

                    foreach (Label border in treeArray)
                    {
                        if (border.Bounds.IntersectsWith(pictureBox1.Bounds) && e.KeyCode == Keys.W)
                        {
                            pictureBox1.Top += 10;


                        }
                    }

                }
                else if (e.KeyCode == Keys.S)
                {
                    //move the insec father from left
                    pictureBox1.Top += 10;

                    foreach (Label border in treeArray)
                    {
                        if (border.Bounds.IntersectsWith(pictureBox1.Bounds) && e.KeyCode == Keys.S)
                        {
                            pictureBox1.Top -= 10;


                        }
                    }

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
                    if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
                    {

                    }
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
