using System;

namespace Part1_Bai1_QuanLyHinhHoc
{
    public abstract class HinhHoc
    {
        public double DienTich { get; protected set; }
        public double ChuVi { get; protected set; }

        public abstract void TinhDienTichChuVi();

        public override string ToString()
        {
            return $"Chu vi: {ChuVi,8:F2} | Diện tích: {DienTich,8:F2}";
        }
    }
}
