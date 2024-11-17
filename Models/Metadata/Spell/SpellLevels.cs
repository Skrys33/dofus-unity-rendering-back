using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using dofus_unity_rendering_back.Models.Metadata.Effect.Instance;
using dofus_unity_rendering_back.Models.Metadata.Enums;

namespace dofus_unity_rendering_back.Models.Metadata.Spell
{

    [Serializable]
    public class SpellLevels
    {
        private SpellLevelFlags m_flags;

        [Key]
        public int id { get; set; }

        [ForeignKey("Spells")]
        public short spellId { get; set; }

        public int grade { get; set; }

        public ushort spellBreed { get; set; }

        public short apCost { get; set; }

        public byte minRange { get; set; }

        public byte range { get; set; }

        public short criticalHitProbability { get; set; }

        public sbyte maxStack { get; set; }

        public sbyte maxCastPerTurn { get; set; }

        public byte maxCastPerTarget { get; set; }

        public byte minCastInterval { get; set; }

        public sbyte initialCooldown { get; set; }

        public sbyte globalCooldown { get; set; }

        public short minPlayerLevel { get; set; }

        public string statesCriterion { get; set; }

        [NotMapped]
        public List<EffectInstanceDice> effects { get; set; }

        [NotMapped]
        public List<EffectInstanceDice> criticalEffect { get; set; }

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