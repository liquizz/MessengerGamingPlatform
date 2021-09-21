﻿using Microsoft.Extensions.Configuration;

namespace Component.Database.Helpers.Sql
{
    public interface IConnectionStringHelper
    {
        public string ConnectionString { get; }
    }

    public class ConnectionStringHelper : IConnectionStringHelper
    {
        public string ConnectionString { get; set; }
        public ConnectionStringHelper(IConfiguration connectionString)
        {
            ConnectionString = connectionString["ConnectionStrings:server1"];
        }
    }
}