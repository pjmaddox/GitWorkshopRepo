using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SupportClasses;

namespace LendingGitWorkshop
{
    public static class DependencyConfig
    {
        public static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //Template for registering components with AutoFac
            //builder.RegisterType<TheClassName>().As<TheClassInterface>();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<GridCreator>().As<IGridCreator>();

            //You can put more here if you make more!

            return builder.Build();
        }
    }
}
