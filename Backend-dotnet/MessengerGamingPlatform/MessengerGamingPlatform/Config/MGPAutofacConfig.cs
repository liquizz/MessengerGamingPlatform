using Autofac;
using Component.Database.Helpers.Sql;
using Component.Database.ReadServices.MedievalBattle;
using Microsoft.Extensions.Configuration;
using Component.Database.ReadServices.Sessions;
using Component.Database.ReadServices.Sessions.Interfaces;
using Component.Database.ReadServices.Users;
using Component.Database.ReadServices.Users.Interfaces;
using Component.Database.WriteServices.MedievalBattle.Interfaces;
using Component.Database.WriteServices.MedievalBattle;
using Component.Database.WriteServices.Sessions;
using Component.Database.WriteServices.Sessions.Interfaces;
using Component.Database.WriteServices.Users;
using Component.Database.WriteServices.Users.Interfaces;

namespace Component.Web.Config
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
            builder.RegisterType<AreaWriteService>();
            builder.RegisterType<SessionWriteService>();
            builder.RegisterType<UsersWriteService>();

            return builder;
        }
    }
}