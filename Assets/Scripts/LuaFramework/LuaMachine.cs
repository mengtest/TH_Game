using UnityEngine;

namespace LuaFramework
{
    //在inspector中通过设置来减少需要修改的代码量
    public class LuaMachine : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] _objects;

        [SerializeField]
        private MonoBehaviour[] _behaviours;
        
        
    }
}