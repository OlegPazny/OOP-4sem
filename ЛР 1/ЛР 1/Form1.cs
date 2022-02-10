using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string memory = null;
        public string Memory
        {
            get { return memory; }
            set
            {
                memory = value;
                MemRem.Enabled = !string.IsNullOrEmpty(Memory);
            }
        }
        //сложение
        public static double sum(double a, double b)
        {
            return a + b;
        }
        //вычитание
        public static double substr(double a, double b)
        {
            return a - b;
        }
        //умножение
        public static double multipl(double a, double b)
        {
            return a * b;
        }
        //деление
        public static double dev(double a, double b)
        {
            return a / b;
        }
        //остаток
        public static double rest(double a, double b)
        {
            return a % b;
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = Convert.ToString(sum(Convert.ToDouble(aBox.Text), Convert.ToDouble(bBox.Text)));
        }

        private void SubstrBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = Convert.ToString(substr(Convert.ToDouble(aBox.Text), Convert.ToDouble(bBox.Text)));
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = Convert.ToString(multipl(Convert.ToDouble(aBox.Text), Convert.ToDouble(bBox.Text)));
        }

        private void DevBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = Convert.ToString(dev(Convert.ToDouble(aBox.Text), Convert.ToDouble(bBox.Text)));
        }

        private void RestBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = Convert.ToString(rest(Convert.ToDouble(aBox.Text), Convert.ToDouble(bBox.Text)));
        }
        //кнопка очистки
        private void CleanBtn_Click(object sender, EventArgs e)
        {
            aBox.Text = "";
            bBox.Text = "";
            ResultBox.Text = "";
        }
        //добавление в память
        private void MemAdd_Click(object sender, EventArgs e)
        {
            Memory = ResultBox.Text;
        }
        //извлечение из памяти
        private void MemRem_Click(object sender, EventArgs e)
        {
            aBox.Text = Memory;
        }
        //удаление памяти
        private void MemReset_Click(object sender, EventArgs e)
        {
            Memory = null;
        }
    }
}
