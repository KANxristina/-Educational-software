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
    public partial class Examination : Form
    {
        public Examination()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practise practise = new Practise();
            practise.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam exam = new Exam();
            exam.Show();
        }

        private void Examination_Load(object sender, EventArgs e)
        {

        }
    }
}
