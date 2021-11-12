using HorseRaseApplicationBackend.Data;
using HorseRaseApplicationBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Repositories
{
    public class HorseRepository
    {
        private readonly DataContext _dataContext;

        public HorseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Horse>> GetAllAsync()
        {
            return await _dataContext.Horses.ToListAsync();
        }

        public async Task<Horse> GetById(int id)
        {
            return await _dataContext.Horses.FirstOrDefaultAsync(c => c.Id == id);

        }

        public async Task<int> CreateAsync(Horse horse)
        {
            _dataContext.Add(horse);
            await _dataContext.SaveChangesAsync();
            return horse.Id;
        }

        public async Task UpdateAsync(Horse horse)
        {
            _dataContext.Update(horse);
            await _dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Horse horse)
        {
            _dataContext.Remove(horse);
            await _dataContext.SaveChangesAsync();
        }
    }
}
