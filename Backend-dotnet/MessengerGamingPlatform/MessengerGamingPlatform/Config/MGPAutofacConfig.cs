using Autofac;
using MedievalBattle.Helpers.Sql;
using MedievalBattle.Queries;
using MedievalBattle.Queries.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Api.Config
{
    public class MGPAutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ConnectionStringHelper(c.Resolve<IConfiguration>()))
                .As<IConnectionStringHelper>()
                .InstancePerLifetimeScope();

            builder.Register(c => new AreaQueries(c.Resolve<IConnectionStringHelper>()))
                .As<IAreaQueries>()
                .InstancePerLifetimeScope();
        }

        public static ContainerBuilder ContainerBuilderConfig(ContainerBuilder builder)
        {
            return null;
        }
    }
}