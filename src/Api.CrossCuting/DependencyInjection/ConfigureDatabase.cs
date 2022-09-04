using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.DependencyInjection
{
    public class ConfigureDatabase
    {
        public static void UseSqlServer(IServiceCollection serviceCollection, IConfigurationRoot configuration){
            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("Default"))
            );
        }
    }
}