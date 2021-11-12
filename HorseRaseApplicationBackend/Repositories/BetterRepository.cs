using HorseRaseApplicationBackend.Data;
using HorseRaseApplicationBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Repositories
{
    public class BetterRepository
    {
        private readonly DataContext _dataContext;

        public BetterRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Better>> GetAllAsync()
        {
            return await _dataContext.Betters.Include(h => h.Horse).ToListAsync();
        }

        public async Task<Better> GetById(int id)
        {
            return await _dataContext.Betters.FirstOrDefaultAsync(b => b.Id == id);

        }

        public async Task<List<Better>> GetByHorseIdAsync(int horseId)
        {
            return await _dataContext.Betters.Include(r => r.Horse).Where(p => p.HorseId == horseId).ToListAsync();
        }

        public async Task<int> CreateAsync(Better better)
        {
            _dataContext.Add(better);
            await _dataContext.SaveChangesAsync();
            return better.Id;
        }

        public async Task UpdateAsync(Better better)
        {
            _dataContext.Update(better);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Better better)
        {
            _dataContext.Remove(better);
            await _dataContext.SaveChangesAsync();
        }
    }
}
