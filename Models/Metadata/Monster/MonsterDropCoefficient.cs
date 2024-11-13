using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterDropCoefficient
    {
        public int monsterId;

        public int monsterGrade;

        public float dropCoefficient;

        public string criteria;

        [NonSerialized]
        private Monsters m_monster;

        public Monsters monster
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

        public MonsterDropCoefficient()
        {
        }
    }
}