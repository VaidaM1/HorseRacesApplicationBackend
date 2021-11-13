using HorseRaseApplicationBackend.Entities;
using HorseRaseApplicationBackend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Services
{
    public class HorseService
    {
        private readonly HorseRepository _horseRepository;

        public HorseService(HorseRepository horseRepository)
        {
            _horseRepository = horseRepository;
        }

        public async Task<List<Horse>> GetAllAsync()
        {
            return await _horseRepository.GetAllAsync();
        }

        public async Task<Horse> GetByIdAsync(int id)
        {
            var horse = await _horseRepository.GetById(id);
            if (horse == null)
            {
                throw new ArgumentException("Horse was not found");
            }
            return horse;
        }

        public async Task<int> CreateAsync(Horse horse)
        {
            return await _horseRepository.CreateAsync(horse);
        }

        public async Task UpdateAsync(Horse horse)
        {
            await _horseRepository.UpdateAsync(horse);
        }
        public async Task DeleteAsync(int id)
        {
            var horse = await GetByIdAsync(id);
            await _horseRepository.DeleteAsync(horse);
        }
    }
}
