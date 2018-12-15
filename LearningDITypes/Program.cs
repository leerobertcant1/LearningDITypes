using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Autofac;
using LearningDITypes.Controllers;
using LearningDITypes.Services;
using LearningDITypes.Abstractions;
using Unity;
using Unity.Injection;

namespace LearningDITypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            var builder = new ContainerBuilder();
            builder.RegisterType<HomeController>()
                .OnActivating(e => e.Instance.Index(new DIMethodInjection()));

            var container = builder.Build();
            container.Resolve<HomeController>();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();


    }
}
