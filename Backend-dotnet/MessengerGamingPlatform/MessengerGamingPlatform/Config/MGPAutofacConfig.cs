using Autofac;
using MedievalBattle.Helpers.Sql;
using MedievalBattle.Queries;
using MedievalBattle.Queries.Interfaces;
using MedievalBattle.Services;
using MedievalBattle.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Api.Helpers.Sql;
using Api.Sessions;
using Api.Sessions.Interfaces;
using Api.Users;
using Api.Users.Interfaces;
using ConnectionStringHelper = Api.Helpers.Sql.ConnectionStringHelper;
using IConnectionStringHelper = Api.Helpers.Sql.IConnectionStringHelper;

namespace Api.Config
{
    public class MGPAutofacConfig : Module
    {
        // TODO: переписать стуктуру проекта (перенести Api.Sessions => Database)
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new Helpers.Sql.ConnectionStringHelper(c.Resolve<IConfiguration>())) 
                .As<Helpers.Sql.IConnectionStringHelper>()
                .InstancePerLifetimeScope();

            builder.Register(c => new SessionQueries(c.Resolve<Helpers.Sql.IConnectionStringHelper>())) 
                .As<ISessionQueries>()
                .InstancePerLifetimeScope();

            builder.Register(c => new SessionService(c.Resolve<ISessionQueries>())) 
                .As<ISessionService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new UserQueries(c.Resolve<Helpers.Sql.IConnectionStringHelper>()))
                .As<IUserQueries>()
                .InstancePerLifetimeScope();

            builder.Register(c => new UserService(c.Resolve<IUserQueries>()))
                .As<IUserService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new MedievalBattle.Helpers.Sql.ConnectionStringHelper(c.Resolve<IConfiguration>()))
                .As<MedievalBattle.Helpers.Sql.IConnectionStringHelper>()
                .InstancePerLifetimeScope();

            builder.Register(c => new AreaQueries(c.Resolve<MedievalBattle.Helpers.Sql.IConnectionStringHelper>()))
                .As<IAreaQueries>()
                .InstancePerLifetimeScope();

            builder.Register(c => new AreaService(c.Resolve<IAreaQueries>()))
                .As<IAreaService>()
                .InstancePerLifetimeScope();
        }

        public static ContainerBuilder ContainerBuilderConfig(ContainerBuilder builder)
        {
            builder.RegisterType<Api.Helpers.Sql.ConnectionStringHelper>();
            builder.RegisterType<SessionQueries>();
            builder.RegisterType<SessionService>();
            builder.RegisterType<UserQueries>();
            builder.RegisterType<UserService>();
            builder.RegisterType<MedievalBattle.Helpers.Sql.ConnectionStringHelper>();
            builder.RegisterType<AreaQueries>();
            builder.RegisterType<AreaService>();

            return builder;
        }
    }
}