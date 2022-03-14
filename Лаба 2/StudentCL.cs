using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    public class StudentCL
    {
        private static int Count = 0;
        public string Name;
        public string Sex;
        public int Curs;
        public string Special;
        public int Group;
        public int Age;
        /*public string Control;*/
        public AdressCL Adress;
        public int ID;

        public StudentCL(string name, string sex, int curs, string special, int group, int age, /*string control,*/ AdressCL adress )
        {
            (Name, Sex, Curs, Special, Group, Age, /*Control,*/ Adress) = (name, sex, curs, special, group, age, /*control,*/ adress);
            ID = Count++;
        }

        public StudentCL() { }

        public override string ToString()
        {
            return $"Название: {Name}\nСеместр: {Sex}\nКурс: {Curs}\nСпециальность: {Special}\nКоличество лекций: {Group}\nКоличество лабораторных: {Age}\nЛектор: {Adress}";
        }
    }
}
