using System.ComponentModel.DataAnnotations;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{
    [Serializable]
    public class SpellVariants
    {
        [Key]
        public int id { get; set; }

        public int breedId { get; set; }

        public List<uint> spellIds { get; set; }

        [NonSerialized]
        private List<Spells> m_spells;

        public override string ToString()
        {
            return null;
        }

        public List<Spells> GetSpells()
        {
            return null;
        }

        public static List<SpellVariants> GetSpellVariants()
        {
            return null;
        }

        public SpellVariants()
        {
        }
    }
}
