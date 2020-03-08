using Autofac;
using DemoLibrary;
using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	public static class ContainerConfig
	{
		public static IContainer Configure()
		{
			var builder = new ContainerBuilder();

			//builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
			builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();
			builder.RegisterType<Logger>().As<ILogger>();
			builder.RegisterType<DataAccess>().As<IDataAccess>();

			return builder.Build();
		}
	}
}
