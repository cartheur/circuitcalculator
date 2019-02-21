using System;

namespace CircuitCalculator
{
    /// <summary>
    /// Fourth order Runge-Kutta method for y'=f(t,y); 
    /// solve first order ode in the interval (a,b) with a given initial condition at x=a and fixed step h.
    /// </summary>
    public class Runge_Kutta
    {
        // Declare a delegate that takes a double and returns a double.
        public delegate double Function(double t, double y);

        public static void runge(double a, double b, double value, double step, Function f)
        {
            double t, w, k1, k2, k3, k4;
            t = a;
            w = value;
            for (int i = 0; i < (b - a) / step; i++)
            {
                k1 = step * f(t, w);
                k2 = step * f(t + step / 2, w + k1 / 2);
                k3 = step * f(t + step / 2, w + k2 / 2);
                k4 = step * f(t + step, w + k3);
                w = w + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t = a + i * step;
                Console.WriteLine("{0} {1} ", t, w);
                //return t;
            }
        }
    }
}
