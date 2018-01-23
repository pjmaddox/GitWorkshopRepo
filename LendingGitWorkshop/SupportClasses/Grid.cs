using System.Collections.Generic;

namespace SupportClasses
{
    public class Grid
    {
        private List<Vertex> MyVertices { get; set; }

        public Grid(List<Vertex> vertices)
        {
            MyVertices = vertices;
        }

        public string GetVerticesAsString(string delimeter)
        {
            //List vertices as a string, delimeted by the passed in character/string
            
            //TODO: Create solution here!
        }

        public Vertex GetClosestVertexTo(float x, float y)
        {
            //Returns a reference to the vertex which argument is closest to
            //Rounding is up to the developer
            //First/Last is up to the developer
            //Return value for empty grid is up to the developer

            //TODO: Create solution here!
        }
    }
}