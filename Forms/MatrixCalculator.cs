using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data;
using MatrixLibrary;

namespace CircuitCalculator
{
    public partial class MatrixCalculator : Form
    {
        private Form owner;
        private static bool instance = false;

        // define a matrix A with dimensions (4x4)
        Matrix A = new Matrix(4, 4);

        // define a matrix B with dimensions (4x4)
        Matrix B = new Matrix(4, 4);

        // define a vector V1
        Matrix V1 = new Matrix(4, 1);

        // define a vector V2
        Matrix V2 = new Matrix(4, 1);

        public MatrixCalculator(Form mOwner)
        {
            InitializeComponent();
            owner = mOwner;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            instance = true;
            //sessionValue.Text = (string)AppDomain.CurrentDomain.GetData("SessionID");
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 400;
            toolTip.ReshowDelay = 250;
            toolTip.ShowAlways = true;
            

        }
        /// <summary>
        /// Checks the instance of the form.
        /// </summary>
        public static bool Instance { get { return instance; } set { instance = value; } }
        /// <summary>
        /// Items to create when the form is called.
        /// </summary>
        private void MatrixCalculator_Load(object sender, EventArgs e)
        {
            //Assign some values to matrix A and B notice the use of indexers
			A[0, 0] = 1 ;  A[0, 1] = 2 ;  A[0, 2] = 3 ; A[0, 3] = 4;
			A[1, 0] = 5 ;  A[1, 1] = 6 ;  A[1, 2] = 7 ; A[1, 3] = 8;
			A[2, 0] = 9 ;  A[2, 1] = 10;  A[2, 2] = 1 ; A[2, 3] = 12;
			A[3, 0] = 13 ; A[3, 1] = -14; A[3, 2] = 15 ; A[3, 3] = 16;

            Random rnd = new Random();
            for (int i = 0; i < B.NoRows; i++)
                for (int j = 0; j < B.NoCols; j++)
                    B[i, j] = 2 * rnd.NextDouble();

			//Assign some values to vectors V1 and V2
            V1[0, 0] = 1; V1[1, 0] = 2; V1[2, 0] = 3; //V1[3, 0] = 4;
            V2[0, 0] = 4; V2[1, 0] = 5; V2[2, 0] = 6; //V2[3, 0] = 7;

			//Print Matrices And Vectors
			txtDisplay.Text = "Matix A = " + "\n";
			txtDisplay.Text += Matrix.PrintMat(A) + "\n\n";

			txtDisplay.Text += "Matix B = " + "\n";
			txtDisplay.Text += Matrix.PrintMat(B)+ "\n\n";

			txtDisplay.Text += "Vector V1 = " + "\n";
			txtDisplay.Text += Matrix.PrintMat(V1) + "\n\n";

			txtDisplay.Text += "Vector V2 = " + "\n";
			txtDisplay.Text += Matrix.PrintMat(V2)+ "\n";
        }

        /// <summary>
        /// Handles the Click event of the CalButton control.
        /// </summary>
        private void calculateButton_Click(object sender, System.EventArgs e)
		{
			//Assign a dynamic matrix C
			Matrix C;
		
			double Determinant;
			double Magnitude;

			//Addition Case
			if (Option1.Checked)
			{
				// C = Addition of A and B
				// notice the use of operator overloading
				C =  A+B; 
			
				// Or if you dont want to use operator overloading
				// C = Matrix.Add(A,B);

				txtSolution.Text = "Answer> A + B = \n\n";
				// Print C
				txtSolution.Text += Matrix.PrintMat(C);
			}
				//Subtraction Case
			else if (Option2.Checked)
			{
				// C = Subtraction of A from B
				// notice the use of operator overloading
				C = A-B;

				// Or if you dont want to use operator overloading
				// C = Matrix.Subtract(A,B);

				txtSolution.Text = "Answer> A - B = \n\n";
				//Print C
				txtSolution.Text +=  Matrix.PrintMat(C);
			}
				//Multiplication Case
			else if (Option3.Checked)
			{
				// C = Multiplication of A with B
				// notice the use of operator overloading
				C = A*B;

				// Or if you dont want to use operator overloading
				//C = Matrix.Multiply(A,B);

				txtSolution.Text = "Answer> A x B = \n\n";
				//Print C
				txtSolution.Text += Matrix.PrintMat(C);
			}
				//Determinant Case of Matrix A
			else if (Option4.Checked)
			{
				Determinant = Matrix.Det(A);

				txtSolution.Text = "Answer> Determinant of A = " + Determinant;
			}
				//Inverse Case of Matrix B
			else if (Option5.Checked)
			{            
				C = Matrix.Inverse(A);

				txtSolution.Text = "Answer> Inverse of A = \n\n";
				txtSolution.Text += Matrix.PrintMat(C);
			}
				//Transpose Case of Matrix B
			else if (Option6.Checked)
			{            
				C = Matrix.Transpose(B);

				txtSolution.Text = "Answer> Transpose of B = \n\n";
				txtSolution.Text += Matrix.PrintMat(C);
			}
				//Mutiply Vectors V1 and V2 Case
			else if (Option7.Checked)
			{
				C = Matrix.CrossProduct(V1, V2);

				//OR using operator overloading
				//C = V1*V2
				txtSolution.Text = "Answer> V1 x V2 = \n\n";
				txtSolution.Text += Matrix.PrintMat(C);
			}
				//Dot Vectors V1 and V2 Case
			else if (Option8.Checked)
			{
				double dotproduct = Matrix.DotProduct(V1, V2);

				txtSolution.Text = "Answer> V1 . V2 = " + dotproduct.ToString();
			}

				//Magnitude of Vector V1 Case
			else if (Option9.Checked)
			{
				Magnitude = Matrix.VectorMagnitude(V1);

				txtSolution.Text = "Answer> |V1| =" + Magnitude;
			}
				//Scalar Multiply 5*A Case
			else if (Option10.Checked)
			{
				// Notice the use of operator overloading
				C = 5*A;

				// Or if you dont want to use operator overloading
				// C = Matrix.ScalarMultiply(5,A);

				txtSolution.Text = "Answer> 5A = \n\n";
				//Print C
				txtSolution.Text += Matrix.PrintMat(C);
			}
				//Scalar Divide V2/3 Case
			else if (Option11.Checked)
			{
				// Notice the use of operator overloading
				C = V2/3;
			
				// Or if you dont want to use operator overloading
				// C = Matrix.ScalarDivide(3,V2);

				txtSolution.Text = "Answer> V2 / 3 = \n\n" ;
				txtSolution.Text += Matrix.PrintMat(C);
			}

			else if (Option12.Checked)
			{
				// Case Axinv(A)
				C =  A * Matrix.Inverse(A);
				//or 
				//C = Matrix.Multiply(A, Matrix.Inverse(A));

				Console.Write(A.ToString());
				Console.Write(C.ToString());

				// Equality test
                if (C==new Matrix(Matrix.Identity(4))) MessageBox.Show("A x Inverse(A) = Identity(4), left side and right side equal!!");

				txtSolution.Text = "Answer> A x Inverse(A) = \n\n";
				txtSolution.Text += Matrix.PrintMat(C);
			}
			else if (Option13.Checked)
			{
				//Case AxTranspose(B)+inv(A)
				C = A * Matrix.Transpose(B)+Matrix.Inverse(A);

				// OR if not using operator overloading
				//C = Matrix.Add(Matrix.Multiply(A, Matrix.Transpose(B)), Matrix.Inverse(A));
				txtSolution.Text = "Answer> A x Transpose(B)+Inverse(A) = \n\n";
				txtSolution.Text += Matrix.PrintMat(C);
			}
			else if (Option14.Checked)
			{
				//Case AxPinv(A)xA

				C = A * Matrix.PINV(A)*A;

				// OR if not using operator overloading
				//C = Matrix.Multiply(A,Matrix.Multiply(Matrix.PINV(A),A));

				txtSolution.Text = "Answer> A x Pinv(A) x A = \n\n";
				txtSolution.Text += Matrix.PrintMat(C);
			}
		}
        /// <summary>
        /// Closes the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e)
        {
            instance = false;
            Close();
        }
        /// <summary>
        /// Opens the help file.
        /// </summary>
        private void helpButton_Click(object sender, EventArgs e)
        {
            string helpFileName = System.IO.Path.Combine(Application.StartupPath, "MatrixLibrary.chm");

            if (System.IO.File.Exists(helpFileName))
                System.Diagnostics.Process.Start(helpFileName); 

        }
    }
}