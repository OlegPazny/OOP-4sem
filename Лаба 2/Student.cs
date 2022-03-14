using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Лаба_2
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        StudentCL[] list = new StudentCL[1];
        AdressCL[] ad;
        private int Id = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adress AD = new Adress();
            AD.Show();
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            try
            {
                Adress AD = (Adress)this.Owner;
                if(AD == null) { throw new Exception(); }
                ad = AD.getList();
                foreach (AdressCL el in ad)
                {
                    if(comboBox3.Items.IndexOf(el.City) == -1)
                    {
                        comboBox3.Items.Add(el.City);
                    }
                }
                
            }
            catch
            {
                label9.Text = "Ошибка!";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "Группа: " + Convert.ToString(trackBar1.Value);
            }
            catch
            {
                label9.Text = "Ошибка!";
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                label6.Text = "Возраст: " + Convert.ToString(trackBar2.Value);
            }
            catch
            {
                label9.Text = "Ошибка!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text != "" && comboBox1.SelectedItem != null && /*comboBox2.SelectedItem != null &&*/comboBox3.SelectedItem != null) && (checkBox1.Checked != false || checkBox2.Checked != false || checkBox3.Checked != false || checkBox4.Checked != false))
                {
                    AdressCL adr = new AdressCL("none", "none", 0, 0, 0);
                    foreach(AdressCL el in ad)
                    {
                        if(el.City == comboBox3.SelectedItem)
                        {
                            adr = el;
                        }
                    }
                    /*string rad = "";
                    if (radioButton1.Checked == false) rad = radioButton2.Text;
                    else rad = radioButton1.Text;*/
                    string sex = "";
                    if (radioButton1.Checked == true)
                    {
                        sex = "М";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        sex = "Ж";
                    }
                    string ch = "";
                    if (checkBox1.Checked == true) ch += checkBox1.Text + " ";
                    if (checkBox2.Checked == true) ch += checkBox2.Text + " ";
                    if (checkBox3.Checked == true) ch += checkBox3.Text + " ";
                    if (checkBox4.Checked == true) ch += checkBox4.Text + " ";
                    Array.Resize(ref list, Id);
                    Id++;
                    list[list.Length - 1] = new StudentCL(textBox1.Text, sex, Convert.ToInt32(comboBox1.Text), ch, trackBar1.Value, trackBar2.Value, /*comboBox2.Text, */adr);

                    dataGridView1.Rows.Add(textBox1.Text);
                    dataGridView1.Rows[list.Length - 1].Cells[1].Value = sex;
                    dataGridView1.Rows[list.Length - 1].Cells[2].Value = Convert.ToInt32(comboBox1.Text);
                    dataGridView1.Rows[list.Length - 1].Cells[3].Value = ch;
                    dataGridView1.Rows[list.Length - 1].Cells[4].Value = trackBar1.Value;
                    dataGridView1.Rows[list.Length - 1].Cells[5].Value = trackBar2.Value;
                    /*dataGridView1.Rows[list.Length - 1].Cells[6].Value = comboBox2.Text;*/
                    dataGridView1.Rows[list.Length - 1].Cells[7-1].Value = adr.City;
                    dataGridView1.Rows[list.Length - 1].Cells[8-1].Value = adr.Street;
                    dataGridView1.Rows[list.Length - 1].Cells[9-1].Value = adr.House;
                    //добавил
                    dataGridView1.Rows[list.Length - 1].Cells[10 - 1].Value = adr.Flat;
                    dataGridView1.Rows[list.Length - 1].Cells[11 - 1].Value = adr.Index;
                }
                else throw new Exception();
            }
            catch
            {
                label9.Text = "Ошибка!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (list.Length != 0)
                {
                    XmlSerializer XMLStudent = new XmlSerializer(typeof(StudentCL[]));
                    using (FileStream file = new FileStream("Data.xml", FileMode.OpenOrCreate))
                    {
                        XMLStudent.Serialize(file, list);
                    }
                }
                else throw new Exception();
            }
            catch
            {
                label9.Text = "Ошибка!";
            }*/
            try
            {
                DataSet dataset = new DataSet();
                DataTable datatable = new DataTable();
                datatable.TableName = "Студенты";
                datatable.Columns.Add("ФИО");
                datatable.Columns.Add("Пол");
                datatable.Columns.Add("Курс");
                datatable.Columns.Add("Специальность");
                datatable.Columns.Add("Группа");
                datatable.Columns.Add("Возраст");
                datatable.Columns.Add("Город");
                datatable.Columns.Add("Улица");
                datatable.Columns.Add("Дом");
                datatable.Columns.Add("Квартира");
                datatable.Columns.Add("Индекс");
                dataset.Tables.Add(datatable);

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row = dataset.Tables["Студенты"].NewRow();
                    row["ФИО"] = r.Cells[0].Value;
                    row["Пол"] = r.Cells[1].Value;
                    row["Курс"] = r.Cells[2].Value;
                    row["Специальность"] = r.Cells[3].Value;
                    row["Группа"] = r.Cells[4].Value;
                    row["Возраст"] = r.Cells[5].Value;
                    row["Город"] = r.Cells[6].Value;
                    row["Улица"] = r.Cells[7].Value;
                    row["Дом"] = r.Cells[8].Value;
                    row["Квартира"] = r.Cells[9].Value;
                    row["Индекс"] = r.Cells[10].Value;
                    dataset.Tables["Студенты"].Rows.Add(row);
                }
                dataset.WriteXml("D:\\БГТУ\\ООП 4 сем\\Лаба 2\\Data.xml");
                MessageBox.Text = "XML успешно сохранен!";
            }
            catch
            {
                MessageBox.Text = "Ошибка при записи XML!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*XmlSerializer XMLStudent = new XmlSerializer(typeof(StudentCL[]));
            using (FileStream file = new FileStream("Data.xml", FileMode.OpenOrCreate))
            {
                StudentCL[] Stud = (StudentCL[])XMLStudent.Deserialize(file);
                list = Stud;
                dataGridView1.Rows.Clear();
                int i;
                for(i = 0; i < Stud.Length; i++)
                {
                    dataGridView1.Rows.Add(Stud[i].Name);
                    dataGridView1.Rows[i].Cells[1].Value = Stud[i].Sex;
                    dataGridView1.Rows[i].Cells[2].Value = Stud[i].Curs;
                    dataGridView1.Rows[i].Cells[3].Value = Stud[i].Special;
                    dataGridView1.Rows[i].Cells[4].Value = Stud[i].Group;
                    dataGridView1.Rows[i].Cells[5].Value = Stud[i].Age;
                    
                    dataGridView1.Rows[i].Cells[7-1].Value = Stud[i].Adress.City;
                    dataGridView1.Rows[i].Cells[8-1].Value = Stud[i].Adress.Street;
                    dataGridView1.Rows[i].Cells[9-1].Value = Stud[i].Adress.House;
                    
                    dataGridView1.Rows[i].Cells[10 - 1].Value = Stud[i].Adress.Flat;
                    dataGridView1.Rows[i].Cells[11 - 1].Value = Stud[i].Adress.Index;
                    Id++;
                }
            }*/
            if (dataGridView1.Rows.Count > 1)
            {
                MessageBox.Text = "Очистите таблицу перед загрузкой!";
            }
            else
            {
                if (File.Exists("D:\\БГТУ\\ООП 4 сем\\Лаба 2\\Data.xml"))
                {
                    DataSet dataset = new DataSet();
                    dataset.ReadXml("D:\\БГТУ\\ООП 4 сем\\Лаба 2\\Data.xml");

                    foreach (DataRow item in dataset.Tables["Студенты"].Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item["ФИО"];
                        dataGridView1.Rows[n].Cells[1].Value = item["Пол"];
                        dataGridView1.Rows[n].Cells[2].Value = item["Курс"];
                        dataGridView1.Rows[n].Cells[3].Value = item["Специальность"];
                        dataGridView1.Rows[n].Cells[4].Value = item["Группа"];
                        dataGridView1.Rows[n].Cells[5].Value = item["Возраст"];
                        dataGridView1.Rows[n].Cells[6].Value = item["Город"];
                        dataGridView1.Rows[n].Cells[7].Value = item["Улица"];
                        dataGridView1.Rows[n].Cells[8].Value = item["Дом"];
                        dataGridView1.Rows[n].Cells[9].Value = item["Квартира"];
                        dataGridView1.Rows[n].Cells[10].Value = item["Индекс"];
                    }
                }
                else
                {
                    MessageBox.Text = "Файл XML не найден!";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
