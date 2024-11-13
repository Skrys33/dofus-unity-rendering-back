using dofus_unity_rendering_back.Models.Metadata.Effect;
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{
    [Serializable]
    [StructLayout(LayoutKind.Auto)]

    public struct PreviewSpellZoneDescr
    {

        public uint id;

        public SpellZoneDescr displayZoneDescr;

        public bool isPreviewZoneHidden;

        public string casterMask;

        public SpellZoneDescr activationZoneDescr;

        public string activationMask;

        public static PreviewSpellZoneDescr Parse(uint id, string rowDisplayZone, bool isPreviewZoneHidden, string casterMask, string rawActivationZone, string activationMask)
        {
            return default(PreviewSpellZoneDescr);
        }

        public static PreviewSpellZoneDescr GetDeepCopy(PreviewSpellZoneDescr previewSpellZoneDescr)
        {
            return default(PreviewSpellZoneDescr);
        }

        public EffectInstance GenerateActivationZoneEffectInstance(bool isCaster)
        {
            return null;
        }

        public EffectInstance GenerateDisplayZoneEffectInstance(bool isCaster)
        {
            return null;
        }
    }
}