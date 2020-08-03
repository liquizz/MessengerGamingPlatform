using Autofac;
using Database.Helpers.Sql;
using Database.ReadServices.MedievalBattle;
using Microsoft.Extensions.Configuration;
using Database.ReadServices.Sessions;
using Database.ReadServices.Sessions.Interfaces;
using Database.ReadServices.Users;
using Database.ReadServices.Users.Interfaces;
using Database.WriteServices.MedievalBattle.Interfaces;
using Database.WriteServices.MedievalBattle;
using Database.WriteServices.Sessions;
using Database.WriteServices.Sessions.Interfaces;
using Database.WriteServices.Users;
using Database.WriteServices.Users.Interfaces;

namespace Api.Config
{
    public class MGPAutofacConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new ConnectionStringHelper(c.Resolve<IConfiguration>()))
                .As<IConnectionStringHelper>()
                .InstancePerLifetimeScope();

            builder.Register(c => new SessionQueries(c.Resolve<IConnectionStringHelper>()))
                .As<ISessionQueries>()
                .InstancePerLifetimeScope();

            builder.Register(c => new SessionReadService(c.Resolve<ISessionQueries>())) 
                .As<ISessionReadService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new UserQueries(c.Resolve<IConnectionStringHelper>()))
                .As<IUserQueries>()
                .InstancePerLifetimeScope();

            builder.Register(c => new UserReadService(c.Resolve<IUserQueries>()))
                .As<IUserReadService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new AreaQueries(c.Resolve<IConnectionStringHelper>()))
                .As<IAreaQueries>()
                .InstancePerLifetimeScope();

            builder.Register(c => new AreaReadService(c.Resolve<IAreaQueries>()))
                .As<IAreaReadService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new AreaWriteService(c.Resolve<IAreaQueries>()))
                .As<IAreaWriteService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new SessionWriteService())
                .As<ISessionWriteService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new UsersWriteService())
                .As<IUsersWriteService>()
                .InstancePerLifetimeScope();
        }

        public static ContainerBuilder ContainerBuilderConfig(ContainerBuilder builder)
        {
            builder.RegisterType<ConnectionStringHelper>();
            builder.RegisterType<SessionQueries>();
            builder.RegisterType<SessionReadService>();
            builder.RegisterType<UserQueries>();
            builder.RegisterType<UserReadService>();
            builder.RegisterType<AreaQueries>();
            builder.RegisterType<AreaReadService>();
            builder.RegisterType<AreaWriteService>();
            builder.RegisterType<SessionWriteService>();
            builder.RegisterType<UsersWriteService>();

            return builder;
        }
    }
}