using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingGitWorkshop
{
    class Program
    {
        //This happens before Main is called!
        private static IContainer Container { get; } = DependencyConfig.RegisterDependencies();

        static void Main(string[] args)
        {
            //Establish the scope for the dependency tree
            using(var scope = Container.BeginLifetimeScope())
            {
                //Will into existence the magnificent dependency tree exist
                var application = scope.Resolve<IApplication>();

                //Actually run the program
                application.Run();
            }
        }
    }
}
