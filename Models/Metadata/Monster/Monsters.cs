using System.Runtime.InteropServices;
using dofus_unity_rendering_back.Models.Interfaces;
using dofus_unity_rendering_back.Models.Types;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{
    [Serializable]
    public class Monsters : IAdminSelectionEntry
    {
        // [SerializeField]
        private MonsterFlags m_flags;

        public ushort id;

        public int nameId;

        public ushort gfxId;

        public short race;

        public List<MonsterGrade> grades;

        public string look;

        public List<AnimFunMonsterData> animFunList;

        public List<MonsterDrop> drops;

        public List<MonsterDrop> temporisDrops;

        public List<uint> subareas;

        public List<int> spells;

        public List<string> spellGrades;

        public ushort favoriteSubareaId;

        public ushort correspondingMiniBossId;

        public sbyte speedAdjust;

        public sbyte creatureBoneId;

        public List<uint> incompatibleIdols;

        public List<uint> incompatibleChallenges;

        public byte aggressiveZoneSize;

        public short aggressiveLevelDiff;

        public string aggressiveImmunityCriterion;

        public short aggressiveAttackDelay;

        public byte scaleGradeRef;

        public List<WrappedFloatList> characRatios;

        private string m_name;

        private string m_unDiacriticalName;

        private MonsterRaces m_type;

        public bool useSummonSlot
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool useBombSlot
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool isBoss
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool isMiniBoss
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool isQuestMonster
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool fastAnimsFun
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canPlay
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canTackle
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canBePushed
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canSwitchPos
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canSwitchPosOnTarget
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canBeCarried
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool canUsePortal
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool allIdolsDisabled
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool useRaceValues
        {
            get
            {
                return default;
            }
            set
            {
            }
        }

        public bool soulCaptureForbidden
        {
            get
            {
                return default;
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

        public string unDiacriticalName
        {
            get
            {
                return null;
            }
        }

        public MonsterRaces type
        {
            get
            {
                return null;
            }
        }

        public bool isAggressive
        {
            get
            {
                return default;
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
                return default;
            }
        }

        public int adminSelectionIconId
        {
            get
            {
                return default;
            }
        }

        public uint adminSelectionTypeId
        {
            get
            {
                return default;
            }
        }

        public MonsterGrade GetMonsterGrade(int grade)
        {
            return null;
        }

        public int AggressionLevel(int grade)
        {
            return default;
        }

        public float GetCharacRatio(uint characId)
        {
            return default;
        }

        public static Monsters GetById(long id)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public Monsters()
        {
        }
    }
}
