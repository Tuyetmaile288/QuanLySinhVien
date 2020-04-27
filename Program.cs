using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach sv = new DanhSach();
            sv.NhapDS();

            Console.WriteLine(" ma sinh vien duoc sap xep la:");
            sv.SapXep();

            

            Console.WriteLine("sinh vien co diem tren 8.5");
            sv.DSSV();
            sv.XuatDS();

            Console.Read(); ;
        }
    }
}
