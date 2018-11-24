using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        
        public Form1()
        {
          
            InitializeComponent();
            textBox3.Hide();
            textBox4.Hide();
            button4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            button5.Hide();
            button6.Hide();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


          
          
        }







        int score;


    

        private void button2_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;
            if (answer == "Panda")
            {
                score++;
                textBox1.Text = "Correct Answer";
            }
            else
            {
                textBox1.Text = "Wrong Answer";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox1.Hide();
            button3.Hide();
            textBox3.Show();
            textBox4.Show();
            button4.Show();
            button5.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string answer1 = textBox4.Text;
            if (answer1 == "Carrots")
            {
                score++;
                textBox4.Text = "Correct Answer";
            }
            else
            {
                textBox4.Text = "Wrong Answer";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show(score.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Hide();
            textBox4.Hide();
            button4.Hide();
            button5.Hide();
            textBox5.Show();
            textBox6.Show();
            button6.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string answer2 = textBox6.Text;
            if (answer2 == "4")
            {
                score++;
                textBox6.Text = "Correct Answer";
            }
            else
            {
                textBox6.Text = "Wrong Answer";
            }
        }
    }

}
