using SupportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingGitWorkshop
{
    public class Application : IApplication
    {
        private readonly IGridCreator _gridCreator;

        public Application(IGridCreator gridCreator)
        {
            _gridCreator = gridCreator;
        }

        public void Run()
        {
            //make a number of grids using the injected grid creator
            var grids = _gridCreator.CreateRandomNumberOfRandomGrids(15,1,1,20);

            //have user enter a vertex
            Console.WriteLine("Grids Created!");

            Console.WriteLine("Please enter the X-Value of a point in 2D space (default limit -50.0,50.0):");
            double xVal = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("Please enter the Y-Value of a point in 2D space (default limit -50,50):");
            double yVal = Convert.ToDouble(Console.ReadLine());

            //for each grid, output the vertex closest to the user input in the grid
            Grid resultGrid = null;
            Vertex resultVert = null;
            double currentMinDistance = double.MaxValue;
            foreach (Grid gx in grids)
            {
                var currentClosestVert = gx.GetClosestVertexTo(xVal, yVal);
                var currentDistance = currentClosestVert.DistanceFromLocation(xVal, yVal);

                if (currentDistance < currentMinDistance)
                {
                    currentMinDistance = currentDistance;
                    resultVert = currentClosestVert;
                    resultGrid = gx;
                }
            }

            //output the id of the grid that has the closest point to the user input
            Console.WriteLine(String.Format("Closest vertex to ({0},{1}) is Vertex-{2} from Grid-{5} located at ({3},{4}).",xVal,yVal,resultVert.Id,resultVert.XValue,resultVert.YValue,resultGrid.Id));

            Console.ReadLine();
        }
    }
}
