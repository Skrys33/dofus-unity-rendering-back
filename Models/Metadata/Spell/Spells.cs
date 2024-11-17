using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dofus_unity_rendering_back.Models.Interfaces;
using dofus_unity_rendering_back.Models.Metadata.Enums;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Serializable]
    public class Spells : IAdminSelectionEntry
    {
        private class MemoizedValues
        {
            public List<SpellLevels> spellLevelDataList;

            public SpellVariants spellVariant;

            public MemoizedValues()
            {
            }
        }

        private SpellFlags m_flags { get; set; }

        private MemoizedValues m_memoizedValues;

        [Key]
        public ushort id { get; set; }

        public int nameId { get; set; }

        public int descriptionId { get; set; }
        [NotMapped]
        public string description { get; set; }

        public ushort typeId { get; set; }

        public byte order { get; set; }

        public string scriptParams { get; set; }

        public string scriptParamsCritical { get; set; }

        public byte scriptId { get; set; }

        public byte scriptIdCritical { get; set; }

        public short iconId { get; set; }

        public List<uint> spellLevels { get; set; }

        public List<BoundScriptUsageData> boundScriptUsageData;

        public List<BoundScriptUsageData> criticalHitBoundScriptUsageData;

        public SpellZoneDescr basePreviewZoneDescr;

        public string adminName { get; set; }
        public bool verboseCast
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool bypassSummoningLimit
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool canAlwaysTriggerSpells
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool hideCastConditions
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        [NotMapped]
        public string name { get; set; }

        [NotMapped]
        public List<SpellLevels> spellLevelsData { get; set; }

        [NotMapped]
        public SpellVariants spellVariant
        {
            get
            {
                return null;
            }
        }

        public IAdminSelectionEntryType adminSelectionEntryType
        {
            get
            {
                return null;
            }
        }

        public string adminSelectionName
        {
            get
            {
                return null;
            }
        }

        public int adminSelectionId
        {
            get
            {
                return default(int);
            }
        }

        public int adminSelectionIconId
        {
            get
            {
                return default(int);
            }
        }

        public uint adminSelectionTypeId
        {
            get
            {
                return default(uint);
            }
        }

        public static Spells GetById(long spellId)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public SpellLevels GetSpellLevelData(int rank)
        {
            return null;
        }

        public BoundScriptUsageData GetScriptUsageData(int index, bool isCritical)
        {
            return null;
        }

        public string GetScriptParam(int scriptIndex, string paramName, bool isCritical = false)
        {
            return null;
        }

        public SpellScriptType GetScriptType(int scriptIndex, bool isCritical = false)
        {
            return default(SpellScriptType);
        }

        public Spells()
        {
        }
    }

}