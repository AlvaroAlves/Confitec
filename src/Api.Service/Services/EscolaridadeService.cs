using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Escolaridades;

namespace Api.Service.Services
{
    public class EscolaridadeService: IEscolaridadeService
    {
        private IRepository<EscolaridadeEntity> _repository;
        public EscolaridadeService(IRepository<EscolaridadeEntity> repository) 
        {
            _repository = repository;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<EscolaridadeEntity> Get(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<EscolaridadeEntity>> GetAll()
        {
            return await _repository.GetAsync();
        }

        public async Task<EscolaridadeEntity> Post(EscolaridadeEntity escolaridade)
        {
            return await _repository.CreateAsync(escolaridade);
        }

        public async Task<EscolaridadeEntity> Put(EscolaridadeEntity escolaridade)
        {
            return await _repository.UpdateAsync(escolaridade);
        }
    }
}