using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterDrop
    {

        [Key]
        public int dropId { get; set; }

        [ForeignKey("Monsters")]
        public int monsterId { get; set; }

        public int objectId{ get; set; }

        public float percentDropForGrade1{ get; set; }

        public float percentDropForGrade2{ get; set; }

        public float percentDropForGrade3{ get; set; }

        public float percentDropForGrade4{ get; set; }

        public float percentDropForGrade5{ get; set; }

        public int count{ get; set; }

        public string criteria{ get; set; }

        public bool hasCriteria{ get; set; }

        public bool hiddenIfInvalidCriteria{ get; set; }

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
