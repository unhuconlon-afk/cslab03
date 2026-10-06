using System;

namespace Part2_DuongTronVaDiem
{
    public class DuongTron
    {
        private Diem tam = new Diem();
        private double banKinh;

        public Diem Tam
        {
            get => tam;
            set => tam = value ?? new Diem();
        }

        public double BanKinh
        {
            get => banKinh;
            set => banKinh = value > 0 ? value : 0;
        }

        public DuongTron()
        {
            tam = new Diem();
            banKinh = 0;
        }

        public DuongTron(Diem t, double r)
        {
            Tam = t;
            BanKinh = r;
        }

        public DuongTron(DuongTron dt)
        {
            Tam = new Diem(dt.Tam);
            BanKinh = dt.BanKinh;
        }

        public double ChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public double DienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }

        public void Xuat()
        {
            Console.WriteLine($"Đường tròn: Tâm {Tam}, Bán kính R = {BanKinh:F2} | Chu vi = {ChuVi():F2} | Diện tích = {DienTich():F2}");
        }

        public override string ToString()
        {
            return $"Đường tròn [Tâm {Tam}, R = {BanKinh:F2}]";
        }

        /// <summary>
        /// Kiểm tra vị trí tương đối giữa hai đường tròn
        /// </summary>
        public string ViTriTuongDoiVoi(DuongTron dt2)
        {
            double d = Tam.KhoangCach(dt2.Tam);
            double r1 = BanKinh;
            double r2 = dt2.BanKinh;

            if (d < 1e-9 && Math.Abs(r1 - r2) < 1e-9)
                return "Hai đường tròn trùng nhau.";

            if (d < 1e-9)
                return "Hai đường tròn đồng tâm.";

            if (d > r1 + r2)
                return "Hai đường tròn ở ngoài nhau (không giao nhau).";

            if (Math.Abs(d - (r1 + r2)) < 1e-9)
                return "Hai đường tròn tiếp xúc ngoài.";

            if (Math.Abs(d - Math.Abs(r1 - r2)) < 1e-9)
                return "Hai đường tròn tiếp xúc trong.";

            if (d < Math.Abs(r1 - r2))
                return "Một đường tròn đựng (chứa trong) đường tròn kia.";

            return "Hai đường tròn cắt nhau tại 2 điểm.";
        }

        /// <summary>
        /// Kiểm tra vị trí tương đối của điểm P với đường tròn
        /// </summary>
        public string ViTriDiem(Diem p)
        {
            double d = Tam.KhoangCach(p);
            if (Math.Abs(d - BanKinh) < 1e-9)
                return $"Điểm {p} nằm TRÊN đường tròn.";
            if (d < BanKinh)
                return $"Điểm {p} nằm TRONG đường tròn.";
            return $"Điểm {p} nằm NGOÀI đường tròn.";
        }
    }
}
