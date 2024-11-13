namespace dofus_unity_rendering_back.Models.Metadata.Spell
{
    [Serializable]
    public class SpellVariants
    {
        public int id;

        public int breedId;

        public List<uint> spellIds;

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
