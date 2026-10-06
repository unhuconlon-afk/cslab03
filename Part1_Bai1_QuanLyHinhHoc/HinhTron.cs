using System;

namespace Part1_Bai1_QuanLyHinhHoc
{
    public class HinhTron : HinhHoc
    {
        private double mBanKinh;

        public double BanKinh
        {
            get => mBanKinh;
            set => mBanKinh = value > 0 ? value : 0;
        }

        public HinhTron()
        {
            mBanKinh = 1;
            TinhDienTichChuVi();
        }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
            TinhDienTichChuVi();
        }

        public override void TinhDienTichChuVi()
        {
            ChuVi = 2 * Math.PI * BanKinh;
            DienTich = Math.PI * BanKinh * BanKinh;
        }

        public override string ToString()
        {
            return $"[Hình Tròn]    Bán kính: {BanKinh,5:F2} | {base.ToString()}";
        }
    }
}
