namespace dofus_unity_rendering_back.Models.Metadata.Monster
{
    public enum MonsterFlags : ushort
    {
        UseSummonSlot = 1,
        UseBombSlot = 2,
        IsBoss = 4,
        IsMiniBoss = 8,
        IsQuestMonster = 0x10,
        FastAnimsFun = 0x20,
        CanPlay = 0x40,
        CanTackle = 0x80,
        CanBePushed = 0x100,
        CanSwitchPos = 0x200,
        CanSwitchPosOnTarget = 0x400,
        CanBeCarried = 0x800,
        CanUsePortal = 0x1000,
        AllIdolsDisabled = 0x2000,
        UseRaceValues = 0x4000,
        SoulCaptureForbidden = 0x8000
    }

}