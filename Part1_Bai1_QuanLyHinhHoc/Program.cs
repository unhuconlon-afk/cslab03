using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Part1_Bai1_QuanLyHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("   BÀI TẬP 1: QUẢN LÝ HÌNH HỌC (KẾ THỪA & ĐA HÌNH VỚI C#)     ");
            Console.WriteLine("==============================================================");

            // 1. Kiểm tra đối tượng cơ bản
            Console.WriteLine("\n--- THỬ NGHIỆM CÁC ĐỐI TƯỢNG ĐƠN LẺ ---");
            HinhChuNhat hcn = new HinhChuNhat(10.5, 4.2);
            HinhTron ht = new HinhTron(5.0);

            Console.WriteLine(hcn);
            Console.WriteLine(ht);

            // 2. Mở rộng: Quản lý danh sách List<HinhHoc> và đọc/ghi file
            Console.WriteLine("\n--- QUẢN LÝ DANH SÁCH VÀ ĐỌC TỪ FILE (input.txt) ---");

            string inputFile = "input.txt";
            string outputFile = "output.txt";

            // Tạo file input.txt mẫu nếu chưa tồn tại
            if (!File.Exists(inputFile))
            {
                string sampleData = "5\n" +
                                   "HCN 12.0 6.0\n" +
                                   "HT 4.5\n" +
                                   "HCN 8.5 5.5\n" +
                                   "HT 3.0\n" +
                                   "HCN 15.0 7.0\n";
                File.WriteAllText(inputFile, sampleData, Encoding.UTF8);
                Console.WriteLine($"[Thông báo]: Đã tạo file dữ liệu mẫu '{inputFile}'.");
            }

            List<HinhHoc> dsHinh = DocFile(inputFile);

            Console.WriteLine($"\nĐã đọc thành công {dsHinh.Count} hình từ file '{inputFile}':");
            for (int i = 0; i < dsHinh.Count; i++)
            {
                Console.WriteLine($"  [{i + 1}] {dsHinh[i]}");
            }

            // Tính toán thống kê
            double tongDienTich = 0;
            double tongChuVi = 0;
            HinhChuNhat? hcnMaxDT = null;
            HinhTron? htMinCV = null;

            foreach (var h in dsHinh)
            {
                tongDienTich += h.DienTich;
                tongChuVi += h.ChuVi;

                if (h is HinhChuNhat cn)
                {
                    if (hcnMaxDT == null || cn.DienTich > hcnMaxDT.DienTich)
                    {
                        hcnMaxDT = cn;
                    }
                }
                else if (h is HinhTron tr)
                {
                    if (htMinCV == null || tr.ChuVi < htMinCV.ChuVi)
                    {
                        htMinCV = tr;
                    }
                }
            }

            Console.WriteLine("\n--- KẾT QUẢ TÍNH TOÁN & THỐNG KÊ ---");
            Console.WriteLine($"1. Tổng diện tích các hình: {tongDienTich:F2}");
            Console.WriteLine($"2. Tổng chu vi các hình:    {tongChuVi:F2}");
            if (hcnMaxDT != null)
                Console.WriteLine($"3. Hình chữ nhật có diện tích lớn nhất: {hcnMaxDT}");
            if (htMinCV != null)
                Console.WriteLine($"4. Hình tròn có chu vi nhỏ nhất:        {htMinCV}");

            // Ghi kết quả ra output.txt
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== KẾT QUẢ THỐNG KÊ DANH SÁCH HÌNH HỌC ===");
            sb.AppendLine($"Tổng diện tích: {tongDienTich:F2}");
            sb.AppendLine($"Tổng chu vi:    {tongChuVi:F2}");
            if (hcnMaxDT != null)
                sb.AppendLine($"Hình chữ nhật có diện tích lớn nhất: {hcnMaxDT}");
            if (htMinCV != null)
                sb.AppendLine($"Hình tròn có chu vi nhỏ nhất:        {htMinCV}");

            File.WriteAllText(outputFile, sb.ToString(), Encoding.UTF8);
            Console.WriteLine($"\n=> Đã xuất kết quả thành công ra file '{outputFile}'.");

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }

        static List<HinhHoc> DocFile(string filePath)
        {
            List<HinhHoc> list = new List<HinhHoc>();
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;

                string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0) continue;

                string loai = parts[0].ToUpper();
                if (loai == "HCN" && parts.Length >= 3)
                {
                    if (double.TryParse(parts[1], out double d) && double.TryParse(parts[2], out double r))
                    {
                        list.Add(new HinhChuNhat(d, r));
                    }
                }
                else if (loai == "HT" && parts.Length >= 2)
                {
                    if (double.TryParse(parts[1], out double bk))
                    {
                        list.Add(new HinhTron(bk));
                    }
                }
            }
            return list;
        }
    }
}
