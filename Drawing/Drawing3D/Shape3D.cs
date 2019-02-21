using System.Drawing;

namespace CircuitCalculator.Drawing.Drawing3D
{
    public class Shape3D
    {
       protected Point3D[] Pts = new Point3D[8];
        public Point3D[] Point3DArray
        {
            get { return Pts; }
        }

        protected Point3D center = new Point3D(0, 0, 0);
        public Point3D Center
        {
            set
            {
                double dx = value.X - center.X;
                double dy = value.Y - center.Y;
                double dz = value.Z - center.Z;
                Point3D.Offset(Pts, dx, dy, dz);
                center = value;
            }
            get { return center; }
        }

        protected Color lineColor = Color.Black;
        public Color LineColor
        {
            set { lineColor = value; }
            get { return lineColor; }
        }

        public void RotateAt(Point3D pt, Quaternion q)
        {
            // transform origin to pt
            Point3D[] copy = Point3D.Copy(Pts);
            Point3D.Offset(copy,  - pt.X,  - pt.Y,  - pt.Z);

            // rotate
            q.Rotate(copy);
            q.Rotate(center);

            // transform to original origin
            Point3D.Offset(copy, pt.X, pt.Y, pt.Z);
            Pts = copy;
        }
        
        public virtual void Draw(Graphics g,Camera cam)
        {
        }
    }
}
