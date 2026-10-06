using System;
using System.Text;

namespace Part2_DuongTronVaDiem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("==============================================================");
            Console.WriteLine("       PHẦN 2: XÂY DỰNG LỚP ĐIỂM & ĐƯỜNG TRÒN TRONG OXY       ");
            Console.WriteLine("==============================================================");

            // 1. Thử nghiệm khởi tạo các đường tròn
            Console.WriteLine("\n--- 1. KHỞI TẠO VÀ XUẤT THÔNG TIN ĐƯỜNG TRÒN ---");
            DuongTron dt1 = new DuongTron();
            Console.Write("dt1 (Mặc định): ");
            dt1.Xuat();

            Diem point = new Diem(1, 3);
            DuongTron dt2 = new DuongTron(point, 10);
            Console.Write("dt2 (Tâm (1,3), R=10): ");
            dt2.Xuat();

            DuongTron dt3 = new DuongTron(dt2);
            Console.Write("dt3 (Sao chép dt2): ");
            dt3.Xuat();

            // 2. Thử nghiệm vị trí tương đối giữa 2 đường tròn
            Console.WriteLine("\n--- 2. KIỂM TRA VỊ TRÍ TƯƠNG ĐỐI GIỮA HAI ĐƯỜNG TRÒN ---");
            DuongTron c1 = new DuongTron(new Diem(0, 0), 5);
            DuongTron c2 = new DuongTron(new Diem(8, 0), 3);
            DuongTron c3 = new DuongTron(new Diem(10, 0), 2);

            Console.WriteLine($"C1: {c1}");
            Console.WriteLine($"C2: {c2}");
            Console.WriteLine($"C3: {c3}");

            Console.WriteLine($"\n• Vị trí giữa C1 và C2 (d=8, R1+R2=8): => {c1.ViTriTuongDoiVoi(c2)}");
            Console.WriteLine($"• Vị trí giữa C1 và C3 (d=10, R1+R3=7): => {c1.ViTriTuongDoiVoi(c3)}");

            // 3. Thử nghiệm vị trí tương đối của điểm với đường tròn
            Console.WriteLine("\n--- 3. KIỂM TRA VỊ TRÍ CỦA ĐIỂM VỚI ĐƯỜNG TRÒN ---");
            Diem pIn = new Diem(1, 1);
            Diem pOn = new Diem(5, 0);
            Diem pOut = new Diem(7, 7);

            Console.WriteLine($"Xét đường tròn C1 {c1}:");
            Console.WriteLine($"• Điểm {pIn}:  => {c1.ViTriDiem(pIn)}");
            Console.WriteLine($"• Điểm {pOn}:  => {c1.ViTriDiem(pOn)}");
            Console.WriteLine($"• Điểm {pOut}: => {c1.ViTriDiem(pOut)}");

            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("\nBấm phím bất kỳ để kết thúc...");
                Console.ReadKey(true);
            }
        }
    }
}
