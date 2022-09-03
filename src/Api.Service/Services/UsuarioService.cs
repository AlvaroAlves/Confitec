using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Usuarios;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<UsuarioEntity> _repository;
        public UsuarioService(IRepository<UsuarioEntity> repository) 
        {
            _repository = repository;
        }
        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UsuarioEntity> Get(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<IEnumerable<UsuarioEntity>> GetAll()
        {
            return await _repository.GetAsync();
        }

        public async Task<UsuarioEntity> Post(UsuarioEntity usuario)
        {
            return await _repository.CreateAsync(usuario);
        }

        public async Task<UsuarioEntity> Put(UsuarioEntity usuario)
        {
            return await _repository.UpdateAsync(usuario);
        }
    }
}