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

        private SpellFlags m_flags;

        private MemoizedValues m_memoizedValues;

        public ushort id;

        public int nameId;

        public int descriptionId;

        public ushort typeId;

        public byte order;

        public string scriptParams;

        public string scriptParamsCritical;

        public byte scriptId;

        public byte scriptIdCritical;

        public short iconId;

        public List<uint> spellLevels;

        public List<BoundScriptUsageData> boundScriptUsageData;

        public List<BoundScriptUsageData> criticalHitBoundScriptUsageData;

        public SpellZoneDescr basePreviewZoneDescr;

        public string adminName;
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

        public string name
        {
            get
            {
                return null;
            }
        }

        public List<SpellLevels> spellLevelsData
        {
            get
            {
                return null;
            }
        }

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