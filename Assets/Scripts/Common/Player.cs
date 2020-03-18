using System;

namespace Common
{
    [XLua.LuaCallCSharp]
    [XLua.CSharpCallLua]
    public class Player
    {
        public static void Init(int uid)
        {
            _uid = uid;
        }
        
        public static void Init(LoginRes msg)
        {
            _uid = msg.Uid;
            Level = msg.Level;
            Exp = msg.Exp;
            MaxExp = msg.MaxExp;
            Power = msg.Power;
            MaxPower = msg.MaxPower;
            Name = msg.Nickname;
            Gold = msg.Gold;
            Crystal = msg.Crystal;
        }
    
        private static int _uid;

        public static int Uid
        {
            get => _uid;
            set => throw new Exception("Uid是只读属性");
        }

        public static int Level { get; set; }
        
        public static int Exp { get; set; }
        
        public static int MaxExp { get; set; }
        
        public static string Name { get; set; }
        
        public static int Gold { get; set; }
        
        public static int Crystal { get; set; }
        
        public static int Power { get; set; }
        
        public static int MaxPower { get; set; }
    }
}