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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Название";
            dataGridView1.Columns[1].Name = "Порода";
            dataGridView1.Columns[2].Name = "Кличка";
            dataGridView1.Columns[3].Name = "Год рождения";
            dataGridView1.Columns[4].Name = "Фамилия владельца";
            dataGridView1.Columns[5].Name = "Последнее обращение";
            dataGridView1.Columns[6].Name = "Диагноз";
            dataGridView1.RowCount = (int)Form1.Pets.LongCount();
            int i = 0;
            foreach (Pet pets in Form1.Pets)
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
        }
    }
}
