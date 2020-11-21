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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // read data in from file
            string[] graphData = File.ReadAllLines("../../connfidenceInProgramming.txt");

            // chart title
            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = graphData[0].ToString();
            chart1.Titles.Add(title);

            //name x and y axis
            chart1.ChartAreas[0].AxisX.Title = graphData[2].ToString();
            chart1.ChartAreas[0].AxisY.Title = graphData[1].ToString();

            // fill points and name them
            for (int i = 3; i <= graphData.Length - 2; i += 2)
            {
                chart1.Series["Series1"].Points.AddXY(int.Parse(graphData[i]), int.Parse(graphData[i + 1]));
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close and go back to portal
            Form1 f1 = new Form1();
            f1.Show();
        }

         }
}
