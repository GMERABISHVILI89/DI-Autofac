using Autofac;
using DemoLibrary;

namespace DI_AutofacTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope()) 
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
