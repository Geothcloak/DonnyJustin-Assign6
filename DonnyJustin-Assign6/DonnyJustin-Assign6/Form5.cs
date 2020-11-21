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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DonnyJustin_Assign6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // read in data from file
            string[] graphData = File.ReadAllLines("../../runSpeed.txt");

            // chart title
            Title title = new Title();
            title.Font = new Font("Arial", 16, FontStyle.Bold);
            title.Text = graphData[0].ToString();
            chart1.Titles.Add(title);

            // store names for lines
            String runner1 = graphData[1].ToString();
            String runner2 = graphData[2].ToString();
            String runner3 = graphData[3].ToString();
            String runner4 = graphData[4].ToString();

            // fill points and name them
            for (int i = 5; i < 24; i += 2)
            {
                chart1.Series[runner1].Points.AddXY(float.Parse(graphData[i]), float.Parse(graphData[i + 1]));
            }
            for (int i = 25; i < 44; i += 2)
            {
                chart1.Series[runner2].Points.AddXY(float.Parse(graphData[i]), float.Parse(graphData[i + 1]));
            }
            for (int i = 45; i < 64; i += 2)
            {
                chart1.Series[runner3].Points.AddXY(float.Parse(graphData[i]), float.Parse(graphData[i + 1]));
            }
            for (int i = 65; i < 84; i += 2)
            {
                chart1.Series[runner4].Points.AddXY(float.Parse(graphData[i]), float.Parse(graphData[i + 1]));
            }

            //name x and y axis
            chart1.ChartAreas[0].AxisY.Title = graphData[graphData.Length - 2].ToString();
            chart1.ChartAreas[0].AxisX.Title = graphData[graphData.Length - 1].ToString();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close and go back to portal
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
