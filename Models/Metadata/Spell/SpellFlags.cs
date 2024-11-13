namespace dofus_unity_rendering_back.Models.Metadata.Spell
{
    [Flags]
    public enum SpellFlags
    {
        VerboseCast = 1,
        BypassSummoningLimit = 2,
        CanAlwaysTriggerSpells = 4,
        HideCastConditions = 8
    }
}