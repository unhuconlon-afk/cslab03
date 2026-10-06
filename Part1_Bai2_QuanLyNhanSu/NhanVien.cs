using System;

namespace Part1_Bai2_QuanLyNhanSu
{
    public class NhanVien : Nguoi
    {
        public string MaNhanVien { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayLamViec { get; set; }
        public string MaCongTy { get; set; }

        public NhanVien() : base()
        {
            MaNhanVien = "";
            Email = "";
            DienThoai = "";
            NgayLamViec = DateTime.Now;
            MaCongTy = "";
        }

        public NhanVien(string hoTen, DateTime ngaySinh, string diaChi,
                        string maNhanVien, string email, string dienThoai,
                        DateTime ngayLamViec, string maCongTy)
            : base(hoTen, ngaySinh, diaChi)
        {
            MaNhanVien = maNhanVien;
            Email = email;
            DienThoai = dienThoai;
            NgayLamViec = ngayLamViec;
            MaCongTy = maCongTy;
        }

        public override void XemThongTin()
        {
            Console.WriteLine($"[Nhân Viên] Mã NV: {MaNhanVien,-8} | Họ tên: {HoTen,-18} | Tuổi: {LayTuoi,2} | Ngày làm: {NgayLamViec:dd/MM/yyyy} | Cty: {MaCongTy,-8} | ĐT: {DienThoai,-11} | Email: {Email}");
        }
    }
}
