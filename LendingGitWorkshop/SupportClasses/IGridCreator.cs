using System.Collections.Generic;

namespace SupportClasses
{
    public interface IGridCreator
    {
        Grid CreateRandomGrid();

        IEnumerable<Grid> CreateRandomNumberOfRandomGrids(int minNumberGrids, int maxNumberGrids);
    }
}