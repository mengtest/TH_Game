using EX;
using UnityEngine;

namespace Editor
{
    public static class MenuComponent
    {
        [ContextMenu("初始化")]
        public static void ToScrollList(this ButtonEx self)
        {
            Global.Log(self.name);
            Global.Log("asdasdasdasdasdasdasdasd");
        }
    }
}