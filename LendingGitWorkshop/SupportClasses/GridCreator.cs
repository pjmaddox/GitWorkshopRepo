using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportClasses
{
    public class GridCreator : IGridCreator
    {
        public Grid CreateRandomGrid(int min = 0, int max = 15, int id = 0)
        {
            var rand = new Random();
            var numVertices = rand.Next(min, max);

            var verts = new List<Vertex>();

            for (int i = 0; i < numVertices; ++i)
            {
                verts.Add(new Vertex(i, rand.Next(-50, 50), rand.Next(-50, 50)));
            }

            return new Grid(verts, id);
        }

        public IEnumerable<Grid> CreateRandomNumberOfRandomGrids(int maxNumberGrids = 1, int minNumberGrids = 1, int minSize = 0, int maxSize = 15)
        {
            var rand = new Random();
            var numberOfGridsToCreate = rand.Next(minNumberGrids, maxNumberGrids);
            var resultGrids = new List<Grid>();

            for(int i = 0; i < numberOfGridsToCreate; ++i)
            {
                resultGrids.Add(CreateRandomGrid(1,15,i));
            }

            return resultGrids;
        }
    }
}
