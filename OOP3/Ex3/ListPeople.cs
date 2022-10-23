﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lap1_Bai_So_3_People;
using Lap1_Bai_So_3_Student;

namespace Lap1_Bai_So_3_ListPeople
{
    internal class ListPeople
    {
        ArrayList arrayList = new ArrayList();
        public void NhapDS(ArrayList arraylist, int n)
        {
            Console.WriteLine("\n ==========**Nhap danh sach sinh vien**==========");
            for (int i = 0; i < n; i++)
            {
                People people = new Student();
                Console.WriteLine("======Nhap thong tin SV thu = {0}========", i + 1);
                people.Nhap1SV();
                arraylist.Add(people);
            }
        }

        public void XuatDS(ArrayList arraylist, int n)
        {
            Console.WriteLine("\n ==========**Xuat danh sach sinh vien**==========");
            foreach (People people in arraylist)
            {
                Console.WriteLine("\n=======Sinh vien co ma SV ={0}============", people.SID1);
                people.Show();
            }
            Console.ReadLine();
        }
    }
}
