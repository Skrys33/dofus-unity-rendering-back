using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models.Types
{
    [Serializable]
    public class AnimFunData
    {
        [Key]
        public int animId { get; set; }

        public int entityId { get; set; }

        public string animName { get; set; }

        public int animWeight { get; set; }

        public AnimFunData()
        {
        }
    }
}