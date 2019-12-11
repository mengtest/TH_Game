using System;
using UnityEngine;
using UnityEngine.UI;

namespace LuaFramework
{
    public class LuaManager : MonoBehaviour
    {
        [SerializeField]
        private Global.Pair<MonoBehaviour, string>[] _regFunctions;

        private void Awake()
        {
            foreach (Global.Pair<MonoBehaviour,string> f in _regFunctions)
            {
                var value = f.First.GetType().GetProperty("")?.GetValue(f.First);
                value?.GetType().GetMethod("AddListener")?.Invoke(value, new object[] {new Action(() =>
                {
                    
                })});
            }
        }
    }
}