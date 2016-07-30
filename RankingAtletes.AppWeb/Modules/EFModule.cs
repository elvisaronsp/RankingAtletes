using Autofac;
using RankingAtletes.Model;

namespace RankingAtletes.AppWeb.Modules
{
    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(RankingAtletasContext))
                .As(typeof(IContext))
                .InstancePerLifetimeScope();
        }
    }
}