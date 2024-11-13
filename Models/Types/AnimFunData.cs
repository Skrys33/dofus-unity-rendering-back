using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Types
{
    [Serializable]
    public class AnimFunData
    {
        public int animId;

        public int entityId;

        public string animName;

        public int animWeight;

        public AnimFunData()
        {
        }
    }
}