﻿using System;
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
            SimpleDataBase<int> simpleDataBase = new SimpleDataBase<int>();
            simpleDataBase.AddNewData(13);
            simpleDataBase.AddNewData(02);
            simpleDataBase.AddNewData(20);
            simpleDataBase.PrintAllData();
        }
    }
}
