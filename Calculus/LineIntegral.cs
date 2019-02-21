using System;

namespace CircuitCalculator.Calculus
{
    public class LineIntegral
    {
        public enum CurveType { Ellipse, Circle, LineSegment };
        public enum CurveArea { Full, Half, Quarter };
        public enum IntegrationDirection { Clockwise, CounterClockwise };

        public LineIntegral(CurveType type, IntegrationDirection direction, CurveArea area, double r)
        {
            double x;
            double y;
            double t = 2 * Math.PI;
            if (type == CurveType.Circle && area == CurveArea.Full)
            {
                if (direction == IntegrationDirection.Clockwise)
                {
                    x = r * Math.Cos(t);
                    y = r * Math.Cos(t);
                }
            }
        }
    }
}
