using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Types
{
    [Serializable]
    public class WrappedFloatList
    {
        public List<float> values { get; set; }

        public WrappedFloatList() 
        {
        }
    }

}
