using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lab03_Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                if (!Console.IsInputRedirected)
                    Console.Clear();

                Console.WriteLine("============================================================================");
                Console.WriteLine("     TRƯỜNG ĐH SƯ PHẠM TP.HCM - KHOA CÔNG NGHỆ THÔNG TIN                   ");
                Console.WriteLine("          MÔN HỌC: LẬP TRÌNH WINDOWS VỚI C# (WINDOWS PROGRAMMING)          ");
                Console.WriteLine("                BÁO CÁO LAB 03: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG (OOP)             ");
                Console.WriteLine("============================================================================");
                Console.WriteLine("  1. Bài 1: Quản lý Hình học (Kế thừa HinhHoc -> HinhChuNhat, HinhTron, File I/O)");
                Console.WriteLine("  2. Bài 2: Quản lý Nhân sự (Kế thừa Nguoi -> SinhVien, NhanVien)");
                Console.WriteLine("  3. Bài 3: Lớp Đa thức bậc n (DaThuc: Indexer, Toán tử +, -, TinhGiaTri)");
                Console.WriteLine("  4. Phần 2: Lớp Điểm và Đường tròn trong Oxy (Diem & DuongTron)");
                Console.WriteLine("  0. Thoát chương trình");
                Console.WriteLine("============================================================================");
                Console.Write("Mời bạn chọn bài tập cần thực thi (0 - 4): ");

                string? choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice) || choice == "0")
                {
                    Console.WriteLine("\nCảm ơn bạn đã sử dụng chương trình!");
                    break;
                }

                string folder = "";
                switch (choice)
                {
                    case "1": folder = "Part1_Bai1_QuanLyHinhHoc"; break;
                    case "2": folder = "Part1_Bai2_QuanLyNhanSu"; break;
                    case "3": folder = "Part1_Bai3_LopDaThuc"; break;
                    case "4": folder = "Part2_DuongTronVaDiem"; break;
                    default:
                        Console.WriteLine("\nLựa chọn không hợp lệ!");
                        DungManHinh();
                        continue;
                }

                ChayDuAn(folder);
                DungManHinh();

                if (Console.IsInputRedirected) break;
            }
        }

        static void DungManHinh()
        {
            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để tiếp tục...");
                Console.ReadKey(true);
            }
        }

        static void ChayDuAn(string folderName)
        {
            Console.WriteLine($"\n>>> ĐANG KHỞI CHẠY {folderName}... <<<\n");

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string solutionDir = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", ".."));
            string projectPath = Path.Combine(solutionDir, folderName, $"{folderName}.csproj");

            if (!File.Exists(projectPath))
            {
                projectPath = Path.Combine(Directory.GetCurrentDirectory(), folderName, $"{folderName}.csproj");
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"run --project \"{projectPath}\"",
                UseShellExecute = false,
                CreateNoWindow = false
            };

            try
            {
                using (Process? process = Process.Start(psi))
                {
                    process?.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi chạy dự án: {ex.Message}");
            }
        }
    }
}
