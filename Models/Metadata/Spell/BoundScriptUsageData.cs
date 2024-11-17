using System.ComponentModel.DataAnnotations;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Serializable]
    public class BoundScriptUsageData
    {
        public const int SerialSequenceGroup = 0;

        [Key]
        public int id { get; set; }

        public int order { get; set; }

        public int scriptId { get; set; }

        public List<uint> spellLevels { get; set; }

        public string criterion { get; set; }

        public string casterMask { get; set; }

        public string targetMask { get; set; }

        public string targetZone { get; set; }

        public string activationMask { get; set; }

        public string activationZone { get; set; }

        public int random { get; set; }

        public int randomGroup { get; set; }

        public int sequenceGroup { get; set; }

        public bool isTargetTreatedAsCaster { get; set; }

        public bool areTargetsAffectedConcurrently { get; set; }

        public override string ToString()
        {
            return null;
        }

        public BoundScriptUsageData()
        {
        }
    }

}
