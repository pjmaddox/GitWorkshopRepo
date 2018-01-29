using System.Collections.Generic;

namespace SupportClasses
{
    public interface IGridCreator
    {
        Grid CreateRandomGrid(int min = 0, int max = 15, int id = 0);

        IEnumerable<Grid> CreateRandomNumberOfRandomGrids(int maxNumberGrids = 1, int minNumberGrids = 1, int minSize = 0, int maxSize = 15);
    }
}