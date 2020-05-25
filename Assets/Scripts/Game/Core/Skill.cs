using System.Runtime.InteropServices;

namespace Game.Core
{
    public struct Skill
    {
        int id;                   //技能的id
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string name;              //技能显示在界面中需要展示的信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        string icon;              //技能的图标
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        string desc;              //技能的描述
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        string effect;            //使用这个技能后播放的特效
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        string ani;               //使用这个技能后播放的动画
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
        string sound;             //播放的音效
    }
}