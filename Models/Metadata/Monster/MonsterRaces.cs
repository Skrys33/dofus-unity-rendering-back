using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{
    [Serializable]
    public class MonsterRaces : IAdminSelectionEntryType
    {
        public int id;

        public int superRaceId;

        public int nameId;

        public int aggressiveZoneSize;

        public int aggressiveLevelDiff;

        public string aggressiveImmunityCriterion;

        public int aggressiveAttackDelay;

        public List<uint> monsters;

        private string m_name;

        public string name
        {
            get
            {
                return null;
            }
        }
        public string adminSelectionTypeName
        {
            get
            {
                return null;
            }
        }

        public override string ToString()
        {
            return null;
        }

        public MonsterRaces()
        {
        }
    }

}
