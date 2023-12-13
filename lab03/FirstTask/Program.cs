using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirtTask
{
    public struct Vector
    {
        public double X;
        public double Y;
        public double Z;
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.X + vec2.X, vec1.Y + vec2.Y, vec1.Z + vec2.Z);
        }
        // maybe dot x * x + y * y + z * z
        public static Vector operator *(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.X * vec2.X, vec1.Y * vec2.Y, vec1.Z * vec2.Z);
        }
        public static Vector operator *(Vector vec, double number)
        {
            return new Vector(vec.X * number, vec.Y * number, vec.Z * number);
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }
        public static bool operator <(Vector vec1, Vector vec2)
        {
            return vec1.Length() < vec2.Length();
        }
        public static bool operator >(Vector vec1, Vector vec2)
        {
            return vec1.Length() > vec2.Length();
        }
        public static bool operator ==(Vector vec1, Vector vec2)
        {
            return vec1.Length() == vec2.Length();
        }
        public static bool operator !=(Vector vec1, Vector vec2)
        {
            return vec1.Length() != vec2.Length();
        }
        public static bool operator <=(Vector vec1, Vector vec2)
        {
            return vec1.Length() <= vec2.Length();
        }
        public static bool operator >=(Vector vec1, Vector vec2)
        {
            return vec1.Length() >= vec2.Length();
        }

        public override string ToString()
        {
            return X.ToString() + " " + Y.ToString() + " " + Z.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(11, 22, 33);
            Vector b = new Vector(44, 55, 66);
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(a + b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a * 1.5);
            Console.WriteLine(a.Length());
            Console.WriteLine(b.Length());
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
        }
    }
}