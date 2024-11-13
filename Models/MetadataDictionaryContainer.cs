using System.Runtime.InteropServices;

namespace dofus_unity_rendering_back.Models
{

    [Serializable]
    public class MetadataDictionaryContainer<T> : Dictionary<long, T>// , ISerializationCallbackReceiver
    {
        // [SerializeField]
        private long[] m_keys;

        // [SerializeField]
        // [SerializeReference]
        private T[] m_values;

        public MetadataDictionaryContainer()
        {
        }

        protected MetadataDictionaryContainer(IEqualityComparer<long> comparer)
        {
        }

        protected MetadataDictionaryContainer(int capacity)
        {
        }

        protected MetadataDictionaryContainer(int capacity, IEqualityComparer<long> comparer)
        {
        }

        protected MetadataDictionaryContainer(IDictionary<long, T> dictionary)
        {
        }

        protected MetadataDictionaryContainer(IDictionary<long, T> dictionary, IEqualityComparer<long> comparer)
        {
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }
    }
}
