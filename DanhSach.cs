using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chuong3_bt6
{
    class DanhSach
    {
        private int n;
        private SinhVien[] DS;
        private int i;
        private int j;
        public void NhapDS()
        {

            Console.WriteLine("nhap vao danh sach sinh vien");
            Console.WriteLine("nhap vao so luong mang");
            n = Int32.Parse(Console.ReadLine());
            DS = new SinhVien[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("nhap vao sinh vien thu {0}", i);
                DS[i] = new SinhVien();
                DS[i].NhapSV();

            }
        }
        public void XuatDS()
        {
            if (DS != null && n > 0) ;
            Console.WriteLine("danh sach sinh vien");
            for (i = 0; i < n; i++)
            {
                DS[i].TinhDiem();
                DS[i].XuatSV();
            }

        }
        public void DSSV()
        {
            for (i = 0; i < n; i++)
            {
                if (DS[i].CheckDiem())
                {


                    Console.WriteLine("sinh vien co diem cao hon 8,5 la");
                    DS[i].XuatSV();
                }

            }
        }

        public void SapXep()
        {
            SinhVien tg;
            Console.WriteLine("\n danh sach  sinh vien");
            for (i = 0; i < n-1; i++)
                for (j = i + 1; j < n; j++)
                {
                    if (string.Compare(DS[i].MSV, DS[j].MSV, true) > 0)
                    {
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;

                    }
                }
            for (i = 0; i < n; i++)
            {

                DS[i].XuatSV();
            }

        }
    }
}


       
        


