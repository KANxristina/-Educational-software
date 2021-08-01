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
    public partial class Exercise2 : Form
    {
        int n;
        int result;
        int user;
        int j;
        int num;
        DataTable dt;

        public Exercise2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Exercise2_Load(object sender, EventArgs e)
        {
            textBox21.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Give number to textbox and press Enter");
            textBox21.Show();
            textBox21.Clear();
            textBox3.BackColor = textBox2.BackColor = textBox1.BackColor = textBox8.BackColor = textBox12.BackColor = textBox15.BackColor = textBox16.BackColor = textBox17.BackColor = textBox18.BackColor = textBox20.BackColor = Color.White;
            textBox3.Text = textBox2.Text = textBox1.Text = textBox8.Text = textBox12.Text = textBox15.Text = textBox16.Text = textBox17.Text = textBox18.Text = null;
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox21.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int n = Convert.ToInt32(textBox21.Text);
                    textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox13.Text = textBox14.Text = textBox19.Text = Convert.ToString(n);

                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Give number!");
            }
            else
            {
                int num = Convert.ToInt32(textBox4.Text);

                int[] mult = new int[10];

                for (int j = 1; j < 11; j++)
                {
                    int number = j * num;
                    mult[j - 1] = number;

                    //  MessageBox.Show(Convert.ToString(j + " " + " * " + num + " " + mult[0]));
                }



                if (textBox3.Text != Convert.ToString(mult[0]) & !string.IsNullOrEmpty(textBox3.Text))
                {

                    textBox3.BackColor = Color.Red;
                }
                else if (textBox3.Text == Convert.ToString(mult[0]))
                {
                    textBox3.BackColor = Color.Green;
                }
                else
                {
                    textBox3.BackColor = Color.White;
                }

                if (textBox2.Text != Convert.ToString(mult[1]) & !string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.Red;

                }
                else if (textBox2.Text == Convert.ToString(mult[1]))
                {
                    textBox2.BackColor = Color.Green;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                }
                if (textBox1.Text != Convert.ToString(mult[2]) & !string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.BackColor = Color.Red;

                }
                else if (textBox1.Text == Convert.ToString(mult[2]))
                {
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.White;
                }
                if (textBox8.Text != Convert.ToString(mult[3]) & !string.IsNullOrEmpty(textBox8.Text))
                {
                    textBox8.BackColor = Color.Red;

                }
                else if (textBox8.Text == Convert.ToString(mult[3]))
                {
                    textBox8.BackColor = Color.Green;
                }
                else
                {
                    textBox8.BackColor = Color.White;
                }
                if (textBox12.Text != Convert.ToString(mult[4]) & !string.IsNullOrEmpty(textBox12.Text))
                {
                    textBox12.BackColor = Color.Red;

                }
                else if (textBox12.Text == Convert.ToString(mult[4]))
                {
                    textBox12.BackColor = Color.Green;
                }
                else
                {
                    textBox12.BackColor = Color.White;
                }
                if (textBox15.Text != Convert.ToString(mult[5]) & !string.IsNullOrEmpty(textBox15.Text))
                {
                    textBox15.BackColor = Color.Red;

                }
                else if (textBox15.Text == Convert.ToString(mult[5]))
                {
                    textBox15.BackColor = Color.Green;
                }
                else
                {
                    textBox15.BackColor = Color.White;
                }
                if (textBox16.Text != Convert.ToString(mult[6]) & !string.IsNullOrEmpty(textBox16.Text))
                {
                    textBox16.BackColor = Color.Red;

                }
                else if (textBox16.Text == Convert.ToString(mult[6]))
                {
                    textBox16.BackColor = Color.Green;
                }
                else
                {
                    textBox16.BackColor = Color.White;
                }
                if (textBox17.Text != Convert.ToString(mult[7]) & !string.IsNullOrEmpty(textBox17.Text))
                {
                    textBox17.BackColor = Color.Red;

                }
                else if (textBox17.Text == Convert.ToString(mult[7]))
                {
                    textBox17.BackColor = Color.Green;
                }
                else
                {
                    textBox17.BackColor = Color.White;
                }

                if (textBox18.Text != Convert.ToString(mult[8]) & !string.IsNullOrEmpty(textBox18.Text))
                {
                    textBox18.BackColor = Color.Red;

                }
                else if (textBox18.Text == Convert.ToString(mult[8]))
                {
                    textBox18.BackColor = Color.Green;
                }
                else
                {
                    textBox18.BackColor = Color.White;
                }
                if (textBox20.Text != Convert.ToString(mult[9]) & !string.IsNullOrEmpty(textBox20.Text))
                {
                    textBox20.BackColor = Color.Red;
                }
                else if (textBox20.Text == Convert.ToString(mult[9]))
                {
                    textBox20.BackColor = Color.Green;
                }
                else
                {
                    textBox20.BackColor = Color.White;
                }



            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Theory theory = new Theory();
            theory.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practise practise = new Practise();
            practise.Show();
        }
    }
    } 
