
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Effect.Instance
{

    [Serializable]
    public class EffectInstanceInteger : EffectInstance
    {
        public int value;

        public override object parameter0
        {
            get
            {
                return null;
            }
        }

        public override object parameter2
        {
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

        public virtual EffectInstance Add(EffectInstance instance)
        {
            return null;
        }

        public EffectInstanceInteger()
        {
        }
    }

}