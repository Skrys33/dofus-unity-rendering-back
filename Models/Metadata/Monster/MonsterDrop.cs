using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterDrop
    {
        public int dropId;

        public int monsterId;

        public int objectId;

        public float percentDropForGrade1;

        public float percentDropForGrade2;

        public float percentDropForGrade3;

        public float percentDropForGrade4;

        public float percentDropForGrade5;

        public int count;

        public string criteria;

        public bool hasCriteria;

        public bool hiddenIfInvalidCriteria;

        public List<MonsterDropCoefficient> specificDropCoefficient;

        [NonSerialized]
        private Monsters m_monster;

        public Monsters monster
        {
            get
            {
                return null;
            }
        }

        public MonsterDropCoefficient GetSpecificDropCoefficientByGrade(uint grade)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public MonsterDrop()
        {
        }
    }

}
