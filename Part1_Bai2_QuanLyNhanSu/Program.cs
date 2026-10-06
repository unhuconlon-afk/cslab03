using System;
using System.Collections.Generic;
using System.Text;

namespace Part1_Bai2_QuanLyNhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("   BÀI TẬP 2: QUẢN LÝ NHÂN SỰ (LỚP NGUOI, SINHVIEN, NHANVIEN) ");
            Console.WriteLine("==============================================================");

            // 1. Thử nghiệm lớp Người cơ bản
            Console.WriteLine("\n--- 1. ĐỐI TƯỢNG LỚP NGUOI ---");
            Nguoi ng = new Nguoi("Nguyễn Văn A", new DateTime(1985, 3, 20), "123 Cách Mạng Tháng 8, Q.3");
            ng.XemThongTin();

            // 2. Thử nghiệm lớp Sinh Viên
            Console.WriteLine("\n--- 2. ĐỐI TƯỢNG LỚP SINHVIEN ---");
            SinhVien sv = new SinhVien(
                hoTen: "Trần Thị Mai",
                ngaySinh: new DateTime(2003, 8, 12),
                diaChi: "456 Nguyễn Trãi, Q.5",
                maSV: "SV202601",
                maLop: "CNTT-K48",
                email: "mai.tran@student.edu.vn",
                dienThoai: "0901234567"
            );
            sv.XemThongTin();

            // 3. Thử nghiệm lớp Nhân Viên
            Console.WriteLine("\n--- 3. ĐỐI TƯỢNG LỚP NHANVIEN ---");
            NhanVien nv = new NhanVien(
                hoTen: "Lê Hoàng Phúc",
                ngaySinh: new DateTime(1990, 11, 5),
                diaChi: "789 Lê Duẩn, Q.1",
                maNhanVien: "NV8899",
                email: "phuc.le@company.com",
                dienThoai: "0988776655",
                ngayLamViec: new DateTime(2018, 6, 1),
                maCongTy: "TECHCORP"
            );
            nv.XemThongTin();

            // 4. Danh sách đa hình List<Nguoi>
            Console.WriteLine("\n--- 4. DANH SÁCH ĐA HÌNH List<Nguoi> ---");
            List<Nguoi> danhSach = new List<Nguoi> { ng, sv, nv };
            foreach (var item in danhSach)
            {
                item.XemThongTin();
            }

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }
    }
}
