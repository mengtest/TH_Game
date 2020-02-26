using EX;
using LuaFramework;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Editor
{
    public static class EditorExtend
    {
        [MenuItem("GameObject/yuki/LuaManager")]
        public static void AddLuaManager()
        {
            var obj = new GameObject("LuaManager");
            obj.AddComponent<LuaManager>();
        }

        [MenuItem("GameObject/yuki/ButtonEX")]
        public static void AddButtonEx()
        {
            var btnEx = new GameObject("ButtonEX", typeof(ButtonEx));
            var text = new GameObject("Text", typeof(Text));
            text.GetComponent<Text>().text = "Button";
            text.GetComponent<Text>().color = Color.black;
            text.transform.parent = btnEx.transform;
        }
        
        // [MenuItem("GameObject/yuki/Toast")]
        // public static void AddToastEx()
        // {
        //     var btnEx = new GameObject("ButtonEX", typeof(ButtonEx));
        //     var text = new GameObject("Text", typeof(Text));
        //     text.GetComponent<Text>().text = "Button";
        //     text.GetComponent<Text>().color = Color.black;
        //     text.transform.parent = btnEx.transform;
        // }
    }
}