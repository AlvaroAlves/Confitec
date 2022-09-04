using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class UsuarioRepository : BaseRepository<UsuarioEntity>, IUsuarioRepository
    {
        private DbSet<UsuarioEntity> _dataset;
        public UsuarioRepository(MyContext context) : base(context)
        {
            _dataset = context.Set<UsuarioEntity>(); 
        }

        public async Task<UsuarioEntity> GetCompleteAsync(int id)
        {
            try
            {
                return await _dataset
                        .Include(h => h.HistoricoEscolar)
                        .Include(e => e.Escolaridade)
                        .SingleOrDefaultAsync(e => e.Id.Equals(id));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task<IEnumerable<UsuarioEntity>> GetCompleteAsync()
        {
            try
            {
                return await _dataset
                        .Include(h => h.HistoricoEscolar)
                        .Include(e => e.Escolaridade)
                        .ToListAsync();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}