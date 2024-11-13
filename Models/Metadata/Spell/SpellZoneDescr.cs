using dofus_unity_rendering_back.Models.Metadata.Enums;
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Serializable]
    [StructLayout(LayoutKind.Auto)]
    [Token(Token = "0x2000064")]
    public struct SpellZoneDescr
    {
        public const byte DefaultParam1 = 1;

        public const byte DefaultParam2 = 0;

        public const sbyte DefaultDamageDecreaseStepPercent = 10;

        public const sbyte DefaultMaxDamageDecreaseApplyCount = 4;

        public List<int> cellIds;

        public SpellZoneShape shape;

        public byte param1;

        public byte param2;

        public sbyte damageDecreaseStepPercent;

        public sbyte maxDamageDecreaseApplyCount;

        public bool isStopAtTarget;

        public static SpellZoneDescr Parse(string rawSpellZone)
        {
            return default(SpellZoneDescr);
        }
        private static bool DoesShapeHaveMinSize(SpellZoneShape shape)
        {
            return default(bool);
        }
    }
}