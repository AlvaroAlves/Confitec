using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Escolaridades
{
    public interface IEscolaridadeService
    {
        Task<EscolaridadeEntity> Get (int id);
        Task<IEnumerable<EscolaridadeEntity>> GetAll();
        Task<EscolaridadeEntity> Post(EscolaridadeEntity escolaridade);
        Task<EscolaridadeEntity> Put(EscolaridadeEntity escolaridade);
        Task<bool> Delete(int id);
    }
}