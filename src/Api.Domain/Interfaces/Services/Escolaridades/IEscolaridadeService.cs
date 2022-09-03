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
        Task<EscolaridadeCreateUpdateResultDto> Post(EscolaridadeCreateDto escolaridade);
        Task<EscolaridadeCreateUpdateResultDto> Put(EscolaridadeUpdateDto escolaridade);
        Task<bool> Delete(int id);
    }
}