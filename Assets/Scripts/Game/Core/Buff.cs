using System.Runtime.InteropServices;

namespace Game.Core
{
    public struct Buff
    {
        int id;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string name;                  //名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string icon;                  //显示的图标
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        string desc;                  //描述
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string effect;                //特效
        int restTime;                 //buff的剩余时间
    }
}