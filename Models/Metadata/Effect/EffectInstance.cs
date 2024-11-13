using dofus_unity_rendering_back.Models.Metadata.Enums;
using dofus_unity_rendering_back.Models.Metadata.Spell;

namespace dofus_unity_rendering_back.Models.Metadata.Effect
{

    [Serializable]
    public class EffectInstance
    {
        private class MemoizedValues
        {
            public int category;

            public sbyte bonusType;

            public Effects effectData;

            public bool? showSet;

            public bool? hideValueInTooltip;

            public bool? isInPercent;

            public bool? useInFight;

            public sbyte durationStringValue;

            public byte delayStringValue;

            public int priority;

            public string durationString;

            public string description;

            public string theoreticalDescription;

            public string descriptionForTooltip;

            public string theoricDescriptionForTooltip;

            public string theoreticalShortDescriptionForTooltip;

            public string characteristicOperator;

            public object parameter0;

            public object parameter1;

            public object parameter2;

            public object parameter3;

            public object parameter4;

            public T GetMemoizedValue<T>(ActionId effectId, ref T localCachedCopy, T undefinedSentinel, Func<T> populate)
            {
                return (T)null;
            }

            public T GetMemoizedValue<T>(ActionId effectId, ref T localCachedCopy, Func<T, bool> isAlreadyPopulated, Func<T> populate)
            {
                return (T)null;
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

        [SerializeField]
        private EffectInstanceFlags m_flags;

        public int effectUid;

        public short baseEffectId;

        public ActionId effectId;

        public int order;

        public short targetId;

        public string targetMask;

        public sbyte duration;

        public float random;

        public short group;

        public short modificator;

        public byte dispellable;

        public byte delay;

        public string triggers;

        public sbyte effectElement;

        public short spellId;

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

        public virtual object parameter0
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public virtual object parameter1
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public virtual object parameter2
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public virtual object parameter3
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public virtual object parameter4
        {
            get
            {
                return null;
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