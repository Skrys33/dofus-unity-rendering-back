using Microsoft.EntityFrameworkCore;

namespace dofus_unity_rendering_back.Services
{
    public interface ITranslationService
    {
        Task<string> GetTranslationAsync(int nameId, string languageCode);
    }

    public class TranslationService : ITranslationService
    {
        private readonly AppDbContext _context;

        public TranslationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> GetTranslationAsync(int nameId, string languageCode)
        {
            return await _context.TranslatedLabelRecords
                .Where(t => t.id == nameId && t.languageCode == languageCode)
                .Select(t => t.label)
                .FirstOrDefaultAsync();
        }
    }

}
