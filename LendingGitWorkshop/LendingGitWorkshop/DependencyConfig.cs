using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace LendingGitWorkshop
{
    public static class DependencyConfig
    {
        public static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //Template for registering components with AutoFac
            //builder.RegisterType<PutAClassNameHere>().As<PutTheClass'sInterfaceHere>();

            builder.RegisterType<Application>().As<IApplication>();

            //You can put more 

            return builder.Build();
        }
    }
}
