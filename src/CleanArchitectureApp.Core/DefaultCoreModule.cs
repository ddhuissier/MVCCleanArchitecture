using Autofac;
using CleanArchitectureApp.Core.Interfaces;
using CleanArchitectureApp.Core.Services;

namespace CleanArchitectureApp.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
