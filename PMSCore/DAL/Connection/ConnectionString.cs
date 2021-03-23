using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DAL.Connection
{
    public static class ConnectionString
    {

        //var connectionString = ConnectionString.GetConnectionString();
        public static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), optional: false)
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.Development.json"), optional: false)
                .Build();
            return configuration.GetSection("AppSettings").GetSection("ConnectionString").Value;
        }
    }
}
