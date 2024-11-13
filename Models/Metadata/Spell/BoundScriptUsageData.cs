namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Serializable]
    public class BoundScriptUsageData
    {
        public const int SerialSequenceGroup = 0;

        public int id;

        public int order;

        public int scriptId;

        public List<uint> spellLevels;

        public string criterion;

        public string casterMask;

        public string targetMask;

        public string targetZone;

        public string activationMask;

        public string activationZone;

        public int random;

        public int randomGroup;

        public int sequenceGroup;

        public bool isTargetTreatedAsCaster;

        public bool areTargetsAffectedConcurrently;

        public override string ToString()
        {
            return null;
        }

        public BoundScriptUsageData()
        {
        }
    }

}
