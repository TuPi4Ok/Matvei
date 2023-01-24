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

namespace LabRab6
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filePath = ofd.FileName;
            StreamReader rd = new StreamReader(ofd.FileName);
            textBox1.Text = rd.ReadToEnd();
            rd.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string textToFind = textBox2.Text;
            List<string> list = new List<string>();
            String[] lines = textBox1.Text.Split();

            foreach (string s in lines)
            {
                string str = s.Trim();
                if (str == String.Empty)
                    continue;
                list.Add(str);

            }
            foreach (string s in list)
            {
                if (s.Contains(textToFind))
                    listBox1.Items.Add(s);
            }


        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int begin = -1;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text.Substring(i, textBox1.Text.Length - i).StartsWith(listBox1.SelectedItem.ToString()))
                {
                    begin = i;
                }
            }
            textBox1.SelectionStart = begin;
            textBox1.SelectionLength = listBox1.SelectedItem.ToString().Length;
            textBox1.Focus();
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] strPoints = textBox1.Text.Split('\n');
            Point[] points = new Point[strPoints.Length];
            for(int i = 0; i < strPoints.Length; i++)
            {
                points[i].X = Convert.ToInt32(strPoints[i].Split(',')[0]);
                points[i].Y = Convert.ToInt32(strPoints[i].Split(',')[1]);
            }
            double[] results = new double[(int)Math.Pow(points.Length, points.Length)];
            double min = double.MaxValue;
            String result = "";
            int index = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for(int j = 0; j < points.Length; j++)
                {
                    results[index] = Math.Sqrt(Math.Pow((points[j].X - points[i].X), 2) + Math.Pow((points[j].Y - points[i].Y), 2));
                    if (results[index] < min && results[index] != 0)
                    {
                        result = (i + 1) + ", " + (j + 1);
                        min = results[index];
                    }
                    index++;
                }     
            }

            textBox3.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(filePath.Length > 0)
            {
                StreamWriter writer = new StreamWriter(filePath);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
