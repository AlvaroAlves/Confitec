using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = context.Set<T>();
        }
        public async Task<T> CreateAsync(T item)
        {
            try
            {
                item.CreateAt = DateTime.UtcNow;
                _dataset.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return item;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var res = await _dataset.SingleOrDefaultAsync(t => t.Id.Equals(id));
                if(res == null)
                    return false;
                _dataset.Remove(res);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public async Task<T> GetAsync(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(e => e.Id.Equals(id));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var res = await _dataset.SingleOrDefaultAsync(t => t.Id.Equals(item.Id));
                if(res == null)
                    return null;
                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = res.CreateAt;
                _context.Entry(res).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataset.AnyAsync(e => e.Id.Equals(id));
        }
    }
}