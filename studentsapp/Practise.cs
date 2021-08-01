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
    public partial class Practise : Form
    {
        public Practise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exercise1 exercise1 = new Exercise1();
            exercise1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
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
            Exercise2 exercise = new Exercise2();
            exercise.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam exam = new Exam();
            exam.Show();
        }

        private void Practise_Load(object sender, EventArgs e)
        {

        }
    }
}
