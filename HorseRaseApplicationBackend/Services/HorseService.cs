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
            var newHose = new Horse()
            {
                Name = horse.Name,
                Runs = horse.Runs,
                Wins = horse.Wins,
                About = horse.About
            };

            return await _horseRepository.CreateAsync(newHose);
        }

        public async Task UpdateAsync(Horse horse)
        {
            var updatedHose = new Horse()
            {
                Id = horse.Id,
                Name = horse.Name,
                Runs = horse.Runs,
                Wins = horse.Wins,
                About = horse.About
            };

            await _horseRepository.UpdateAsync(updatedHose);
        }
        public async Task DeleteAsync(int id)
        {
            var horse = await GetByIdAsync(id);
            await _horseRepository.DeleteAsync(horse);
        }
    }
}
