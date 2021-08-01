using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace studentsapp
{
    public partial class CreateAccount : Form
    {
        string role;
        Boolean button2clicked;
        Boolean button3clicked;


        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (panel1.Height == 63)
            {
                panel1.Height = 188;
            }
            else
            {
                panel1.Height = 63;
            }

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            panel1.Height =63;
            panel1.Width = 188;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
          
           if(string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrWhiteSpace(textBox1.Text)) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Set a Usename, a Password and choose Role");
            }
         
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kanaki\Documents\Maths.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            
                if (button3clicked == true || button2clicked == true)
                {
                if (textBox2.Text == textBox3.Text)
                {
                    // String query = "insert into Students (username, password, role)  values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox4.Text + "')";
                    String query = "insert into Students (username, password, role)  values('" + textBox1.Text + "', '" + textBox2.Text + "','" + role + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;


                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Saved...");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Saved");
                    }
                    finally
                    {
                        con.Close();
                        textBox1.Text = string.Empty;
                        textBox2.Text = string.Empty;
                        textBox3.Text = string.Empty;

                    }
                }
                else
                {
                    MessageBox.Show("Type and Confirm password on ");
                }
                }
                else
                {
                    MessageBox.Show("Don't forget the Role");
                }
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            role= "student";
            button2clicked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
            role= "teacher";
            button3clicked = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
