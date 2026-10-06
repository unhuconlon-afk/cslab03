using System;

namespace Part1_Bai2_QuanLyNhanSu
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public int LayTuoi
        {
            get
            {
                int tuoi = DateTime.Now.Year - NgaySinh.Year;
                if (DateTime.Now.DayOfYear < NgaySinh.DayOfYear)
                {
                    tuoi--;
                }
                return tuoi;
            }
        }

        public Nguoi()
        {
            HoTen = "";
            NgaySinh = DateTime.Now;
            DiaChi = "";
        }

        public Nguoi(string hoTen, DateTime ngaySinh, string diaChi)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }

        public virtual void XemThongTin()
        {
            Console.WriteLine($"[Người] Họ tên: {HoTen,-20} | Tuổi: {LayTuoi,2} | Ngày sinh: {NgaySinh:dd/MM/yyyy} | Địa chỉ: {DiaChi}");
        }

        public override string ToString()
        {
            return $"{HoTen} ({LayTuoi} tuổi) - {DiaChi}";
        }
    }
}
