using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterGrade
    {
        public MonsterBonusCharacteristics bonusCharacteristics;

        public int grade { get; set; }

        [ForeignKey("Monsters")]
        public ushort monsterId { get; set; }

        public ushort level { get; set; }

        public int lifePoints { get; set; }

        public short actionPoints { get; set; }

        public short movementPoints { get; set; }

        public int vitality { get; set; }

        public short paDodge { get; set; }

        public short pmDodge { get; set; }

        public ushort wisdom { get; set; }

        public short earthResistance { get; set; }

        public short airResistance { get; set; }

        public short fireResistance { get; set; }

        public short waterResistance { get; set; }

        public short neutralResistance { get; set; }

        public int gradeXp { get; set; }

        public byte damageReflect { get; set; }

        public byte hiddenLevel { get; set; }

        public ushort strength { get; set; }

        public ushort intelligence { get; set; }

        public ushort chance { get; set; }

        public ushort agility { get; set; }

        public int startingSpellId { get; set; }

        public sbyte bonusRange { get; set; }

        public override string ToString()
        {
            return null;
        }

        public MonsterGrade()
        {
        }
    }
}
