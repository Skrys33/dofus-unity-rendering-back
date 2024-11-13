namespace dofus_unity_rendering_back.Models.Metadata.Effect
{
    [Flags]
    public enum EffectInstanceFlags : byte
    {
        VisibleInTooltip = 1,
        VisibleInBuffUi = 2,
        VisibleInFightLog = 4,
        VisibleOnTerrain = 8,
        ForClientOnly = 0x10,
        Trigger = 0x20
    }
}