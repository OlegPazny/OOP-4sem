using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_2
{
    public partial class Adress : Form
    {
        List<AdressCL> listLectors = new List<AdressCL>();
        public Adress()
        {
            InitializeComponent();
        }

        public AdressCL[] getList()
        {
            AdressCL[] arr = new AdressCL[listLectors.Count];
            int count = 0;
            foreach(AdressCL el in listLectors)
            {
                arr[count] = el;
                count++;
            }
            return arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox4.Text != "" || textBox5.Text != ""||textBox2.Text!=""||textBox3.Text!="")
                {
                    listLectors.Add(new AdressCL(textBox4.Text, textBox1.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                    listBox1.Items.Add(textBox4.Text);
                }
                else throw new Exception();
            }
            catch
            {
                label4.Text = "Ошибка!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Student DS = new Student();
                DS.Owner = this;
                DS.Show();
            }
            catch
            {
                label4.Text = "Ошибка!";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
