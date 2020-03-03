using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }

    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X*vector.X + vector.Y*vector.Y);
        }

        public static Vector Add(Vector a, Vector b)
        {
            var result = new Vector();
            result.X = a.X + b.X;
            result.Y = a.Y + b.Y;

            return result;
        }
    }
}
