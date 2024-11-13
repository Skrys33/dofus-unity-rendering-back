using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Effect.Instance
{

    [Serializable]
    public class EffectInstanceDice : EffectInstanceInteger
    {
        public int diceNum;

        public int diceSide;

        public override object parameter0
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public override object parameter1
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public override object parameter2
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

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