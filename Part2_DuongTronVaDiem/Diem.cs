using System;

namespace Part2_DuongTronVaDiem
{
    public class Diem
    {
        private double x;
        private double y;

        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public Diem(Diem p)
        {
            x = p.X;
            y = p.Y;
        }

        public double KhoangCach(Diem b)
        {
            return Math.Sqrt(Math.Pow(x - b.X, 2) + Math.Pow(y - b.Y, 2));
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
