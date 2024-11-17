using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dofus_unity_rendering_back.Models.Metadata.Enums;
using dofus_unity_rendering_back.Models.Metadata.Spell;

namespace dofus_unity_rendering_back.Models.Metadata.Effect
{

    [Serializable]
    public class EffectInstance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        private class MemoizedValues
        {
            public int category { get; set; }

            public sbyte bonusType { get; set; }

            [NotMapped]
            public Effects effectData { get; set; }

            public bool? showSet;

            public bool? hideValueInTooltip;

            public bool? isInPercent;

            public bool? useInFight;

            public sbyte durationStringValue { get; set; }

            public byte delayStringValue { get; set; }

            public int priority { get; set; }

            public string durationString { get; set; }

            public string description { get; set; }

            public string theoreticalDescription { get; set; }

            public string descriptionForTooltip { get; set; }

            public string theoricDescriptionForTooltip { get; set; }

            public string theoreticalShortDescriptionForTooltip { get; set; }

            public string characteristicOperator { get; set; }


            public T GetMemoizedValue<T>(ActionId effectId, ref T localCachedCopy, T undefinedSentinel, Func<T> populate)
            {
                return default(T);
            }

            public T GetMemoizedValue<T>(ActionId effectId, ref T localCachedCopy, Func<T, bool> isAlreadyPopulated, Func<T> populate)
            {
                return default(T);
            }

            public MemoizedValues()
            {
            }
        }

        private enum UndefinedValues
        {
            UndefinedCategory = -2,
            UndefinedShow
        }

        private const sbyte UninitializedBonusType = -2;

        private EffectInstanceFlags m_flags { get; set; }

        public int effectUid { get; set; }

        public short baseEffectId { get; set; }

        public ActionId effectId { get; set; }

        public int order { get; set; }

        public short targetId { get; set; }

        public string targetMask { get; set; }

        public sbyte duration { get; set; }

        public float random { get; set; }

        public short group { get; set; }

        public short modificator { get; set; }

        public byte dispellable { get; set; }

        public byte delay { get; set; }

        public string triggers { get; set; }

        public sbyte effectElement { get; set; }

        [ForeignKey("Spells")]
        public short spellId { get; set; }

        public SpellZoneDescr zoneDescr;

        private const string UnknownName = "???";

        private const string UndefinedDescription = "undefined";

        [NonSerialized]
        private MemoizedValues m_memoizedValues;

        private const string UiPetWeightNominal = "ui.petWeight.nominal";

        private const string UiTooltipMonsterXpAlone = "ui.tooltip.monsterXpAlone";

        private const string UiCommonMaximum = "ui.common.maximum";

        private const string UiCommonNone = "ui.common.none";

        private const string UiPetWeightLean = "ui.petWeight.lean";

        private const string UiPetWeightFat = "ui.petWeight.fat";

        private const string UiItemTooltipGiveSpellCategory = "ui.itemtooltip.giveSpellCategory";

        private const string UiEffectBoostedSpellComplement = "ui.effect.boosted.spell.complement";

        private const string UiCommonRandom = "ui.common.random";

        private const string UiEffectRandomProbability = "ui.effect.randomProbability";

        private const string UiEffectUnknownMonster = "ui.effect.unknownMonster";

        public bool visibleInTooltip
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool visibleInBuffUi
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool visibleInFightLog
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool visibleOnTerrain
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool forClientOnly
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool trigger
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public byte zoneSize
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public SpellZoneShape zoneShape
        {
            get
            {
                return default(SpellZoneShape);
            }
            set
            {
            }
        }

        public byte zoneMinSize
        {
            get
            {
                return default(byte);
            }
            set
            {
            }
        }

        public int zoneDamageDecreaseStepPercent
        {
            get
            {
                return default(int);
            }
        }

        public int zoneMaxDamageDecreaseApplyCount
        {
            get
            {
                return default(int);
            }
        }

        public bool zoneStopAtTarget
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }


        public bool useInFight
        {
            get
            {
                return default(bool);
            }
        }

        public string description
        {
            get
            {
                return null;
            }
        }

        public string characteristicOperator
        {
            get
            {
                return null;
            }
        }

        public string theoreticalDescription
        {
            get
            {
                return null;
            }
        }

        public string descriptionForTooltip
        {
            get
            {
                return null;
            }
        }

        public string theoreticalDescriptionForTooltip
        {
            get
            {
                return null;
            }
        }

        public string theoreticalShortDescriptionForTooltip
        {
            get
            {
                return null;
            }
        }

        public bool showInSet
        {
            get
            {
                return default(bool);
            }
        }

        public bool hideValueInTooltip
        {
            get
            {
                return default(bool);
            }
        }

        public bool isInPercent
        {
            get
            {
                return default(bool);
            }
        }

        public int oppositeId
        {
            get
            {
                return default(int);
            }
        }

        public int category
        {
            get
            {
                return default(int);
            }
            set
            {
            }
        }

        public string durationString
        {
            get
            {
                return null;
            }
        }

        public int priority
        {
            get
            {
                return default(int);
            }
        }

        public void ForceDescriptionRefresh()
        {
        }
        private string GetTurnCountStr(bool bShowLast)
        {
            return null;
        }

        private void ParseZone(string rawZone)
        {
        }

        public int BonusType()
        {
            return default(int);
        }

        public override string ToString()
        {
            return null;
        }
        public virtual EffectInstance Clone()
        {
            return null;
        }

        private string GetSpellName(object id)
        {
            return null;
        }

        private string GetEmoticonName(object id)
        {
            return null;
        }

        private string GetItemTypeName(object id)
        {
            return null;
        }

        private string GetMonsterName(object id)
        {
            return null;
        }

        private string GetCompanionName(object id)
        {
            return null;
        }

        private string GetMonsterGrade(object pId, object pGrade)
        {
            return null;
        }

        private string GetSpellLevelName(object id)
        {
            return null;
        }

        private string GetLegendaryPowerCategoryName(object id)
        {
            return null;
        }

        private string GetJobName(object id)
        {
            return null;
        }

        private string GetDocumentTitle(object id)
        {
            return null;
        }

        private string GetAlignmentSideName(object id)
        {
            return null;
        }

        private string GetItemName(object id)
        {
            return null;
        }

        private string GetMonsterSuperRaceName(object id)
        {
            return null;
        }

        private string GetMonsterRaceName(object id)
        {
            return null;
        }

        private string GetTitleName(object id)
        {
            return null;
        }

        private string GetMountFamilyName(object id)
        {
            return null;
        }

        private string GetStatName(object id)
        {
            return null;
        }

        private List<object> GetParamList()
        {
            return null;
        }

        private string PrepareDescription(string desc, bool forTooltip = false, bool shortDesc = false)
        {
            return null;
        }

        private int? GetInt(object obj)
        {
            return null;
        }

        private long? GetLong(object obj)
        {
            return null;
        }

        public static EffectInstance GetNullEffectInstance(EffectInstance e)
        {
            return null;
        }

        public EffectInstance()
        {
        }
    }
}