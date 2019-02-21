using System;

namespace CircuitCalculator.Drawing.Drawing3D
{
    /// <summary>
    /// 
    /// </summary>
    public struct Vector3D
    {
        public double X, Y, Z;
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> struct.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        public Vector3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> struct.
        /// </summary>
        /// <param name="point3D"></param>
        public Vector3D(Point3D point3D)
        {
            X = point3D.X; Y = point3D.Y; Z = point3D.Z;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> struct.
        /// </summary>
        /// <param name="startPoint">The start point.</param>
        /// <param name="endPoint">The end point.</param>
        public Vector3D(Point3D startPoint, Point3D endPoint)
        {
            X = endPoint.X - startPoint.X;
            Y = endPoint.Y - startPoint.Y;
            Z = endPoint.Z - startPoint.Z;
        }

        /// <summary>
        /// Gets the magnitude.
        /// </summary>
        /// <value>
        /// The magnitude.
        /// </value>
        public double Magnitude
        {
            get { return Math.Sqrt(X * X + Y * Y + Z * Z); }
        }

        /// <summary>
        /// Normalises this instance.
        /// </summary>
        public void Normalise()
        {
            double m = Math.Sqrt(X * X + Y * Y + Z * Z);
            if (m > 0.001)
            {
                X /= m; Y /= m; Z /= m;
            }
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3D operator -(Vector3D v)
        {
            return new Vector3D(-v.X, -v.Y, -v.Z);
        }

        // A x B = |A|*|B|*sin(angle), direction follow right-hand rule
        public static Vector3D CrossProduct(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static double DotProduct(Vector3D v1, Vector3D v2) // A . B = |A|*|B|*cos(angle)
        {
            return (v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z);
        }

        public Vector3D CrossProduct(Vector3D v)
        {
            return CrossProduct(this, v);
        }

        public double DotProduct(Vector3D v)
        {
            return DotProduct(this, v);
        }

        public static bool IsForeFace(Point3D pt1, Point3D pt2, Point3D pt3) // pts on a plane
        {
            Vector3D v1 = new Vector3D(pt2, pt1);
            Vector3D v2 = new Vector3D(pt2, pt3);
            Vector3D v = v1.CrossProduct(v2);
            return v.DotProduct(new Vector3D(0, 0, 1)) < 0;
        }

        /// <summary>
        /// Determines whether [is back face] [the specified PT1].
        /// </summary>
        /// <param name="pt1">The PT1.</param>
        /// <param name="pt2">The PT2.</param>
        /// <param name="pt3">The PT3.</param>
        /// <returns></returns>
        public static bool IsBackFace(Point3D pt1, Point3D pt2, Point3D pt3)
        {
            Vector3D v1 = new Vector3D(pt2, pt1);
            Vector3D v2 = new Vector3D(pt2, pt3);
            Vector3D v = v1.CrossProduct(v2);
            return v.DotProduct(new Vector3D(0, 0, 1)) > 0;
        }
    }
}
