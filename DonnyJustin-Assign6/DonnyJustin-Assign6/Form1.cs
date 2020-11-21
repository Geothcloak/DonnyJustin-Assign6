///////////////////////////////////////
/// Donny Kapic z1855273
/// Justin Roesner z1858242
/// CSCI 473 .NET programming
/// Assign 6
/// CHARTS
///////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonnyJustin_Assign6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open chart 1
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open chart 2
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open charts 3
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // open charts 4
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
