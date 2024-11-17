using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using dofus_unity_rendering_back.Models.Types;

namespace dofus_unity_rendering_back.Models.Metadata.Monster
{

    [Serializable]
    public class AnimFunMonsterData : AnimFunData
    {
        [Key]
        public new int animId { get; set; }

        [ForeignKey("Monsters")]
        public int Monstersid { get; set; }
        public override string ToString()
        {
            return null;
        }

        public AnimFunMonsterData()
        {
        }
    }
}
