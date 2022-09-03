using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuarios;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Usuarios
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Get (int id);
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioCreateUpdateResultDto> Post(UsuarioDto usuario);
        Task<UsuarioCreateUpdateResultDto> Put(UsuarioDto usuario);
        Task<bool> Delete(int id);
    }
}