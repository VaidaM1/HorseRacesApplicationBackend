using HorseRaseApplicationBackend.Entities;
using HorseRaseApplicationBackend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorseRaseApplicationBackend.Services
{
    public class BetterService
    {
        private readonly BetterRepository _betterRepository;

        public BetterService(BetterRepository betterRepository)
        {
            _betterRepository = betterRepository;
        }

        public async Task<List<Better>> GetAllAsync()
        {
            return await _betterRepository.GetAllAsync();
        }

        public async Task<Better> GetByIdAsync(int id)
        {
            var better = await _betterRepository.GetById(id);
            if (better == null)
            {
                throw new ArgumentException("Betters not found");
            }
            return better;
        }

        public async Task<List<Better>> GetByHorseIdAsync(int horseId)
        {
            return await _betterRepository.GetByHorseIdAsync(horseId);
        }

        public async Task<int> CreateAsync(Better better)
        {
            return await _betterRepository.CreateAsync(better);
        }

        public async Task UpdateAsync(Better better)
        {
            await _betterRepository.UpdateAsync(better);
        }

        public async Task DeleteAsync(int id)
        {
            var better = await GetByIdAsync(id);
            await _betterRepository.DeleteAsync(better);
        }
    }
}
