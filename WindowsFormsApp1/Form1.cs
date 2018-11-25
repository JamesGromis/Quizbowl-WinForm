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
            Q4Qbox.Hide();
            Q4ABox.Hide();
            Q4SubmitButton.Hide();
            Q3NextQButton.Hide();
            Q4NextQButton.Hide();
            Q5QBox.Hide();
            Q5ABox.Hide();
            Q5SubmitButton.Hide();
            
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
            if (answer == "Black Holes")
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
            if (answer1 == "John Calvin​")
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
            Q3NextQButton.Show();
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
            if (answer2 == "lambs")
            {
                score++;
                textBox6.Text = "Correct Answer";
            }
            else
            {
                textBox6.Text = "Wrong Answer";
            }
        }

        private void nextquestion2_Click(object sender, EventArgs e)
        {

        }

        private void Q4Qbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q4ABox_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Q4SubmitButton_Click(object sender, EventArgs e)
        {
            string answer3 = Q4ABox.Text;
            if(answer3== "Neville Chamberlain")
            {
                score++;
                Q4ABox.Text = "Correct Answer";
            }
            else
            {
                Q4ABox.Text = "Wrong Answer";
            }
        }

        private void Q3NextQButton_Click(object sender, EventArgs e)
        {
            textBox5.Hide();
            textBox6.Hide();
            button6.Hide();
            Q3NextQButton.Hide();
            Q4Qbox.Show();
            Q4ABox.Show();
            Q4SubmitButton.Show();
            Q4NextQButton.Show();
        }

        private void Q4NextQButton_Click(object sender, EventArgs e)
        {
            Q4Qbox.Hide();
            Q4ABox.Hide();
            Q4SubmitButton.Hide();
            Q4NextQButton.Hide();
            Q5QBox.Show();
            Q5ABox.Show();
            Q5SubmitButton.Show();

        }

        private void Q5SubmitButton_Click(object sender, EventArgs e)
        {
            string answer4 = Q5ABox.Text;
            if(answer4 == "Geoffrey Chaucer")
            {
                score++;
                Q5ABox.Text = "Correct Answer";

            }
            else
            {
                Q5ABox.Text = "Wrong Answer";
            }
        }

        private void Q5ABox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Q5QBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
