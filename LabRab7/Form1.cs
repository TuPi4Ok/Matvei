using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRab7
{
    public partial class Form1 : Form
    {
        public static String filePath = "C:\\Users\\ivanp\\OneDrive\\Рабочий стол\\Папка со всем\\учеба\\работы для всех\\Matvei\\LabRab7\\Data.bin";
        static List<Pet> pets = new List<Pet>();

        internal static List<Pet> Pets { get => pets; set => pets = value; }

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;

            FileStream fr = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            if(fr.Length > 0)
            {
                pets = (List<Pet>)bf.Deserialize(fr);
            }
            fr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet(textBox2.Text, textBox1.Text, textBox4.Text, Convert.ToInt32(textBox3.Text), textBox5.Text, dateTimePicker1.Value, textBox6.Text);
            pets.Add(pet);

            FileStream fr = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fr, pets);
            fr.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1Enable()
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void numericUpDown1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3.Close();
        }

        private void поискПоСодержимомуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }
    }
}
