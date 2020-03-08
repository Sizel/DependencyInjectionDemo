using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Utilities;
using Autofac;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = ContainerConfig.Configure();

            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                IBusinessLogic businessLogic = scope.Resolve<IBusinessLogic>();
                businessLogic.ProcessData();
            }

            Console.ReadLine();
        }
    }
}
