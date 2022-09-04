using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.Mappings
{
    public class ConfigureMappingProfiles
    {
        public static void Configure(IServiceCollection services){
            IMapper mapper = ConfigureProfiles().CreateMapper();
            services.AddSingleton(mapper);
        }

        private static MapperConfiguration ConfigureProfiles(){
            return new MapperConfiguration(cfg => {
                cfg.AddProfile(new UsuarioProfile());
                cfg.AddProfile(new EscolaridadeProfile());
                cfg.AddProfile(new HistoricoEscolarProfile());
            });
        }
    }
}