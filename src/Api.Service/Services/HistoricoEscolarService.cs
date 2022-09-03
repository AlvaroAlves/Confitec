using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.HistoricosEscolares;

namespace Api.Service.Services
{
    public class HistoricoEscolarService : IHistoricoEscolarService
    {
        IRepository<HistoricoEscolarEntity> _repository;
        public HistoricoEscolarService(IRepository<HistoricoEscolarEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<HistoricoEscolarEntity> Get(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<HistoricoEscolarEntity>> GetAll()
        {
            return await _repository.GetAsync();
        }

        public async Task<HistoricoEscolarEntity> Post(HistoricoEscolarEntity historicoEscolar)
        {
            return await _repository.CreateAsync(historicoEscolar);
        }

        public async Task<HistoricoEscolarEntity> Put(HistoricoEscolarEntity historicoEscolar)
        {
            return await _repository.UpdateAsync(historicoEscolar);
        }
    }
}