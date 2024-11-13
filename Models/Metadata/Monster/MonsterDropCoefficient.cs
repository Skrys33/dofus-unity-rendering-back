using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterDropCoefficient
    {
        [ForeignKey("Monsters")]
        public int monsterId { get; set; }

        [ForeignKey("MonsterGrade")]
        public int monsterGrade { get; set; }

        public float dropCoefficient{ get; set; }

        public string criteria{ get; set; }

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