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
    public partial class Form3 : Form
    {
        private Pet find = new Pet();
        public Form3()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            dateTimePicker1.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            find.Poroda = textBox1.Text;
            find.Name = textBox2.Text;
            find.BornYear = Convert.ToInt32(textBox3.Text);
            find.Klichka = textBox5.Text;
            find.OwnerLastName = textBox6.Text;
            find.Diagnoz = textBox7.Text;
            find.LastDate = dateTimePicker1.Value;

            FileStream fr = new FileStream(Form1.filePath, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fr, Form1.Pets);
            fr.Close();
            Close();
        }
        private void button1Enable()
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0 && textBox7.Text.Length > 0 && textBox3.Text.Length > 0)
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Pet pet in Form1.Pets)
            {
                if(pet.Name == textBox4.Text)
                {
                    find = pet;
                }
            }

            textBox1.Text = find.Poroda;
            textBox2.Text = find.Name.ToString();
            textBox3.Text = find.BornYear.ToString();
            textBox5.Text = find.Klichka.ToString();
            textBox6.Text = find.OwnerLastName;
            textBox7.Text = find.Diagnoz;
            dateTimePicker1.Value = find.LastDate;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button1Enable();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button1Enable();
        }
    }
}
