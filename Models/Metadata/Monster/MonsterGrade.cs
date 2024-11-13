using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterGrade
    {
        public MonsterBonusCharacteristics bonusCharacteristics;

        public int grade;

        public ushort monsterId;

        public ushort level;

        public int lifePoints;

        public short actionPoints;

        public short movementPoints;

        public int vitality;

        public short paDodge;

        public short pmDodge;

        public ushort wisdom;

        public short earthResistance;

        public short airResistance;

        public short fireResistance;

        public short waterResistance;

        public short neutralResistance;

        public int gradeXp;

        public byte damageReflect;

        public byte hiddenLevel;

        public ushort strength;

        public ushort intelligence;

        public ushort chance;

        public ushort agility;

        public int startingSpellId;

        public sbyte bonusRange;

        public override string ToString()
        {
            return null;
        }

        public MonsterGrade()
        {
        }
    }
}
