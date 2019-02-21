using System;

namespace CircuitCalculator.Calculus
{
    /// <summary>
    /// For differentiation and double differentiation of function f at x=a in the domain of f.
    /// </summary>
    /// <param name="f">The function f(x).</param>
    /// <param name="a">For x=a.</param>
    public delegate double Differentiation(Function f, double a);

    /// <summary>
    /// Class containing integral and differential operators to perform numeric analysis (mapping and problem spaces) on electromagnetic phenomena.
    /// </summary>
    public partial class LambdaCalculus
    {
        // Differentiation methods - extend to include more 2 and 3 point recipes with foward & backward interpolations & variable step.

        public static Differentiation D2PointCenter()
        {
            const double h = 0.000001; // h could vary in an adaptive algorithm

            Differentiation differentiation = (f, x) =>
                (f(x + h) - f(x - h)) / (2 * h);

            return differentiation;
        }
        /// <summary>
        /// Method of finite central difference for the boundary value of the numerical solution.
        /// </summary>
        /// <returns></returns>
        public static Differentiation D5PointCenter()
        {
            const double h = 0.0005;

            Differentiation differentiation = (f, x) =>
            (-f(x + 2 * h) + 8 * f(x + h) - 8 * f(x - h) + f(x - 2 * h)) / (12 * h);

            return differentiation;
        }
        /// <summary>
        /// Method of finite forward difference for the boundary value of the numerical solution.
        /// </summary>
        /// <returns></returns>
        public static Differentiation D5PointForward()
        {
            const double h = 0.0005;

            Differentiation differentiation = (f, x) =>
            (-3 * f(x + 4 * h) + 16 * f(x + 3 * h) - 36 * f(x + 2 * h) + 48 * f(x + h) - 25 * f(x)) / (12 * h);

            return differentiation;
        }
        /// <summary>
        /// Point-center double differentiation method.
        /// </summary>
        public static Differentiation DdPointCenter()
        {
            const double h = 0.002;

            Differentiation ddifferentiation = (f, x) =>
            (-f(x + 2 * h) + 16 * f(x + h) - 30 * f(x) + 16 * f(x - h) - f(x - 2 * h)) / (12 * h * h);
            return ddifferentiation;
        }
        /// <summary>
        /// A fourth order Runge-Kutta method for y'=f(t,y), first order ode in the interval (a,b) with a given initial condition at x=a and fixed step h.
        /// </summary>
        /// <param name="f">The function.</param>
        /// <param name="a">The beginning of the interval.</param>
        /// <param name="b">The end of the interval.</param>
        /// <param name="value">The initial condition, where x=a.</param>
        /// <param name="step">The fixed step, or h.</param>
        public double RungeKutta(Functionxy f, double a, double b, double value, double step)
        {
            var t = a;
            var w = value;
            for (var i = 0; i < (b - a) / step; i++)
            {
                var k1 = step * f(t, w);
                var k2 = step * f(t + step / 2, w + k1 / 2);
                var k3 = step * f(t + step / 2, w + k2 / 2);
                var k4 = step * f(t + step, w + k3);
                w = w + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t = a + i * step;
                //Console.WriteLine("{0} {1} ", t, w);
            }
            return w;
        }

        // Partial differentiation methods.

        /// <summary>
        /// Partial differentiation of x.
        /// </summary>
        /// <param name="fxy">The function f(x,y).</param>
        /// <param name="a">The parameter a.</param>
        /// <param name="b">The parameter b.</param>
        public static double PartialDifferentiationx(Functionxy fxy, double a, double b)
        {
            Differentiation diff = D2PointCenter(); // Could be a parameter.
            return diff((double x) => fxy(x, b), a);
        }
        /// <summary>
        /// Partial differentiation of y.
        /// </summary>
        /// <param name="fxy">The function f(x,y).</param>
        /// <param name="a">The parameter a.</param>
        /// <param name="b">The parameter b.</param>
        public static double PartialDifferentiationy(Functionxy fxy, double a, double b)
        {
            Differentiation diff = D2PointCenter(); // Could be a parameter.
            return diff((double y) => fxy(a, y), b);
        }
        /// <summary>
        /// Partial differentiation of z.
        /// </summary>
        /// <param name="fxy">The function f(x,y).</param>
        /// <param name="a">The parameter a.</param>
        /// <param name="b">The parameter b.</param>
        public static double PartialDifferentiationz(Functionxy fxy, double a, double b)
        {
            Differentiation diff = D2PointCenter(); // Could be a parameter.
            return diff((double z) => fxy(a, z), b);
        }
        /// <summary>
        /// Length of curve f(x) from x=a to x=b.
        /// </summary>
        /// <param name="f">The function f(x).</param>
        /// <param name="a">The starting point a.</param>
        /// <param name="b">The ending point b.</param>
        /// <param name="intMethod">The integration method.</param>
        /// <param name="n">The n.</param>
        /// <param name="diffMethod">The differation method.</param>
        public static double CurveLength(Function f, double a, double b, Integral intMethod, int n, Differentiation diffMethod)
        {
            return intMethod((double x) => Math.Sqrt(1 + Math.Pow(diffMethod(f, x), 2)), a, b, n);
        }
        /// <summary>
        /// Casts an arc (curvature) of a function over a length.
        /// </summary>
        /// <param name="f">The function.</param>
        /// <param name="a">The arc length.</param>
        public static double Curvature(Function f, double a)
        {
            Differentiation ddiff = DdPointCenter(); // could be parameters
            Differentiation diff = D5PointCenter();
            return ddiff(f, a) / Math.Pow(1 + Math.Pow(diff(f, a), 2), 1.5);
        }

    }
}
