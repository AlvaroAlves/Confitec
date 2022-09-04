using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Escolaridades;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services.Escolaridades;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class EscolaridadeService: IEscolaridadeService
    {
        private IRepository<EscolaridadeEntity> _repository;
        private readonly IMapper _mapper;
        public EscolaridadeService(IRepository<EscolaridadeEntity> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<EscolaridadeDto> Get(int id)
        {
            var entity = await _repository.GetAsync(id);
            return _mapper.Map<EscolaridadeDto>(entity);
        }

        public async Task<IEnumerable<EscolaridadeDto>> GetAll()
        {
            var listEntities = await _repository.GetAsync(); 
            return _mapper.Map<IEnumerable<EscolaridadeDto>>(listEntities);
        }

        public async Task<EscolaridadeCreateUpdateResultDto> Post(EscolaridadeCreateDto escolaridade)
        {
            var model = _mapper.Map<EscolaridadeModel>(escolaridade);
            var entity = _mapper.Map<EscolaridadeEntity>(model);
            var result = await _repository.CreateAsync(entity); 
            return _mapper.Map<EscolaridadeCreateUpdateResultDto>(result);
        }

        public async Task<EscolaridadeCreateUpdateResultDto> Put(EscolaridadeUpdateDto escolaridade)
        {
            var model = _mapper.Map<EscolaridadeModel>(escolaridade);
            var entity = _mapper.Map<EscolaridadeEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<EscolaridadeCreateUpdateResultDto>(result);
        }
    }
}