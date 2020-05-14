using Lib;
using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class CombatCardItemScript : LuaView
    {
        [Tooltip("当前item所显示的小图对象")]
        public Image icon;

        [Tooltip("当前item所显示的")]
        public Text count;

        // private void Awake()
        // { 
        //     RegisterHandle((view, value) =>
        //     {
        //         
        //     });
        // }
    }
}