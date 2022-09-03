using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.HistoricosEscolares
{
    public interface IHistoricoEscolarService
    {
        Task<HistoricoEscolarEntity> Get (int id);
        Task<IEnumerable<HistoricoEscolarEntity>> GetAll();
        Task<HistoricoEscolarEntity> Post(HistoricoEscolarEntity historicoEscolar);
        Task<HistoricoEscolarEntity> Put(HistoricoEscolarEntity historicoEscolar);
        Task<bool> Delete(int id);
    }
}