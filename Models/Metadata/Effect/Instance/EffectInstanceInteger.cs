
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Metadata.Effect.Instance
{

    [Serializable]
    public class EffectInstanceInteger : EffectInstance
    {
        public int value { get; set; }


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