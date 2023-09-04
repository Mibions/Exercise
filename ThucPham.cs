using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_C_sharp
{
    class ThucPham
    {

        private string maHang;
        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private string tenHang;
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        private float donGia;
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private DateTime ngaySX;
        public DateTime NgaySX
        {
            get { return ngaySX; }
            set { ngaySX = value; }
        }

        private DateTime ngayHH;
        public DateTime NgayHH
        {
            get { return ngayHH; }
            set { ngayHH = value; }
        }

        public ThucPham()
        {
            MaHang = TenHang = "";
            DonGia = 0;
        }

        public ThucPham(string Mahang, string Tenhang, float Dongia, DateTime NgaysX, DateTime NgayhH)
        {
            this.MaHang = Mahang;
            this.TenHang = Tenhang;
            this.DonGia = Dongia;
            this.NgaySX = NgaysX;
            this.NgayHH = NgayhH;
        }
        public void Input()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Nhap Ma : ");
            MaHang = Console.ReadLine();
            Console.Write("Nhap Ten : ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap Don gia : ");
            DonGia = float.Parse(Console.ReadLine());
            Console.Write("Nhap Ngay san xuat ( Example : '12/03/2015' ) : ");
            NgaySX = DateTime.Parse(Console.ReadLine());
            NgayHH = NgaySX.AddMonths(6);
        }
        public void Show()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Ma : " + MaHang);
            Console.WriteLine("Ten : " + TenHang);
            Console.WriteLine("Don gia : " + DonGia);
            Console.WriteLine("Ngay san xuat : " + NgaySX.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay het han : " + NgayHH.ToString("dd/MM/yyyy"));
        }

        public void InputList(ThucPham[] tp, int n)
        {

            for (int i = 0; i < n; i++)
            {
                tp[i] = new ThucPham();
                tp[i].Input();
            }

        }

        public void OutputList(ThucPham[] tp, int n)
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|  Ma  |           Ten San Pham            |       Don Gia        |      Ngay San Xuat    |     Ngay Het Han     |      Ghi Chu    |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < n; i++)
            {
                string formattedLine = string.Format("| {0,-5}| {1,-34}| {2,-18:N2}VNĐ| {3,-22}| {4,-21}| {5,-16}|",
                                                  tp[i].MaHang, tp[i].TenHang, tp[i].DonGia, tp[i].NgaySX.ToString("dd/MM/yyyy"), tp[i].NgayHH.ToString("dd/MM/yyyy"), GhiChu(tp[i]));
                Console.WriteLine(formattedLine);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            }

        }

        public string GhiChu(ThucPham tp)
        {
            return tp.NgayHH > DateTime.Now ? "Khong Co Gi" : "Hang Het Han";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ThucPham tp = new ThucPham();
            Console.Write("Nhap vao so luong thuc pham : ");
            int n = Convert.ToInt32(Console.ReadLine());
            ThucPham[] dstp = new ThucPham[n];
            tp.InputList(dstp, n);
            tp.OutputList(dstp, n);
            Console.ReadKey();
        }
    }
}