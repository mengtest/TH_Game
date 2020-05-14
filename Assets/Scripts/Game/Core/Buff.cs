using System.Runtime.InteropServices;

namespace Game.Core
{
    public struct Buff
    {
        int id;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        string name;                  //名称
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        string icon;                  //显示的图标
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        string desc;                  //描述
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        string effect;                //特效
        int restTime;                 //buff的剩余时间
    }
}