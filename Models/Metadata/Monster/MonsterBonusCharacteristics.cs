using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class MonsterBonusCharacteristics
    {
        public int lifePoints;

        public ushort strength;

        public ushort wisdom;

        public ushort chance;

        public ushort agility;

        public ushort intelligence;

        public short earthResistance;

        public short fireResistance;

        public short waterResistance;

        public short airResistance;

        public short neutralResistance;

        public byte tackleEvade;

        public byte tackleBlock;

        public byte bonusEarthDamage;

        public byte bonusFireDamage;

        public byte bonusWaterDamage;

        public byte bonusAirDamage;

        public byte aPRemoval;

        public override string ToString()
        {
            return null;
        }

        public MonsterBonusCharacteristics()
        {
        }
    }

}
