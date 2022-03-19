using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204066
{
    internal class Penjumlahan<T> where T : IComparable<T>
    {
        public T JumlahTigaAngka (T input1, T input2, T input3)
        {         
            dynamic jumlahkuy = input1;
            jumlahkuy += input2;
            jumlahkuy += input3;
            return jumlahkuy;
        }
    }
}
