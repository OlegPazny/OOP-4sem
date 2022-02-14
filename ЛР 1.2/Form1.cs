using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int ListAmount;
        public static List<int> Spisok = new List<int>();

        private void ListAm_TextChanged(object sender, EventArgs e)
        {
            ListAmount=int.Parse(ListAm.Text);//достаем значение числа из текстбокса
        }

        private void GenerateCollBtn_Click(object sender, EventArgs e)
        {
            Spisok.Clear();
            Random chislo = new Random();
            for (int i=0; i<ListAmount; i++)
            {
                Spisok.Add(chislo.Next(1, 100));//диапазон чисел от 0 до 100
            }
        }


        private void MinBtn_Click(object sender, EventArgs e)
        {
            List.Text = Spisok.Min().ToString();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            List.Text = Spisok.Max().ToString();
        }

        private void PrintAllBtn_Click(object sender, EventArgs e)
        {
            List.Text = "";
            for(int i = 0; i < ListAmount; i++)
            {
                List.Text += Spisok[i].ToString() + " ";
            }
        }

        private void AscendingBtn_Click(object sender, EventArgs e)
        {
            List.Text = "";
            List<int> sortSpisok = Spisok.OrderBy(n => n).ToList();
            for(int i = 0; i < ListAmount; i++)
            {
                List.Text += sortSpisok[i].ToString() + " ";
            }
        }

        private void DescendingBtn_Click(object sender, EventArgs e)
        {
            List.Text = "";
            List<int> sortSpisok = Spisok.OrderByDescending(n => n).ToList();
            for (int i = 0; i < ListAmount; i++)
            {
                List.Text += sortSpisok[i].ToString() + " ";
            }
        }
    }
}
