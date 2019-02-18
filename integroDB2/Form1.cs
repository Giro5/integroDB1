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
using System.Data.OleDb;

namespace integroDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet._Услуги_подстановка". При необходимости она может быть перемещена или удалена.
            this.услуги_подстановкаTableAdapter.Fill(this.стоматологияDataSet._Услуги_подстановка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet._Смена_подстановка". При необходимости она может быть перемещена или удалена.
            this.смена_подстановкаTableAdapter.Fill(this.стоматологияDataSet._Смена_подстановка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Штатное_расписание". При необходимости она может быть перемещена или удалена.
            this.штатное_расписаниеTableAdapter.Fill(this.стоматологияDataSet.Штатное_расписание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "стоматологияDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.стоматологияDataSet.Врачи);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            врачиTableAdapter.Insert(Convert.ToInt32(ID_врачаTB.Text), ФИОTB.Text, ДолжностьTB.Text,
                Convert.ToInt32(кабинетTB.Text), Время_приемаTB.Text, Вид_оказ_услугTB.Text, File.ReadAllBytes(ФотоTB.Text), ТелефонTB.Text);
            врачиTableAdapter.Update(стоматологияDataSet);
            врачиTableAdapter.Fill(this.стоматологияDataSet.Врачи);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            врачиTableAdapter.Fill(this.стоматологияDataSet.Врачи);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            врачиTableAdapter.Update(Convert.ToInt32(ID_врачаTB1.Text), ФИОTB1.Text, ДолжностьTB1.Text,
                Convert.ToInt32(кабинетTB1.Text), Время_приемаTB1.Text, Вид_оказ_услугTB1.Text, File.ReadAllBytes(ФотоTB1.Text), ТелефонTB1.Text,
                Convert.ToInt32(iD_врачаTextBox.Text), фИОTextBox.Text, должностьTextBox.Text, Convert.ToInt32(___кабинетаTextBox.Text),
                время_приемаTextBox.Text, вид_оказываемых_услугTextBox.Text, телефонTextBox.Text);
            врачиTableAdapter.Fill(this.стоматологияDataSet.Врачи);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            врачиTableAdapter.Delete(Convert.ToInt32(iD_врачаTextBox1.Text), фИОTextBox1.Text, должностьTextBox1.Text, Convert.ToInt32(___кабинетаTextBox1.Text),
                время_приемаTextBox1.Text, вид_оказываемых_услугTextBox1.Text, телефонTextBox1.Text);
            врачиTableAdapter.Update(стоматологияDataSet);
            врачиTableAdapter.Fill(this.стоматологияDataSet.Врачи);
        }
    }
}
