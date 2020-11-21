///////////////////////////////////////
/// Donny Kapic z1855273
/// Justin Roesner z1858242
/// CSCI 473 .NET programming
/// Assign 6
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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace DonnyJustin_Assign6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // read in data points from file
            string[] graphData = File.ReadAllLines("../../collegeDiet.txt");

            // chart title
            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = graphData[0].ToString();
            chart1.Titles.Add(title);

            // fill points and name them
            for (int i = 1; i <= graphData.Length - 3; i += 3)
            {
                int temp = chart1.Series["Series1"].Points.AddXY(graphData[i + 1].ToString(), int.Parse(graphData[i + 2]));
                chart1.Series["Series1"].Points[temp].Label = graphData[i].ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // when closing a chart open portal
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
