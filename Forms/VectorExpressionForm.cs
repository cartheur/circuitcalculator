using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CircuitCalculator.Drawing.Drawing3D;

namespace CircuitCalculator.Forms
{
    public partial class VectorExpressionForm : Form
    {
        private Form _owner;
        private static bool _instance;
        // Orientation
        Bitmap[] _bmp = new Bitmap[6];
        int _i;
        int _cameraX, _cameraY, _cameraZ, _cubeX, _cubeY, _cubeZ;
        Cuboid _cub = new Cuboid(150, 150, 150);
        Camera _cam = new Camera();

        public VectorExpressionForm(Form mOwner)
        {
            InitializeComponent();
            _owner = mOwner;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            ControlBox = false;
            _instance = true;
        }
        private void vectorExpressionForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;

            _cub.Center = new Point3D(400, 240, 0);
            _cam.Location = new Point3D(400, 240, -500);
            Invalidate();
        }
        private void vectorExpressionForm_Paint(object sender, PaintEventArgs e)
        {
            _cub.Draw(e.Graphics, _cam);
        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return _instance; } set { _instance = value; } }
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            _instance = false;
            Close();
        }

        #region Click Events
        private void button12_Click(object sender, EventArgs e)
        {
            _cubeX += 5;
            labelCrX.Text = _cubeX.ToString(CultureInfo.InvariantCulture);
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(1, 0, 0), 5*Math.PI/180.0);
            _cub.RotateAt(_cub.Center, q);
            Invalidate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _cubeX -= 5;
            labelCrX.Text = _cubeX.ToString(CultureInfo.InvariantCulture);
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(1, 0, 0), -5 * Math.PI / 180.0);
            _cub.RotateAt(_cub.Center, q);
            Invalidate();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _cubeY+= 5;
            labelCrY.Text = _cubeY.ToString(CultureInfo.InvariantCulture);
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(0, 1, 0), 5 * Math.PI / 180.0);
            _cub.RotateAt(_cub.Center, q);
            Invalidate();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _cubeY -= 5;
            labelCrY.Text = _cubeY.ToString(CultureInfo.InvariantCulture);
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(0, 1, 0), -5 * Math.PI / 180.0);
            _cub.RotateAt(_cub.Center, q);
            Invalidate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _cubeZ += 5;
            labelCrZ.Text = _cubeZ.ToString(CultureInfo.InvariantCulture);
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(0, 0, 1), 5 * Math.PI / 180.0);
            _cub.RotateAt(_cub.Center, q);
            Invalidate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _cubeZ -= 5;
            labelCrZ.Text = _cubeZ.ToString(CultureInfo.InvariantCulture);
            Quaternion q = new Quaternion();
            q.FromAxisAngle(new Vector3D(0, 0, 1), -5 * Math.PI / 180.0);
            _cub.RotateAt(_cub.Center, q);
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cam.MoveLeft(10);
            Invalidate();
            labelMx.Text = _cam.Location.X.ToString(CultureInfo.InvariantCulture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cam.MoveRight(10);
            Invalidate();
            labelMx.Text = _cam.Location.X.ToString(CultureInfo.InvariantCulture);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _cam.MoveUp(10);
            Invalidate();
            labelMy.Text = _cam.Location.Y.ToString(CultureInfo.InvariantCulture);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _cam.MoveDown(10);
            Invalidate();
            labelMy.Text = _cam.Location.Y.ToString(CultureInfo.InvariantCulture);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _cam.MoveIn(10);
            Invalidate();
            labelMz.Text = _cam.Location.Z.ToString(CultureInfo.InvariantCulture);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _cam.MoveOut(10);
            Invalidate();
            labelMz.Text = _cam.Location.Z.ToString(CultureInfo.InvariantCulture);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _cameraY -= 1;
            labelMrY.Text = _cameraY.ToString(CultureInfo.InvariantCulture);
            _cam.TurnLeft(1);
            Invalidate();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            _cameraY += 1;
            labelMrY.Text = _cameraY.ToString(CultureInfo.InvariantCulture);
            _cam.TurnRight(1);
            Invalidate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _cameraX -= 1;
            labelMrX.Text = _cameraX.ToString(CultureInfo.InvariantCulture);
            _cam.TurnUp(1);
            Invalidate();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _cameraX+= 1;
            labelMrX.Text = _cameraX.ToString(CultureInfo.InvariantCulture);
            _cam.TurnDown(1);
            Invalidate();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            _cameraZ += 5;
            labelMrZ.Text = _cameraZ.ToString(CultureInfo.InvariantCulture);
            _cam.Roll(-5);
            Invalidate();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            _cameraZ -= 5;
            labelMrZ.Text = _cameraZ.ToString(CultureInfo.InvariantCulture);
            _cam.Roll(5);
            Invalidate();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            _cub = new Cuboid(150, 150, 150);
            _cam = new Camera();
            _cub.Center = new Point3D(400, 240, 0);
            _cam.Location = new Point3D(400, 240, -500);
            Invalidate();
            _i = 0;
            _bmp = new Bitmap[6];
            labelMx.Text = _cam.Location.X.ToString(CultureInfo.InvariantCulture);
            labelMy.Text = _cam.Location.Y.ToString(CultureInfo.InvariantCulture);
            labelMz.Text = _cam.Location.Z.ToString(CultureInfo.InvariantCulture);
            labelCx.Text = _cub.Center.X.ToString(CultureInfo.InvariantCulture);
            labelCy.Text = _cub.Center.Y.ToString(CultureInfo.InvariantCulture);
            labelCz.Text = _cub.Center.Z.ToString(CultureInfo.InvariantCulture);
            _cameraX = 0; _cameraY = 0; _cameraZ = 0;  _cubeX = 0; _cubeY = 0; _cubeZ = 0;
            labelCrX.Text = @"0";
            labelCrY.Text = @"0";
            labelCrZ.Text = @"0";
            labelMrX.Text = @"0";
            labelMrY.Text = @"0";
            labelMrZ.Text = @"0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (_i == 6) return;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                _bmp[_i] = new Bitmap(o.FileName);
                _i++;
            }
            _cub.FaceImageArray = _bmp;
            _cub.DrawingLine = false;
            _cub.DrawingImage = true;
            _cub.FillingFace = true;
            Invalidate();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            _cub.Center = new Point3D(_cub.Center.X - 5, _cub.Center.Y, _cub.Center.Z);
            labelCx.Text = _cub.Center.X.ToString(CultureInfo.InvariantCulture);
            Invalidate();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            _cub.Center = new Point3D(_cub.Center.X+ 5, _cub.Center.Y, _cub.Center.Z);
            labelCx.Text = _cub.Center.X.ToString(CultureInfo.InvariantCulture);
            Invalidate();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            _cub.Center = new Point3D(_cub.Center.X, _cub.Center.Y-5, _cub.Center.Z);
            labelCy.Text = _cub.Center.Y.ToString(CultureInfo.InvariantCulture);
            Invalidate();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            _cub.Center = new Point3D(_cub.Center.X, _cub.Center.Y + 5, _cub.Center.Z);
            labelCy.Text = _cub.Center.Y.ToString(CultureInfo.InvariantCulture);
            Invalidate();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            _cub.Center = new Point3D(_cub.Center.X, _cub.Center.Y , _cub.Center.Z+5);
            labelCz.Text = _cub.Center.Z.ToString(CultureInfo.InvariantCulture);
            Invalidate();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _cub.Center = new Point3D(_cub.Center.X, _cub.Center.Y, _cub.Center.Z - 5);
            labelCz.Text = _cub.Center.Z.ToString(CultureInfo.InvariantCulture);
            Invalidate();
        }
        #endregion
    }
}
