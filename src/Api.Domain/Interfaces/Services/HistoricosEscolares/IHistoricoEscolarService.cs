using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.HistoricosEscolares;

namespace Api.Domain.Interfaces.Services.HistoricosEscolares
{
    public interface IHistoricoEscolarService
    {
        Task<HistoricoEscolarDto> Get (int id);
        Task<IEnumerable<HistoricoEscolarDto>> GetAll();
        Task<HistoricoEscolarCreateUpdateResultDto> Post(HistoricoEscolarCreateDto historicoEscolar);
        Task<HistoricoEscolarCreateUpdateResultDto> Put(HistoricoEscolarUpdateDto historicoEscolar);
        Task<bool> Delete(int id);
    }
}