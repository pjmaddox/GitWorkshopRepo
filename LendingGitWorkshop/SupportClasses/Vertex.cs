using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportClasses
{
    public class Vertex
    {
        public int Id { get; private set; }
        public double XValue { get; set; }
        public double YValue { get; set; }

        public Vertex(int id, double x, double y)
        {
            Id = id;
            XValue = x;
            YValue = y;
        }

        public double DistanceFromLocation(double xTarget, double yTarget)
        {
            //Get delta vector
            var xDelta = xTarget - XValue;
            var yDelta = yTarget - YValue;

            //Get magnitude of vector
            return Math.Sqrt(Math.Pow(xDelta, 2f) + Math.Pow(yDelta, 2f));
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", XValue, YValue);
        }
    }
}
