using System.Collections.Generic;

namespace Common.Core
{
    public class KeyValuePairList<TKey, TValue> : List<KeyValuePair<TKey, TValue>>
    {

        public void Add(TKey key, TValue value)
        {
            base.Add(KeyValuePair.Create(key, value));
        }

        public void Insert(TKey key, TValue value, int index)
        {
            base.Insert(index, KeyValuePair.Create(key, value));
        }
    }
}
