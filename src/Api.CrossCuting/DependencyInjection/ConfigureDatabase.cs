using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.DependencyInjection
{
    public class ConfigureDatabase
    {
        public static void UseSqlServer(IServiceCollection serviceCollection){
            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer("Server=localhost;Database=estudantes;Trusted_Connection=True")
            );
        }
    }
}