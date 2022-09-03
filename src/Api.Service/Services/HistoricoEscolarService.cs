using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.HistoricosEscolares;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.HistoricosEscolares;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class HistoricoEscolarService : IHistoricoEscolarService
    {
        IRepository<HistoricoEscolarEntity> _repository;
        private readonly IMapper _mapper;
        public HistoricoEscolarService(IRepository<HistoricoEscolarEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<HistoricoEscolarDto> Get(int id)
        {
            var entity = await _repository.GetAsync(id); 
            return _mapper.Map<HistoricoEscolarDto>(entity);
        }

        public async Task<IEnumerable<HistoricoEscolarDto>> GetAll()
        {
            var listEntity = await _repository.GetAsync();
            return _mapper.Map<IEnumerable<HistoricoEscolarDto>>(listEntity);
        }

        public async Task<HistoricoEscolarCreateUpdateResultDto> Post(HistoricoEscolarCreateDto historicoEscolar)
        {
            var model = _mapper.Map<HistoricoEscolarModel>(historicoEscolar);
            var entity = _mapper.Map<HistoricoEscolarEntity>(model);
            var result = await _repository.CreateAsync(entity); 
            return _mapper.Map<HistoricoEscolarCreateUpdateResultDto>(result);
        }

        public async Task<HistoricoEscolarCreateUpdateResultDto> Put(HistoricoEscolarUpdateDto historicoEscolar)
        {
            var model = _mapper.Map<HistoricoEscolarModel>(historicoEscolar);
            var entity = _mapper.Map<HistoricoEscolarEntity>(model);
            var result = await _repository.UpdateAsync(entity); 
            return _mapper.Map<HistoricoEscolarCreateUpdateResultDto>(result);
        }
    }
}