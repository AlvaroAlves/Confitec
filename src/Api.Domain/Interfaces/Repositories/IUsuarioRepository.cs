using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<UsuarioEntity>
    {
        Task<UsuarioEntity> GetCompleteAsync(int id);
        Task<IEnumerable<UsuarioEntity>> GetCompleteAsync();   
    }
}