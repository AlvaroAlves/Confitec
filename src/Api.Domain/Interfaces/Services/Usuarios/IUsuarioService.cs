using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Usuarios
{
    public interface IUsuarioService
    {
        Task<UsuarioEntity> Get (int id);
        Task<IEnumerable<UsuarioEntity>> GetAll();
        Task<UsuarioEntity> Post(UsuarioEntity usuario);
        Task<UsuarioEntity> Put(UsuarioEntity usuario);
        Task<bool> Delete(int id);
    }
}