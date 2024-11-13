
namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Flags]
    public enum SpellLevelFlags : ushort
    {

        CastInLine = 1,

        CastInDiagonal = 2,

        CastTestLos = 4,

        NeedFreeCell = 8,

        NeedTakenCell = 0x10,

        NeedFreeTrapCell = 0x20,

        RangeCanBeBoosted = 0x40,

        HideEffects = 0x80,

        Hidden = 0x100,

        PlayAnimation = 0x200,

        NeedVisibleEntity = 0x400,

        NeedCellWithoutPortal = 0x800,

        PortalProjectionForbidden = 0x1000
    }
}