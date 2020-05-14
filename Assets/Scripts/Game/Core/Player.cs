using System.Runtime.InteropServices;

namespace Game.Core
{
    public struct Player
    {
        public int uid;                    //玩家的uid
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public string name;                //当前玩家的名称
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
        public string icon;                //当前玩家所选择的头像
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public int[] cards;                //本次战斗，该玩家所选择的卡组信息       这里是id而非unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public int[] pawns;                //当前玩家持有的所有卡牌的信息           这里应该是unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public int[] handCards;            //该玩家手上持有的卡信息              这里应该是unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public int[] combatCards;          //该玩家正在战斗的卡牌信息              这里应该是unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public int[] deckCards;            //卡池中所有的卡牌信息                  这里应该是unique_id
        public int hp;                     //玩家剩余的血量
        public int maxHp;                  //最大血量
        public int energy;                 //玩家当前的能量
        public int maxEnergy;              //玩家所能拥有的最大能量，指的是每回合开始，玩家拥有的初始能量
        public int gold;                   //玩家当前所持有的金币数
    }
}