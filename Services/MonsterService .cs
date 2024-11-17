using dofus_unity_rendering_back.Models.Metadata.Monster;
using dofus_unity_rendering_back.Models.Metadata.Spell;
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
        private readonly ITranslationService _translationService;

        public MonsterService(AppDbContext context)
        {
            _context = context;
            _translationService = new TranslationService(context);
        }

        public async Task<Monsters> GetMonsterByIdAsync(int monsterId)
        {
            var monster = await _context.MonstersRecords
                .Where(m => m.id == monsterId)
                .FirstOrDefaultAsync();

            if (monster == null)
            {
                return null;
            }

            monster.name = await _translationService.GetTranslationAsync(monster.nameId, "fr");

            monster.spellsData = await _context.SpellsRecords
                .Where(s => monster.spells.Contains(s.id))
                .ToListAsync();

            foreach (var spell in monster.spellsData)
            {
                spell.name = await _translationService.GetTranslationAsync(spell.nameId, "fr");
                spell.description = await _translationService.GetTranslationAsync(spell.descriptionId, "fr");

                spell.spellLevelsData = await _context.SpellLevelsRecords
                .Where(s => spell.spellLevels.Contains((uint)s.id))
                .ToListAsync();

                foreach(var level in spell.spellLevelsData)
                {
                    level.effects = await _context.EffectInstanceDiceRecords
                            .Where(s => level.spellId == s.spellId)
                            .ToListAsync();


                    level.criticalEffect = await _context.EffectInstanceDiceRecords
                            .Where(s => level.spellId == s.spellId)
                            .ToListAsync();
                }
            }

            monster.drops = await _context.MonsterDropRecords
                .Where(d => (ushort) d.monsterId == monster.id)
                .ToListAsync();

            monster.temporisDrops = await _context.MonsterDropRecords
                .Where(d => (ushort) d.monsterId == monster.id)
                .ToListAsync();

            monster.grades = await _context.MonsterGradeRecords
                .Where(d => (ushort)d.monsterId == monster.id)
                .ToListAsync();

            monster.animFunList = await _context.AnimFunMonsterRecords
                .Where(d => (ushort)d.Monstersid == monster.id)
                .ToListAsync();

            return monster;
        }

    }

}
