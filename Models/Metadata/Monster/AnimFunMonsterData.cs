using System.ComponentModel.DataAnnotations;
using dofus_unity_rendering_back.Models.Types;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class AnimFunMonsterData : AnimFunData
    {
        [Key]
        public new int animId { get; set; }
        public override string ToString()
        {
            return null;
        }

        public AnimFunMonsterData()
        {
        }
    }
}
