using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportClasses
{
    public class GridCreator : IGridCreator
    {
        public Grid CreateRandomGrid()
        {
            /*You can create your own solution for this here, 
                or you can wait and you will be provided with one!*/
            //TODO: Solution Here!
        }

        public IEnumerable<Grid> CreateRandomNumberOfRandomGrids(int minNumberGrids, int maxNumberGrids)
        {
            var thing = new Random();
            var numberOfGridsToCreate = thing.Next(minNumberGrids, maxNumberGrids);
            var resultGrids = new List<Grid>();

            for(int i = 0; i < numberOfGridsToCreate; ++i)
            {

            }
        }
    }
}
