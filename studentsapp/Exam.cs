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
    public partial class Exam : Form
    {
        int num1;
        int num2;
        int result;
        int user;
        int points=0;
        public int right=0;
        public int wrong=0;
        float score;
        int i=0;

        public Exam()
        {
            InitializeComponent();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            textBox1.Text = Convert.ToString(num1);
            textBox2.Text = Convert.ToString(num2);
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int result = a * b;
            
            
            if (i > 9)
            {
                DialogResult dialogResult = MessageBox.Show("End of the Exam. Check the results", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   
                    MessageBox.Show("The score is: "+" "+points+"%"+"\n"+"Correct Answers:"+right+"\n"+"Incorrect Answers:"+wrong);
                }

            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                int z = Convert.ToInt32(textBox3.Text);
                if (z == result)
                {
                    wrong = +1;
                    points = points;
                    right = right;
                }
                else
                {
                    points = points + 10;
                    right = +1;
                    wrong = wrong;

                }

            }

               

            i++;
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mesg= MessageBox.Show("Are you sure you want to quit? You will lose all the points you gained", "Confirm", MessageBoxButtons.YesNo);
             if (mesg == DialogResult.Yes)
              {
                int points = 0;
                int right =0;
                int wrong = 0;
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }
    }
    }

