using System;
using System.Text;

namespace Part1_Bai3_LopDaThuc
{
    public class DaThuc
    {
        private double[] _heSo;

        // Property bậc của đa thức
        public int Bac
        {
            get => _heSo.Length - 1;
        }

        // Indexer truy cập hệ số bậc k: this[int k]
        public double this[int k]
        {
            get
            {
                if (k >= 0 && k <= Bac)
                    return _heSo[k];
                return 0;
            }
            set
            {
                if (k >= 0 && k <= Bac)
                    _heSo[k] = value;
                else
                    throw new IndexOutOfRangeException($"Bậc {k} vượt quá giới hạn bậc của đa thức [0, {Bac}]!");
            }
        }

        // Khởi tạo đa thức bậc n với các hệ số đều bằng 0
        public DaThuc(int n)
        {
            if (n < 0) n = 0;
            _heSo = new double[n + 1];
        }

        // Khởi tạo đa thức từ mảng hệ số truyền vào
        public DaThuc(double[] heSo)
        {
            if (heSo == null || heSo.Length == 0)
            {
                _heSo = new double[1];
            }
            else
            {
                _heSo = new double[heSo.Length];
                Array.Copy(heSo, _heSo, heSo.Length);
            }
        }

        // Tính giá trị đa thức khi x = b: P(b)
        public double TinhGiaTri(double b)
        {
            double ketQua = 0;
            for (int k = 0; k <= Bac; k++)
            {
                ketQua += _heSo[k] * Math.Pow(b, k);
            }
            return ketQua;
        }

        // Toán tử cộng 2 đa thức: P1 + P2
        public static DaThuc operator +(DaThuc d1, DaThuc d2)
        {
            int maxBac = Math.Max(d1.Bac, d2.Bac);
            DaThuc ketQua = new DaThuc(maxBac);
            for (int k = 0; k <= maxBac; k++)
            {
                ketQua[k] = d1[k] + d2[k];
            }
            return ketQua;
        }

        // Toán tử trừ 2 đa thức: P1 - P2
        public static DaThuc operator -(DaThuc d1, DaThuc d2)
        {
            int maxBac = Math.Max(d1.Bac, d2.Bac);
            DaThuc ketQua = new DaThuc(maxBac);
            for (int k = 0; k <= maxBac; k++)
            {
                ketQua[k] = d1[k] - d2[k];
            }
            return ketQua;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            bool daCoHangTu = false;

            for (int k = Bac; k >= 0; k--)
            {
                double a = _heSo[k];
                if (Math.Abs(a) < 1e-9) continue;

                if (!daCoHangTu)
                {
                    if (a < 0) sb.Append("-");
                    daCoHangTu = true;
                }
                else
                {
                    sb.Append(a > 0 ? " + " : " - ");
                }

                double absA = Math.Abs(a);
                if (k == 0)
                {
                    sb.Append(absA);
                }
                else if (k == 1)
                {
                    if (Math.Abs(absA - 1) < 1e-9)
                        sb.Append("x");
                    else
                        sb.Append($"{absA}x");
                }
                else
                {
                    if (Math.Abs(absA - 1) < 1e-9)
                        sb.Append($"x^{k}");
                    else
                        sb.Append($"{absA}x^{k}");
                }
            }

            if (!daCoHangTu) return "0";
            return sb.ToString();
        }
    }
}
