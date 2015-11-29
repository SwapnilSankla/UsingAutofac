using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;

namespace UsingAutofac
{
    public class StartUp
    {
        private IContainer _container;

        public static void Main()
        {
            StartUp startup = new StartUp();
            startup._container = BuildContainer(startup).Build();
            startup.WriteDate();
            Console.ReadLine();
        }

        private static ContainerBuilder BuildContainer(StartUp startup)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayDateWriter>().AsSelf().As<IDateWriter>();
            return builder;
        }

        private void WriteDate()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
