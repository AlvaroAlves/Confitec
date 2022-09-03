using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuarios;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Usuarios;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<UsuarioEntity> _repository;
        private readonly IMapper _mapper;
        public UsuarioService(IRepository<UsuarioEntity> repository, IMapper mapper) 
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
            var listEntities = await _repository.GetAsync(); 
            return _mapper.Map<UsuarioDto>(listEntities);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            var listEntities = await _repository.GetAsync(); 
            return _mapper.Map<IEnumerable<UsuarioDto>>(listEntities);
        }

        public async Task<UsuarioCreateUpdateResultDto> Post(UsuarioDto usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.CreateAsync(entity); 
            return _mapper.Map<UsuarioCreateUpdateResultDto>(result);
        }

        public async Task<UsuarioCreateUpdateResultDto> Put(UsuarioDto usuario)
        {
            var model = _mapper.Map<UsuarioModel>(usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.UpdateAsync(entity); 
            return _mapper.Map<UsuarioCreateUpdateResultDto>(result);
        }
    }
}