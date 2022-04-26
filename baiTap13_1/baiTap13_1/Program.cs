// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baiTap13_1
{
    struct sinhVien
    {
        public int masv;
        public string hoten;
        public string diachi;
        public string lop;
        public int dtoan;
        public int dly;
        public int dtin;
        public int dtb;
    }
    class Program
    {
        public sinhVien[] NhapSV()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            sinhVien[] sv = new sinhVien[n];
            for (int i = 0; i < n; i++)
            {
                //sv[i] = new sinhVien();
                Console.Write("Ma sinh vien: ");
                sv[i].masv = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ho ten: ");
                sv[i].hoten = Convert.ToString(Console.ReadLine());
                Console.Write("Dia chi: ");
                sv[i].diachi = Convert.ToString(Console.ReadLine());
                Console.Write("Lop: ");
                sv[i].lop = Convert.ToString(Console.ReadLine());
                Console.Write("Diem toan: ");
                sv[i].dtoan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diem ly: ");
                sv[i].dly = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diem tin: ");
                sv[i].dtin = Convert.ToInt32(Console.ReadLine());
            }
            return sv;
        }

        public void InSinhVienList(sinhVien[] sv)
        {
            Console.Write("Ma sinh vien");
            Console.Write("{0,17}", "Ho va ten");
            Console.Write("{0,17}", "Dia chi");
            Console.Write("{0,17}", "lop");
            Console.Write("{0,17}", "diem toan");
            Console.Write("{0,17}", "diem ly");
            Console.Write("{0,17}", "diem tin");
            Console.WriteLine("{0,20}", "diem trung binh");
            for (int i = 0;i < sv.Length;i++)
            {
                Console.Write("{0, 17}", sv[i].masv);
                Console.Write("{0, 17}", sv[i].hoten);
                Console.Write("{0, 17}", sv[i].diachi);
                Console.Write("{0, 17}", sv[i].lop);
                Console.Write("{0, 17}", sv[i].dtoan);
                Console.Write("{0, 17}", sv[i].dly);
                Console.Write("{0, 17}", sv[i].dtin);
                Console.WriteLine("{0, 17}", sv[i].dtb);
            }
        }

        public void InMotSinhVien(sinhVien sv)
        {
            Console.Write("Ma sinh vien");
            Console.Write("{0,17}", "Ho va ten");
            Console.Write("{0,17}", "Dia chi");
            Console.Write("{0,17}", "lop");
            Console.Write("{0,17}", "diem toan");
            Console.Write("{0,17}", "diem ly");
            Console.Write("{0,17}", "diem tin");
            Console.WriteLine("{0,20}", "diem trung binh");
            Console.Write("{0, 17}", sv.masv);
            Console.Write("{0, 17}", sv.hoten);
            Console.Write("{0, 17}", sv.diachi);
            Console.Write("{0, 17}", sv.lop);
            Console.Write("{0, 17}", sv.dtoan);
            Console.Write("{0, 17}", sv.dly);
            Console.Write("{0, 17}", sv.dtin);
            Console.WriteLine("{0, 17}", sv.dtb);
        }

        public sinhVien[] TinhDTB(sinhVien[] sv) 
        {
            for (int i = 0; i < sv.Length; i++)
            {
                sv[i].dtb = (sv[i].dtin + sv[i].dly + sv[i].dtoan) / 3;
            }
            return sv;
        }

        public void SapXepGiamDan(ref sinhVien[] sv)
        {
            sinhVien temp = new sinhVien();
            for (int i = 0; i < sv.Length; i++)
            {
                for (int j = i + 1; j < sv.Length; j++)
                {
                    if (sv[j].dtb > sv[i].dtb)
                    {
                        temp = sv[i];
                        sv[i] = sv[j];
                        sv[j] = temp;
                    }
                }
            }
        }

        public sinhVien timKiem (sinhVien[] sv)
        {
            Console.Write("Xin hay nhap vao ma sinh vien muon tim: ");
            int masv = Convert.ToInt32(Console.ReadLine());
            sinhVien sv2 = new sinhVien();
            for (int i = 0; i < sv.Length; i++)
            {
                if (sv[i].masv == masv)
                {
                    return sv[i];
                }
            }
            return sv2;
        }

        public sinhVien[] themSinhVien(sinhVien[] sv)
        {
            Console.Write("Xin hay nhap vao so luong sinh vien muon them: ");
            List<sinhVien> list = new List<sinhVien>(sv);
            int n = Convert.ToInt32(Console.ReadLine());
            sinhVien[] sv2 = new sinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv2[i] = new sinhVien();
                Console.Write("Ma sinh vien: ");
                sv2[i].masv = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ho ten: ");
                sv2[i].hoten = Convert.ToString(Console.ReadLine());
                Console.Write("Dia chi: ");
                sv2[i].diachi = Convert.ToString(Console.ReadLine());
                Console.Write("Lop: ");
                sv2[i].lop = Convert.ToString(Console.ReadLine());
                Console.Write("Diem toan: ");
                sv2[i].dtoan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diem ly: ");
                sv2[i].dly = Convert.ToInt32(Console.ReadLine());
                Console.Write("Diem tin: ");
                sv2[i].dtin = Convert.ToInt32(Console.ReadLine());
                list.Add(sv2[i]);
            }
            
            return list.ToArray();
        }

        public void xoaSinhVien(ref sinhVien[] sv)
        {
            Console.Write("Xin hay nhap vao ma sinh vien muon xoa: ");
            int masv = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sv.Length; i++)
            {
                if (sv[i].masv == masv)
                {
                    sv = sv.Where((source, index) => index != i).ToArray();
                    break;
                }
            }
        }

        public void suaSinhVien(ref sinhVien[] sv)
        {
            Console.Write("Xin hay nhap vao ma sinh vien muon sua: ");
            int masv = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < sv.Length;i++)
            {
                if (sv[i].masv == masv)
                {
                    Console.Write("Ho ten: ");
                    sv[i].hoten = Convert.ToString(Console.ReadLine());
                    Console.Write("Dia chi: ");
                    sv[i].diachi = Convert.ToString(Console.ReadLine());
                    Console.Write("Lop: ");
                    sv[i].lop = Convert.ToString(Console.ReadLine());
                    Console.Write("Diem toan: ");
                    sv[i].dtoan = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Diem ly: ");
                    sv[i].dly = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Diem tin: ");
                    sv[i].dtin = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            int c;
            sinhVien[] sv = new sinhVien[0];
            do
            {
                Console.WriteLine("Chuong trinh quan ly sinh vien:");
                Console.WriteLine("1. Nhap sinh vien.");
                Console.WriteLine("2. In sinh vien.");
                Console.WriteLine("3. Tinh DTB sinh vien.");
                Console.WriteLine("4. Sap xep sinh vien theo DTB.");
                Console.WriteLine("5. Tim kiem sinh vien.");
                Console.WriteLine("6. Bo sung them sinh vien.");
                Console.WriteLine("7. Xoa sinh vien.");
                Console.WriteLine("8. Sua sinh vien.");
                Console.WriteLine("9. Thoat.");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                         sv = s.NhapSV();
                        break;
                    case 2:
                        s.InSinhVienList(sv);
                        break;
                    case 3:
                        sv = s.TinhDTB(sv);
                        break;
                    case 4:
                        s.SapXepGiamDan(ref sv);
                        break;
                    case 5:
                        s.InMotSinhVien(s.timKiem(sv));
                        break;
                    case 6:
                        sv = s.themSinhVien(sv);
                        break;
                    case 7:
                        s.xoaSinhVien(ref sv);
                        break;
                    case 8:
                        s.suaSinhVien(ref sv);
                        break;
                }
            } while (c != 9);
        }
    }
}
