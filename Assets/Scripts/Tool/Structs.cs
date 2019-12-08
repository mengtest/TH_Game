using UnityEngine;
using XLua;

partial class Global
{
    [System.Serializable]
    [LuaCallCSharp]
    public struct Pair<TKey, TValue>
    {
        public TKey First;
        public TValue Second;

        public Pair(TKey key, TValue value)
        {
            First = key;
            Second = value;
        }
    }

    [System.Serializable]
    public struct Injection
    {
        public string Name;
        public MonoBehaviour Value;
    }
}