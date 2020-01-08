using System;
using System.Drawing;

namespace vector
{
    public class Vector
    {
        private dynamic x, y;
        public Vector()
        {
            this.x = 0;
            this.y = 0;
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector(Point p)
        {
            this.x = p.X;
            this.y = p.Y;
        }
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public dynamic X
        {
            get { return this.x; }
            set
            {
                if (value == (int)value || value == (double)value)
                {
                    this.x = value;
                }
            }
        }
        public dynamic Y
        {
            get { return this.y; }
            set
            {
                if (value == (int)value || value == (double)value)
                {
                    this.y = value;
                }
            }
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        public static Vector operator +(Vector a, int b)
        {
            return new Vector(a.X + b, a.Y + b);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        public static Vector operator *(Vector a, int x)
        {
            return new Vector(a.X * x, a.Y * x);
        }
        public static Vector operator /(Vector a, int x)
        {
            return new Vector(a.X / x, a.Y / x);
        }
        public static explicit operator Vector(Point b)
        {
            Vector a = new Vector(b);
            return a;
        }
        public void Offset(Vector b)
        {
            this.X = this.X + b.X;
            this.Y = this.Y + b.Y;
        }
        public bool Equals(Vector b)
        {
            return this.X == b.X && this.Y == b.Y;
        }
        public Point ToPoint()
        {
            return new Point(this.X, this.Y);
        }



    }
    static class Program
    {

        static void Main()
        {
            Vector v = new Vector();
        }
    }
}
