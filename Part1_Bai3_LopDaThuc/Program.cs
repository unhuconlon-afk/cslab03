using System;
using System.Text;

namespace Part1_Bai3_LopDaThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("         BÀI TẬP 3: XÂY DỰNG LỚP ĐA THỨC (DATHUC) BẬC N       ");
            Console.WriteLine("==============================================================");

            // 1. Khởi tạo đa thức P1 bậc 3: P1 = 3x^3 + 2x^2 - 5x + 4
            Console.WriteLine("\n--- 1. KHỞI TẠO ĐA THỨC P1 BẬC 3 (DÙNG INDEXER ĐỂ GÁN HỆ SỐ) ---");
            DaThuc p1 = new DaThuc(3);
            p1[3] = 3;
            p1[2] = 2;
            p1[1] = -5;
            p1[0] = 4;
            Console.WriteLine($"P1(x) = {p1}");
            Console.WriteLine($"Bậc của P1: {p1.Bac}");

            // 2. Khởi tạo đa thức P2 bậc 2: P2 = 4x^2 + 5x - 2
            Console.WriteLine("\n--- 2. KHỞI TẠO ĐA THỨC P2 BẬC 2 ---");
            DaThuc p2 = new DaThuc(new double[] { -2, 5, 4 }); // a0 = -2, a1 = 5, a2 = 4
            Console.WriteLine($"P2(x) = {p2}");
            Console.WriteLine($"Bậc của P2: {p2.Bac}");

            // 3. Phép toán cộng đa thức: P_Tong = P1 + P2
            Console.WriteLine("\n--- 3. PHÉP TOÁN CỘNG ĐA THỨC (P1 + P2) ---");
            DaThuc pTong = p1 + p2;
            Console.WriteLine($"P1(x) + P2(x) = {pTong}");

            // 4. Phép toán trừ đa thức: P_Hieu = P1 - P2
            Console.WriteLine("\n--- 4. PHÉP TOÁN TRỪ ĐA THỨC (P1 - P2) ---");
            DaThuc pHieu = p1 - p2;
            Console.WriteLine($"P1(x) - P2(x) = {pHieu}");

            // 5. Tính giá trị đa thức khi x = b
            Console.WriteLine("\n--- 5. TÍNH GIÁ TRỊ ĐA THỨC KHI X = B ---");
            double b = 2.0;
            double valP1 = p1.TinhGiaTri(b);
            double valP2 = p2.TinhGiaTri(b);
            Console.WriteLine($"Khi x = {b}:");
            Console.WriteLine($"  P1({b}) = {valP1}");
            Console.WriteLine($"  P2({b}) = {valP2}");

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }
    }
}
