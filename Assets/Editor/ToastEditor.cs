using EX;
using Prefab;
using UnityEditor;

namespace Editor
{
    [CustomEditor(typeof(ToastScript))]
    public class ToastEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            var obj = target as ToastScript;
            if (obj != null) obj.Redraw();
        }
    }
}