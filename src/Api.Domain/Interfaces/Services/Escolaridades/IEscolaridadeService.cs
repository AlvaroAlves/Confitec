using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Escolaridades;

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