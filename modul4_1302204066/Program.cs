using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 13;
            int input2 = 02;
            int input3 = 20;
            Penjumlahan<int> j = new Penjumlahan<int>();
            int hasil = j.JumlahTigaAngka(input1, input2, input3);
            Console.WriteLine("Hasil Penjumlahan = " + hasil);
            SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
            simpleDataBase.AddNewData(13);
            simpleDataBase.AddNewData(02);
            simpleDataBase.AddNewData(20);
            simpleDataBase.PrintAllData();
        }
    }
}
