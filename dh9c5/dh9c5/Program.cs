using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dh9c5
{
    class Program
    {
        
        public String Cau2()
        {
            int a, b, c;
            Console.Write("\nNhap canh a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c = "); c = Convert.ToInt32(Console.ReadLine());
            return kiemTraTamGiac(a, b, c);
        }
        public String kiemTraTamGiac(int a, int b, int c)
        {
            if (a + b > c && c + b > a && c + a > b)
            {
                if (a == b && b == c)
                {
                    return "Day la tam giac deu";
                }
                else if (a == b && b != c || c == b && c != a || b == c && b != a)
                {
                    return "Day la tam giac can";
                }
                else if (a * a == b * b + c * c || b * b == c * c + a * a || c * c == a * a + b * b)
                {
                    return "Day la tam giac vuong";
                }
                else
                {
                    return "Day la tam giac nhon";
                }

            }
            return "Day ko phai la tam giac";
        }
        public int[] nhapMang()
        {
            Console.Write("\nXin hay nhap vao so phan tu: "); int n = Convert.ToInt32(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("phan tu so {0} = ", i); mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            return mang;
        }

        public void print(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i] + " ");
            }
            //Console.ReadLine();
        }

        public int cau_3_1(int[] mang)
        {
            int res = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                res += mang[i];
            }
            return res;
        }

        public int max(int[] mang)
        {
            int max = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            return max;
        }

        public int min(int[] mang)
        {
            int min = mang[0];
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] < min)
                {
                    min = mang[i];
                }
            }
            return min;
        }

        public int TBC(int[] mang)
        {
            int res = 0, count = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] / 2 != 0)
                {
                    count++;
                    res += mang[i];
                }
            }
            return res / count;
        }

        public void SapXepTangDan(ref int[] mang)
        {
            int temp = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[j] < mang[i])
                    {
                        temp = mang[i];
                        mang[i] = mang[j];
                        mang[j] = temp;
                    }
                }
            }
        }

        public void SapXepGiamDan(ref int[] mang)
        {
            int temp = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[j] > mang[i])
                    {
                        temp = mang[i];
                        mang[i] = mang[j];
                        mang[j] = temp;
                    }
                }
            }
        }

        public void timCacSoNguyenTo(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                int dem = 0;

                for (int j = 1; j <= mang[i]; j++)
                {
                    if (mang[i] % j == 0)
                        dem++;
                }

                if (dem == 2)
                    Console.WriteLine("\na[" + i + "] = " + mang[i]);
            }
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            Console.Write("Câu 2: ");
            Console.Write(s.Cau2());
            Console.Write("\n\nCâu 3: ");
            int[] mang = s.nhapMang();
            Console.WriteLine("Cac phan tu trong mang: ");
            s.print(mang);
            Console.WriteLine("\nTong cac PT trong mang: {0}", s.cau_3_1(mang));
            Console.WriteLine("Max = {0}", s.max(mang));
            Console.WriteLine("Min = {0}", s.min(mang));
            Console.WriteLine("Trung binh cong: {0}", s.TBC(mang));
            Console.Write("Mang sau khi da sap xep theo thu tu tang dan: ");
            s.SapXepTangDan(ref mang);
            s.print(mang);
            Console.Write("\nMang sau khi da sap xep theo thu tu giam dan: ");
            s.SapXepGiamDan(ref mang);
            s.print(mang);
            Console.Write("\nCac so nguyen to trong mang: ");
            s.timCacSoNguyenTo(mang);
        }
    }
}
