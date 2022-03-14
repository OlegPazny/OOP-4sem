using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    public class AdressCL
    {
        public string City;
        public string Street;
        public int House;
        public int Flat;
        public int Index;

        public AdressCL() { }

        public AdressCL(string city, string street, int house, int flat, int index)
        {
            (City, Street, House, Flat, Index) = (city, street, house, flat, index);
        }
        public override string ToString()
        {
            return $"Город: {City}\n\tУлица: {Street}\n\t Дом: {House}\n\tКвартира: {Flat}\n\tИндекс: {Index}\n";
        }
    }
}
