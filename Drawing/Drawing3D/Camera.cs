using System;
using System.Drawing;

namespace CircuitCalculator.Drawing.Drawing3D
{ 
    //orintation vector (0,0,-1)
    public class Camera
    {
        Point3D _loc = new Point3D(0, 0, 0);
        double _d = 500.0;
        Quaternion _quan = new Quaternion(1, 0, 0, 0);

        public Point3D Location
        {
            set { _loc = value; }
            get { return _loc; }
        }

        public double FocalDistance
        {
            set { _d = value; }
            get { return _d; }
        }

        public Quaternion Quaternion
        {
            set { _quan = value; }
            get { return _quan; }
        }

        public void MoveRight(double d)
        {
            _loc.X += d;
        }

        public void MoveLeft(double d)
        {
            _loc.X -= d;
        }

        public void MoveUp(double d)
        {
            _loc.Y -= d;
        }

        public void MoveDown(double d)
        {
            _loc.Y += d;
        }

        public void MoveIn(double d)
        {
            _loc.Z += d;
        }

        public void MoveOut(double d)
        {
            _loc.Z -= d;
        }

        public void Roll(int degree) // rotate around Z axis
        {
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(0, 0, 1), degree * Math.PI / 180.0);
            _quan = q * _quan;
        }

        public void Yaw(int degree)  // rotate around Y axis
        {
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(0, 1, 0), degree * Math.PI / 180.0);
            _quan = q * _quan;
        }

        public void Pitch(int degree) // rotate around X axis
        {
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(1, 0, 0), degree * Math.PI / 180.0);
            _quan = q * _quan;
        }

        public void TurnUp(int degree)
        {
            Pitch(-degree);
        }

        public void TurnDown(int degree)
        {
            Pitch(degree);
        }

        public void TurnLeft(int degree)
        {
            Yaw(degree);
        }

        public void TurnRight(int degree)
        {
            Yaw(-degree);
        }

        public PointF[] GetProjection(Point3D[] pts)
        {
            PointF[] pt2Ds = new PointF[pts.Length];

            // transform to new coordinates system which origin is camera location
            Point3D[] pts1 = Point3D.Copy(pts);
            Point3D.Offset(pts1, -_loc.X, -_loc.Y, -_loc.Z);

            // rotate
            _quan.Rotate(pts1);

            //project
            for (int i = 0; i < pts.Length; i++)
            {
                if (pts1[i].Z > 0.1)
                {
                    pt2Ds[i] = new PointF((float)(_loc.X + pts1[i].X * _d / pts1[i].Z),
                        (float)(_loc.Y + pts1[i].Y * _d / pts1[i].Z));
                }
                else
                {
                    pt2Ds[i] = new PointF(float.MaxValue, float.MaxValue);
                }
            }
            return pt2Ds;
        }
    }
}
