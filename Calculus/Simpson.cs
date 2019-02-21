using System;

namespace CircuitCalculator.Mathematics
{
    /// <summary>
    /// Calculate the integral of f(x) between x=a and x=b by spliting the interval in step_number steps.
    /// </summary>
    public class Integral
    {
        // Declare a delegate that takes and returns double.
        public delegate double Function(double x);

        public static double integral(Function f, double a, double b, int step_number)
        {
            double sum = 0;
            double step_size = (b - a) / step_number;
            // Simpson algorithm samples the integrand at several points which significantly improves precision.
            for (int i = 0; i < step_number; i = i + 2)
                // Divide the area under f(x) into step_number rectangles and sum their areas.
                sum = sum + (f(a + i * step_size) + 4 * f(a + (i + 1) * step_size) + f(a + (i + 2) * step_size)) * step_size / 3;
            return sum;
        }
    }
    /// <summary>
    /// The secant method.
    /// </summary>
    public class Secant
    {
        // Declare a delegate that takes double and returns double.
        public delegate double Function(double x);

        public static void secant(int step_number, double point1, double point2, Function f)
        {
            double p2, p1, p0, prec = .0001f; // Set the precision to .0001.
            int i;
            p0 = f(point1);
            p1 = f(point2);
            p2 = p1 - f(p1) * (p1 - p0) / (f(p1) - f(p0)); // Secant formula.

            // Iterate till precision goal is not met or the maximum number of steps is reached.
            for (i = 0; System.Math.Abs(p2) > prec && i < step_number; i++)
            {
                p0 = p1;
                p1 = p2;
                p2 = p1 - f(p1) * (p1 - p0) / (f(p1) - f(p0));
            }
            if (i < step_number)
                Console.WriteLine(p2); // The method converges.
            else
                Console.WriteLine("{0}.The method did not converge", p2);// The method does not converge.
        }
    }
}
