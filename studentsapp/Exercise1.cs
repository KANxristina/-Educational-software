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
    public partial class Exercise1 : Form
    {
        int randomnum1;
        int randomnum2;
        Random randomnumber;
        int result;
        int userresult;
      

        public Exercise1()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomnumber = new Random();
            int randomnum1 = randomnumber.Next(1,10);
            int randomnum2 = randomnumber.Next(1,10);
            textBox3.BackColor = Color.White;
            textBox3.Clear();
            textBox1.Text = randomnum1.ToString();
            textBox2.Text = randomnum2.ToString();
            int result = 0;
            int userresult = 0;
           
           
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practise practise = new Practise();
            practise.Show();
        }

        private void Exercise1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b= Convert.ToInt32(textBox2.Text);
            result = (a * b);

            if (textBox3.Text != string.Empty)
            {
                int userresult = Convert.ToInt32(textBox3.Text);
                if (userresult == result)
                {
                    textBox3.BackColor = Color.Green;
                }
                else
                {
                    textBox3.BackColor = Color.Red;
                }
            }
            
           
        }
        }
    }

