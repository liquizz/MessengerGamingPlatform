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

            builder.Register(c => new AbstractAreaWriteService(c.Resolve<IAreaQueries>()))
                .As<IAbstractAreaWriteService>()
                .InstancePerLifetimeScope();

            builder.Register(c => new SessionRepository())
                .As<ISessionRepository>()
                .InstancePerLifetimeScope();

            builder.Register(c => new UsersRepository())
                .As<IUsersRepository>()
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
            builder.RegisterType<AbstractAreaWriteService>();
            builder.RegisterType<SessionRepository>();
            builder.RegisterType<UsersRepository>();

            return builder;
        }
    }
}