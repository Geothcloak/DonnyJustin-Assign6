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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            // read data in from file
            string[] graphData = File.ReadAllLines("../../studentPowerlevel.txt");

            // chart title
            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = graphData[0].ToString();
            chart1.Titles.Add(title);

            // fill points and name them
            for (int i = 1; i <= graphData.Length - 3; i += 3)
            {
                int temp = chart1.Series["Powerlevel"].Points.AddXY(graphData[i].ToString(), int.Parse(graphData[i + 2]));
                chart1.Series["Powerlevel"].Points[temp].Label = graphData[i + 2].ToString();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close and go back to portal
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
