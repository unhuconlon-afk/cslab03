using System;

namespace Part1_Bai1_QuanLyHinhHoc
{
    public class HinhChuNhat : HinhHoc
    {
        private double mChieuDai;
        private double mChieuRong;

        public double ChieuDai
        {
            get => mChieuDai;
            set => mChieuDai = value > 0 ? value : 0;
        }

        public double ChieuRong
        {
            get => mChieuRong;
            set => mChieuRong = value > 0 ? value : 0;
        }

        public HinhChuNhat()
        {
            mChieuDai = 1;
            mChieuRong = 1;
            TinhDienTichChuVi();
        }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
            TinhDienTichChuVi();
        }

        public override void TinhDienTichChuVi()
        {
            DienTich = ChieuDai * ChieuRong;
            ChuVi = (ChieuDai + ChieuRong) * 2;
        }

        public override string ToString()
        {
            return $"[Hình Chữ Nhật] Dài: {ChieuDai,6:F2} | Rộng: {ChieuRong,6:F2} | {base.ToString()}";
        }
    }
}
