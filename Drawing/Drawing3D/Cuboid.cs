using System;
using System.Drawing;
using CircuitCalculator.Geometry;
using CircuitCalculator.Imaging.Filters;

namespace CircuitCalculator.Drawing.Drawing3D
{
    public class Cuboid : Shape3D
    {
        bool _drawingLine, _fillingFace = true, _drawingImage;
        public bool DrawingLine
        {
            set { _drawingLine = value; }
            get { return _drawingLine; }
        }

        public bool FillingFace
        {
            set { _fillingFace = value; }
            get { return _fillingFace; }
        }

        public bool DrawingImage
        {
            set { _drawingImage = value; }
            get { return _drawingImage; }
        }

        readonly Color[] _faceColor = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple };
        public Color[] FaceColorArray
        {
            set
            {
                int n = Math.Min(value.Length, _faceColor.Length);
                for (int i = 0; i < n; i++)
                    _faceColor[i] = value[i];
            }
            get { return _faceColor; }
        }

        readonly Bitmap[] _bmp = new Bitmap[6];
        public Bitmap[] FaceImageArray
        {
            set
            {
                int n = Math.Min(value.Length, 6);
                for (int i = 0; i < n; i++)
                    _bmp[i] = value[i];
                SetupFilter();
            }
            get { return _bmp; }
        }

        readonly FreeTransform[] _filters =
            new FreeTransform[6];
        private void SetupFilter()
        {
            for (int i = 0; i < 6; i++)
            {
                _filters[i] = new FreeTransform();
                _filters[i].Bitmap = _bmp[i];
            }
        }

        public Cuboid(double a, double b, double c)
        {
            center = new Point3D(a / 2, b / 2, c / 2);
            Pts[0] = new Point3D(0, 0, 0);
            Pts[1] = new Point3D(a, 0, 0);
            Pts[2] = new Point3D(a, b, 0);
            Pts[3] = new Point3D(0, b, 0);
            Pts[4] = new Point3D(0, 0, c);
            Pts[5] = new Point3D(a, 0, c);
            Pts[6] = new Point3D(a, b, c);
            Pts[7] = new Point3D(0, b, c);
        }

        
        public override void Draw(Graphics g, Camera cam)
        {
            PointF[] pts2D = cam.GetProjection(Pts);

            PointF[][] face = new PointF[6][];
            face[0] = new[] { pts2D[0], pts2D[1], pts2D[2], pts2D[3] };
            face[1] = new[] { pts2D[5], pts2D[1], pts2D[0], pts2D[4] };
            face[2] = new[] { pts2D[1], pts2D[5], pts2D[6], pts2D[2] };
            face[3] = new[] { pts2D[2], pts2D[6], pts2D[7], pts2D[3] };
            face[4] = new[] { pts2D[3], pts2D[7], pts2D[4], pts2D[0] };
            face[5] = new[] { pts2D[4], pts2D[7], pts2D[6], pts2D[5] };

            for (int i = 0; i < 6; i++)
            {
                bool isout = false;
                for (int j = 0; j < 4; j++)
                {
                    if (face[i][j] == new PointF(float.MaxValue, float.MaxValue))
                    {
                        isout = true;
                    }
                }
                if (!isout)
                {
                    if (_drawingLine) g.DrawPolygon(new Pen(lineColor), face[i]);
                    if (Vector.IsClockwise(face[i][0], face[i][1], face[i][2])) // the face can be seen by camera
                    {
                        if (_fillingFace) g.FillPolygon(new SolidBrush(_faceColor[i]), face[i]);
                        if (_drawingImage && _bmp[i] != null)
                        {
                            _filters[i].FourCorners = face[i];
                            g.DrawImage(_filters[i].Bitmap, _filters[i].ImageLocation);
                        }
                    }
                }
            }
        }
    }
}
