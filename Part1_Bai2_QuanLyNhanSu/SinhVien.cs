using System;

namespace Part1_Bai2_QuanLyNhanSu
{
    public class SinhVien : Nguoi
    {
        public string MaSV { get; set; }
        public string MaLop { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }

        public SinhVien() : base()
        {
            MaSV = "";
            MaLop = "";
            Email = "";
            DienThoai = "";
        }

        public SinhVien(string hoTen, DateTime ngaySinh, string diaChi,
                        string maSV, string maLop, string email, string dienThoai)
            : base(hoTen, ngaySinh, diaChi)
        {
            MaSV = maSV;
            MaLop = maLop;
            Email = email;
            DienThoai = dienThoai;
        }

        public override void XemThongTin()
        {
            Console.WriteLine($"[Sinh Viên] MSSV: {MaSV,-8} | Họ tên: {HoTen,-18} | Lớp: {MaLop,-8} | Tuổi: {LayTuoi,2} | ĐT: {DienThoai,-11} | Email: {Email,-20} | Đ/C: {DiaChi}");
        }
    }
}
