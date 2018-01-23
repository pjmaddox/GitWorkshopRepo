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
            //TODO: make a number of grids using the injected grid creator

            //TODO: have user enter a vertex

            //TODO: for each grid, output the vertex closest to the user input in the grid

            //TODO: wait for user input before closing
        }
    }
}
