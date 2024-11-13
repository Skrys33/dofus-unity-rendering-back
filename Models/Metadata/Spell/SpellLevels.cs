using System.Runtime.InteropServices;
using dofus_unity_rendering_back.Models.Metadata.Effect.Instance;
using dofus_unity_rendering_back.Models.Metadata.Enums;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Serializable]
    public class SpellLevels
    {
        private SpellLevelFlags m_flags;

        public int id;

        public short spellId;

        public int grade;

        public ushort spellBreed;

        public short apCost;

        public byte minRange;

        public byte range;

        public short criticalHitProbability;

        public sbyte maxStack;

        public sbyte maxCastPerTurn;

        public byte maxCastPerTarget;

        public byte minCastInterval;

        public sbyte initialCooldown;

        public sbyte globalCooldown;

        public short minPlayerLevel;

        public string statesCriterion;

        public List<EffectInstanceDice> effects;

        public List<EffectInstanceDice> criticalEffect;

        public List<PreviewSpellZoneDescr> previewZones;

        public bool hideEffects
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool hidden
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool playAnimation
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool castInLine
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool castInDiagonal
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool castTestLos
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool needFreeCell
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool needTakenCell
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool needFreeTrapCell
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool rangeCanBeBoosted
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool needVisibleEntity
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool needCellWithoutPortal
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool portalProjectionForbidden
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public Spells spell
        {
            get
            {
                return null;
            }
        }

        public bool canThrowPlayer
        {
            get
            {
                return default(bool);
            }
        }

        public bool canSummon
        {
            get
            {
                return default(bool);
            }
        }

        public bool canBomb
        {
            get
            {
                return default(bool);
            }
        }

        public override string ToString()
        {
            return null;
        }

        public bool HasZoneShape(SpellZoneShape shape)
        {
            return default(bool);
        }

        public static SpellLevels GetLevelById(int id)
        {
            return null;
        }

        public SpellLevels()
        {
        }
    }

}