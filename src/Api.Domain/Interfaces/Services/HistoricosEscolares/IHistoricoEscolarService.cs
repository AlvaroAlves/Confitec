using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.HistoricosEscolares;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.HistoricosEscolares
{
    public interface IHistoricoEscolarService
    {
        Task<HistoricoEscolarDto> Get (int id);
        Task<IEnumerable<HistoricoEscolarDto>> GetAll();
        Task<HistoricoEscolarCreateUpdateResultDto> Post(HistoricoEscolarDto historicoEscolar);
        Task<HistoricoEscolarCreateUpdateResultDto> Put(HistoricoEscolarDto historicoEscolar);
        Task<bool> Delete(int id);
    }
}