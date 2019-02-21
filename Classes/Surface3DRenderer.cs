using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using ZedGraph;

namespace CircuitCalculator.Plot3D
{
    public class  Surface3DRenderer
    {
        double screenDistance, sf, cf, st, ct, R, A, B, C, D; // Transformation coefficients
        double density = 0.5f;
        Color penColor = Color.Black;
        PointF startPoint = new PointF(-20, -20);
        PointF endPoint = new PointF(20, 20);
        RendererFunction function = defaultFunction;
        ColorSchema colorSchema = ColorSchema.Autumn;

        #region Properties

        /// <summary>
        /// Surface spanning net density
        /// </summary>
        public double Density { get { return density; } set { density = value; } }
        /// <summary>
        /// Quadrilateral pen color
        /// </summary>
        public Color PenColor { get { return penColor; } set { penColor = value; } }
        /// <summary>
        /// Gets or sets the start point.
        /// </summary>
        public PointF StartPoint { get { return startPoint; } set { startPoint = value; } }
        /// <summary>
        /// Gets or sets the end point.
        /// </summary>
        public PointF EndPoint { get { return endPoint; } set { endPoint = value; } }
        /// <summary>
        /// Gets or sets the render function.
        /// </summary>
        public RendererFunction Function { get { return function; } set { function = value; } }
        /// <summary>
        /// Gets or sets the color schema.
        /// </summary>
        public ColorSchema ColorSchema { get { return colorSchema; } set { colorSchema = value; } }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Surface3DRenderer"/> class. Calculates transformation coefficients.
        /// </summary>
        /// <param name="obsX">Observator's X position</param>
        /// <param name="obsY">Observator's Y position</param>
        /// <param name="obsZ">Observator's Z position</param>
        /// <param name="xs0">X coordinate of screen</param>
        /// <param name="ys0">Y coordinate of screen</param>
        /// <param name="screenWidth">Drawing area width in pixels.</param>
        /// <param name="screenHeight">Drawing area height in pixels.</param>
        /// <param name="screenDistance">The screen distance.</param>
        /// <param name="screenWidthPhys">Width of the screen in meters.</param>
        /// <param name="screenHeightPhys">Height of the screen in meters.</param>
        public Surface3DRenderer(double obsX, double obsY, double obsZ, int xs0, int ys0, int screenWidth, int screenHeight, double screenDistance, double screenWidthPhys, double screenHeightPhys)
        {
            ReCalculateTransformationCoefficients(obsX, obsY, obsZ, xs0, ys0, screenWidth, screenHeight, screenDistance, screenWidthPhys, screenHeightPhys);
        }

        public void ReCalculateTransformationCoefficients(double obsX, double obsY, double obsZ, int xs0, int ys0, int screenWidth, int screenHeight, double screenDistance, double screenWidthPhys, double screenHeightPhys)
        {
            double r1, a;

            if (screenWidthPhys <= 0)//when screen dimensions are not specified
                screenWidthPhys = screenWidth * 0.0257 / 72.0;        //0.0257 m = 1 inch. Screen has 72 px/inch
            if (screenHeightPhys <= 0)
                screenHeightPhys = screenHeight * 0.0257 / 72.0;

            r1 = obsX * obsX + obsY * obsY;
            a = Math.Sqrt(r1);//distance in XY plane
            R = Math.Sqrt(r1 + obsZ * obsZ);//distance from observator to center
            if (a != 0) //rotation matrix coeficients calculation
            {
                sf = obsY / a;//sin( fi)
                cf = obsX / a;//cos( fi)
            }
            else
            {
                sf = 0;
                cf = 1;
            }
            st = a / R;//sin( teta)
            ct = obsZ / R;//cos( teta)

            //linear tranfrormation coeficients
            A = screenWidth / screenWidthPhys;
            B = xs0 + A * screenWidthPhys / 2.0;
            C = -(double)screenHeight / screenHeightPhys;
            D = ys0 - C * screenHeightPhys / 2.0;

            this.screenDistance = screenDistance;
        }

        /// <summary>
        /// Performs projection. Calculates screen coordinates for 3D point.
        /// </summary>
        /// <param name="x">Point's x coordinate.</param>
        /// <param name="y">Point's y coordinate.</param>
        /// <param name="z">Point's z coordinate.</param>
        /// <returns>Point in 2D space of the screen.</returns>
        public PointF Project(double x, double y, double z)
        {
            double xn, yn, zn;//point coordinates in computer's frame of reference

            //transformations
            xn = -sf * x + cf * y;
            yn = -cf * ct * x - sf * ct * y + st * z;
            zn = -cf * st * x - sf * st * y - ct * z + R;

            if (zn == 0) zn = 0.01;

            //Thales' theorem (http://en.wikipedia.org/wiki/Thales%27_theorem)
            return new PointF((float)(A * xn * screenDistance / zn + B), (float)(C * yn * screenDistance / zn + D));
        }
        /// <summary>
        /// Renders the surface from a function.
        /// </summary>
        /// <param name="graphics">The drawing surface.</param>
        public void RenderSurface(Graphics graphics)
        {
            SolidBrush[] brushes = new SolidBrush[colorSchema.Length];
            for (int i = 0; i < brushes.Length; i++)
                brushes[i] = new SolidBrush(colorSchema[i]);
                        
            double z1, z2;
            PointF[] polygon = new PointF[4];

            double xi = startPoint.X, yi, minZ = double.PositiveInfinity, maxZ = double.NegativeInfinity;
            double[,] mesh = new double[(int)((endPoint.X - startPoint.X) / density + 1), (int)((endPoint.Y - startPoint.Y) / density + 1)];
            PointF[,] meshF = new PointF[mesh.GetLength(0), mesh.GetLength(1)];
            for (int x = 0; x < mesh.GetLength(0); x++)
            {
                yi = startPoint.Y;
                for (int y = 0; y < mesh.GetLength(1); y++)
                {
                    double zz = function(xi, yi);//get the z point
                    mesh[x, y] = zz; //create against the list
                    meshF[x, y] = Project(xi, yi, zz);//compile the list
                    yi += density;

                    if (minZ > zz) minZ = zz;
                    if (maxZ < zz) maxZ = zz;
                }
                xi += density;
            }

            double cc = (maxZ - minZ) / (brushes.Length - 1.0);

            using (Pen pen = new Pen(penColor))
                for (int x = 0; x < mesh.GetLength(0) - 1; x++)
                {
                    for (int y = 0; y < mesh.GetLength(1) - 1; y++)
                    {
                        z1 = mesh[x, y];
                        z2 = mesh[x, y + 1];

                        polygon[0] = meshF[x, y];
                        polygon[1] = meshF[x, y + 1];
                        polygon[2] = meshF[x + 1, y + 1];
                        polygon[3] = meshF[x + 1, y];

                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.FillPolygon(brushes[(int)(((z1 + z2) / 2.0 - minZ) / cc)], polygon);

                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.DrawPolygon(pen, polygon);
                    }
                }
            for (int i = 0; i < brushes.Length; i++)
                brushes[i].Dispose();
        }

        public void RenderSurface(Graphics graphics, DataTable source)
        {
            SolidBrush[] brushes = new SolidBrush[colorSchema.Length];
            for (int i = 0; i < brushes.Length; i++)
                brushes[i] = new SolidBrush(colorSchema[i]);

            double z1, z2;
            PointF[] polygon = new PointF[4];

            double xi = startPoint.X, yi, minZ = double.PositiveInfinity, maxZ = double.NegativeInfinity;
            double[,] mesh = new double[(int)((endPoint.X - startPoint.X) / density + 1), (int)((endPoint.Y - startPoint.Y) / density + 1)];
            PointF[,] meshF = new PointF[mesh.GetLength(0), mesh.GetLength(1)];
            double xii, yii, zii;
            foreach (DataRow row in source.Rows)
            {
                xii = (double)row["X"];
                yii = (double)row["Y"];
                zii = (double)row["Z"];
                //plotList.Add(xii, yii);
            }
            for (int x = 0; x < mesh.GetLength(0); x++)
            {
                yi = startPoint.Y;
                for (int y = 0; y < mesh.GetLength(1); y++)
                {

                    //PointPairList plotList = new PointPairList();
                    //PointPair4 more = new PointPair4();

                    
                    //double zz = function(xi, yi);//get the z point
                    //mesh[x, y] = zz; //create against the list
                   // meshF[x, y] = Project(xii, yii, zii);//compile the list
                    
                    
                    yi += density;

                    //if (minZ > zii) minZ = zii;
                    //if (maxZ < zii) maxZ = zii;
                }
                xi += density;
            }

            double cc = (maxZ - minZ) / (brushes.Length - 1.0);

            using (Pen pen = new Pen(penColor))
                for (int x = 0; x < mesh.GetLength(0) - 1; x++)
                {
                    for (int y = 0; y < mesh.GetLength(1) - 1; y++)
                    {
                        z1 = mesh[x, y];
                        z2 = mesh[x, y + 1];

                        polygon[0] = meshF[x, y];
                        polygon[1] = meshF[x, y + 1];
                        polygon[2] = meshF[x + 1, y + 1];
                        polygon[3] = meshF[x + 1, y];

                        graphics.SmoothingMode = SmoothingMode.None;
                        graphics.FillPolygon(brushes[(int)(((z1 + z2) / 2.0 - minZ) / cc)], polygon);

                        graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        graphics.DrawPolygon(pen, polygon);
                    }
                }
            for (int i = 0; i < brushes.Length; i++)
                brushes[i].Dispose();
        }

        public static RendererFunction GetFunctionHandle(string formula)
        {
            CompiledFunction fn = FunctionCompiler.Compile(2, formula);
            return new RendererFunction(delegate(double x, double y)
            {
                return fn(x, y);
            });
        }

        public void SetFunction(string formula)
        {
            function = GetFunctionHandle(formula);
        }

        private static double defaultFunction(double a, double b)
        {
            double an = a, bn = b, anPlus1;
            short iter = 0;
            do
            {
                anPlus1 = (an + bn) / 2.0;
                bn = Math.Sqrt(an * bn);
                an = anPlus1;
                if (iter++ > 1000) return an;
            } while (Math.Abs(an - bn)<0.1);
            return an;
        }
    }

    public delegate double RendererFunction(double x, double y);

    public struct Point3D
    {
        public double x, y, z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}