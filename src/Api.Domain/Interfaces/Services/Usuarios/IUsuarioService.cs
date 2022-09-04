using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuarios;

namespace Api.Domain.Interfaces.Services.Usuarios
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Get (int id);
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioCreateUpdateResultDto> Post(UsuarioCreateDto usuario);
        Task<UsuarioCreateUpdateResultDto> Put(UsuarioUpdateDto usuario);
        Task<bool> Delete(int id);
    }
}