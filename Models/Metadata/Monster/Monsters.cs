using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using dofus_unity_rendering_back.Models.Interfaces;
using dofus_unity_rendering_back.Models.Types;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{
    [Serializable]
    public class Monsters : IAdminSelectionEntry
    {
        // [SerializeField]
        private MonsterFlags m_flags;

        [Key]
        public ushort id { get; set; }

        public int nameId{ get; set; }

        public ushort gfxId{ get; set; }

        public short race{ get; set; }

        public List<MonsterGrade> grades { get; set; }

        public string look{ get; set; }

        public List<AnimFunMonsterData> animFunList{ get; set; }

        public List<MonsterDrop> drops{ get; set; }

        public List<MonsterDrop> temporisDrops{ get; set; }

        public List<uint> subareas{ get; set; }

        public List<int> spells{ get; set; }

        public List<string> spellGrades{ get; set; }

        public ushort favoriteSubareaId{ get; set; }

        public ushort correspondingMiniBossId{ get; set; }

        public sbyte speedAdjust{ get; set; }

        public sbyte creatureBoneId{ get; set; }

        public List<uint> incompatibleIdols{ get; set; }

        public List<uint> incompatibleChallenges{ get; set; }

        public byte aggressiveZoneSize{ get; set; }

        public short aggressiveLevelDiff{ get; set; }

        public string aggressiveImmunityCriterion{ get; set; }

        public short aggressiveAttackDelay{ get; set; }

        public byte scaleGradeRef{ get; set; }

        public List<WrappedFloatList> characRatios;

        private string m_name{ get; set; }

        private string m_unDiacriticalName{ get; set; }

        private MonsterRaces m_type{ get; set; }

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
