using System.Collections.Generic;
using System.Linq;

namespace SupportClasses
{
    public class Grid
    {
        public int Id { get; private set; }

        private List<Vertex> MyVertices { get; set; }

        public Grid(List<Vertex> vertices, int id)
        {
            MyVertices = vertices;
            Id = id;
        }

        public string GetVerticesAsString(string delimeter = ", ")
        {
            //List vertices as a string, delimeted by the passed in character/string
            return string.Concat("Grid #", this.Id, ": ( ",  string.Join(delimeter, MyVertices.Select(x => x.ToString())), ")\n");
        }

        public Vertex GetClosestVertexTo(double xCoord, double yCoord)
        {
            //Returns a reference to the vertex which argument is closest to
            //Rounding is up to the developer
            //First/Last is up to the developer
            //Return value for empty grid is up to the developer

            Vertex result = null;
            double currentMinDistance = double.MaxValue;
            foreach(Vertex vx in MyVertices)
            {
                var distanceToCurrent = vx.DistanceFromLocation(xCoord, yCoord);
                if (result == null || distanceToCurrent < currentMinDistance)
                {
                    result = vx;
                    currentMinDistance = vx.DistanceFromLocation(xCoord, yCoord);
                }
            }

            return result;
        }
    }
}