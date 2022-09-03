using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Escolaridades;
using Api.Domain.Interfaces.Services.HistoricosEscolares;
using Api.Domain.Interfaces.Services.Usuarios;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCuting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection){
            serviceCollection.AddTransient<IUsuarioService, UsuarioService> ();
            serviceCollection.AddTransient<IEscolaridadeService, EscolaridadeService> ();
            serviceCollection.AddTransient<IHistoricoEscolarService, HistoricoEscolarService> (); 
        }
    }
}