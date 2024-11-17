using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace dofus_unity_rendering_back.Models.Metadata.Effect
{

    [Serializable]
    public class Effects
    {
        [Key]
        public int id { get; set; }

        public int descriptionId { get; set; }

        public int iconId { get; set; }

        public int characteristic { get; set; }

        public int category { get; set; }

        [JsonProperty("operator")]
        public string characteristicOperator;

        public bool showInTooltip { get; set; }

        public bool useDice { get; set; }

        public bool forceMinMax { get; set; }

        public bool boost { get; set; }

        public bool active { get; set; }

        public int oppositeId { get; set; }

        public string theoreticalDescriptionId { get; set; }

        public int theoreticalPattern { get; set; }

        public bool showInSet { get; set; }

        public sbyte bonusType { get; set; }

        public bool useInFight { get; set; }

        public int effectPriority { get; set; }

        public float effectPowerRate { get; set; }

        public int elementId { get; set; }

        public bool isInPercent { get; set; }

        public bool hideValueInTooltip { get; set; }

        private string m_description { get; set; }

        private string m_theoreticalDescription { get; set; }

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