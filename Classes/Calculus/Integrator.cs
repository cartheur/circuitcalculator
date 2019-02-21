namespace CircuitCalculator.Classes.Calculus
{
    /// <summary>
    /// An integrator based on Simpson's rule.
    /// </summary>
    public class SimpsonIntegrator
    {
        /// <summary>
        /// A delegate taking a function.
        /// </summary>
        /// <param name="x">The function.</param>
        /// <returns></returns>
        public delegate double Function(double x);
        /// <summary>
        /// A definite integral on specified paramters.
        /// </summary>
        /// <param name="f">The function to be integrated.</param>
        /// <param name="a">The lower limit.</param>
        /// <param name="b">The upper limit.</param>
        /// <param name="stepNumber">The number of steps.</param>
        /// <returns></returns>
        public static double Integrate(Function f, double a, double b, int stepNumber)
        {
            double sum = 0;
            double stepSize = (b - a) / stepNumber;
            // The Simpson algorithm samples the integrand in several point which significantly improves precision.
            for (int i = 0; i < stepNumber; i = i + 2)
                // Divide the area under f(x) into step_number rectangles and sum their areas.
                sum = sum + (f(a + i * stepSize) + 4 * f(a + (i + 1) * stepSize) + f(a + (i + 2) * stepSize)) * stepSize / 3; 
            return sum;
        }
    }
    public class RungeKuttaIntegrator
    {
        public delegate double Function(double x);


    }
}
