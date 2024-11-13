using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Effect
{

    [Serializable]
    public class Effects
    {
        public int id;

        public int descriptionId;

        public int iconId;

        public int characteristic;

        public int category;

        [JsonProperty("operator")]
        public string characteristicOperator;

        public bool showInTooltip;

        public bool useDice;

        public bool forceMinMax;

        public bool boost;

        public bool active;

        public int oppositeId;

        public string theoreticalDescriptionId;

        public int theoreticalPattern;

        public bool showInSet;

        public sbyte bonusType;

        public bool useInFight;

        public int effectPriority;

        public float effectPowerRate;

        public int elementId;

        public bool isInPercent;

        public bool hideValueInTooltip;

        private string m_description;

        private string m_theoreticalDescription;

        public string description
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

        public static Effects GetEffectById(long id)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public Effects()
        {
        }
    }
}