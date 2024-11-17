using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Effect.Instance
{

    [Serializable]
    public class EffectInstanceDice : EffectInstanceInteger
    {
        public int diceNum { get; set; }

        public int diceSide { get; set; }

        public override EffectInstance Clone()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public override EffectInstance Add(EffectInstance term)
        {
            return null;
        }

        public EffectInstanceDice()
        {
        }
    }
}