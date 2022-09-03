using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Escolaridades;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Escolaridades
{
    public interface IEscolaridadeService
    {
        Task<EscolaridadeDto> Get (int id);
        Task<IEnumerable<EscolaridadeDto>> GetAll();
        Task<EscolaridadeCreateUpdateResultDto> Post(EscolaridadeDto escolaridade);
        Task<EscolaridadeCreateUpdateResultDto> Put(EscolaridadeDto escolaridade);
        Task<bool> Delete(int id);
    }
}