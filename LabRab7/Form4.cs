using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRab7
{
    public partial class Form4 : Form
    {
        private List<Pet> find = new List<Pet>();
        public Form4()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Pet pet in Form1.Pets)
            {
                if (pet.Name == textBox1.Text && radioButton1.Checked)
                {
                    find.Add(pet);
                }
                if (pet.Poroda == textBox1.Text && radioButton2.Checked)
                {
                    find.Add(pet);
                }
                if (pet.Klichka == textBox1.Text && radioButton4.Checked)
                {
                    find.Add(pet);
                }
                if (pet.BornYear.ToString() == textBox1.Text && radioButton3.Checked)
                {
                    find.Add(pet);
                }
                if (pet.OwnerLastName == textBox1.Text && radioButton5.Checked)
                {
                    find.Add(pet);
                }
                if (pet.Diagnoz == textBox1.Text && radioButton6.Checked)
                {
                    find.Add(pet);
                }

            }

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Название";
            dataGridView1.Columns[1].Name = "Порода";
            dataGridView1.Columns[2].Name = "Кличка";
            dataGridView1.Columns[3].Name = "Год рождения";
            dataGridView1.Columns[4].Name = "Фамилия владельца";
            dataGridView1.Columns[5].Name = "Последнее обращение";
            dataGridView1.Columns[6].Name = "Диагноз";
            dataGridView1.RowCount = (int)find.LongCount();
            int i = 0;
            foreach (Pet pets in find)
            {
                dataGridView1.Rows[i].Cells[0].Value = pets.Name;
                dataGridView1.Rows[i].Cells[1].Value = pets.Poroda;
                dataGridView1.Rows[i].Cells[2].Value = pets.Klichka;
                dataGridView1.Rows[i].Cells[3].Value = pets.BornYear;
                dataGridView1.Rows[i].Cells[4].Value = pets.OwnerLastName;
                dataGridView1.Rows[i].Cells[5].Value = pets.LastDate;
                dataGridView1.Rows[i].Cells[6].Value = pets.Diagnoz;
                i++;
            }
            find.Clear();
        }
    }
}
