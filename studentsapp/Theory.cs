using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentsapp
{
    public partial class Theory : Form
    {
        int number = 0;
             
        int mult;
        string message;
        public Theory()
        {
            InitializeComponent();
           
            
        }

        private void Theory_Load(object sender, EventArgs e)
        {
         

        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked) {
                textBox1.Clear();
                
                
                message +=message;
                for(int i=0; i<=10; i++)
                {
                    mult = i * number;
                    message = i.ToString() + " * " + number.ToString() + " = " + mult.ToString() + Environment.NewLine;
                    if (i < 11)
                    {
                        textBox1.AppendText(message);
                    }
                }
             
            }
          
        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            number = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
         
            number = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            number = 3;


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            number = 4;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            number = 5;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            number = 6;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            number = 7;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            number = 8;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            number = 9;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            number = 10;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Examination examination = new Examination();
            examination.Show();
        }
    }
}
