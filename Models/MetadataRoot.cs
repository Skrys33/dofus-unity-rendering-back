using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models
{
    // [PreferBinarySerialization]
    public class MetadataRoot<T> : IDataContainer // ScriptableObject
    {
        public MetadataDictionaryContainer<T> objectsById;

        public T GetObjectById(long id)
        {
            return default(T);
        }

        public List<T> GetObjects()
        {
            return null;
        }

        public MetadataRoot()
        {
        }
    }

}
