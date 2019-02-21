using System.Drawing;

namespace CircuitCalculator.Drawing.Drawing3D
{
    public struct Point3D
    {
        public double X, Y, Z; // coordinate system follows right-hand rule

        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }

        public Point3D(Vector3D v)
        {
            X = v.X; Y = v.Y; Z = v.Z;
        }

        public Point3D Copy()
        {
            return new Point3D(X, Y, Z);
        }

        public Vector3D ToVector3D()
        {
            return new Vector3D(X, Y, Z);
        }

        public void Offset(double x, double y, double z)
        {
            X += x;
            Y += y;
            Z += z;
        }

        public static Point3D[] Copy(Point3D[] pts)
        {
            Point3D[] copy = new Point3D[pts.Length];
            for (int i = 0; i < pts.Length; i++)
            {
                copy[i] = pts[i].Copy();
            }
            return copy;
        }

        public static void Offset(Point3D[] pts, double offsetX, double offsetY, double offsetZ)
        {
            for (int i = 0; i < pts.Length; i++)
            {
                pts[i].Offset(offsetX, offsetY, offsetZ);
            }
        }

        public PointF GetProjectedPoint(double d /* project distance: from eye to screen*/)
        {
            return new PointF((float)(X * d / (d + Z)), (float)(Y * d / (d + Z)));
        }

        public static PointF[] Project(Point3D[] pts, double d /* project distance: from eye to screen*/)
        {
            PointF[] pt2Ds = new PointF[pts.Length];
            for (int i = 0; i < pts.Length; i++)
            {
                pt2Ds[i] = pts[i].GetProjectedPoint(d);
            }
            return pt2Ds;
        }
    }
}

