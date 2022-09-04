using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuarios;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services.Usuarios;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _repository;
        private readonly IMapper _mapper;
        public UsuarioService(IUsuarioRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UsuarioDto> Get(int id)
        {
            var listEntities = await _repository.GetCompleteAsync(id); 
            return _mapper.Map<UsuarioDto>(listEntities);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            var listEntities = await _repository.GetCompleteAsync(); 
            return _mapper.Map<IEnumerable<UsuarioDto>>(listEntities);
        }

        public async Task<UsuarioCreateUpdateResultDto> Post(UsuarioCreateDto usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.CreateAsync(entity); 
            return _mapper.Map<UsuarioCreateUpdateResultDto>(result);
        }

        public async Task<UsuarioCreateUpdateResultDto> Put(UsuarioUpdateDto usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.UpdateAsync(entity); 
            return _mapper.Map<UsuarioCreateUpdateResultDto>(result);
        }
    }
}