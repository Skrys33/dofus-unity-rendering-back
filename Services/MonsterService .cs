using dofus_unity_rendering_back.Models.Metadata.Monster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dofus_unity_rendering_back.Services
{
    public interface IMonsterService
    {
        Task<Monsters> GetMonsterByIdAsync(int monsterId);
    }

    public class MonsterService : IMonsterService
    {
        private readonly AppDbContext _context;

        public MonsterService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Monsters> GetMonsterByIdAsync(int monsterId)
        {
            return await _context.MonstersRecords.FirstOrDefaultAsync(m => m.id == monsterId);
        }
    }

}
