using System.Runtime.InteropServices;

namespace Game.Core
{
    public static class Types
    {
        // public delegate void PlayerUpdateEvent(Player player);
        //
        // public delegate void PawnUpdateEvent(Pawn p);
        //
        // public delegate void PlayerStartBattle(Player p);
        //
        // public delegate void UserMsg(Msg msg);
        
        public delegate void UpdatePlayerMsgEvent(UpdatePlayerMsg p);
        
        // public delegate void UpdatePlayerInfoEvent(UpdatePlayerInfo p);
        
        public delegate void UpdatePawnMsgEvent(UpdatePawnMsg p);
        
        public delegate void UpdateCombatMsgEvent(UpdateCombatMsg p);
        
        //core回传给其他部分的消息体
        //type的具体含义
        //0、无效
        //1、受到伤害
        //2、受到治疗
        //3、最大能量增加
        //4、能量回复
        //5、能量回满
        //6、消耗能量
        //7、抽卡 高级、低级
        //8、召唤一个棋子
        //9、回收一个棋子
        //10、出售一个棋子
        //11、获得金币
        //12、消耗金币
        //13、退出房间
        //14、掉线
        //15、回到房间
        //16、认输
        //Msg是回传的信息
        //回传的消息
        public struct UpdatePlayerMsg
        {
            public int roomId;
            public int playerId;
            public int type;               
            public int num;                //具体的数值
        };
        
        //info是cs、js传递给cpp的消息
        //即玩家的操作，比如使用技能、召唤卡牌等
        //type的含义为
        //1、抽普通卡牌
        //2、抽高级卡牌
        //3、点击结束回合按钮        
        //4、点击自己的某张卡牌       （发动攻击）需要目标参数
        //5、使用技能                需要目标参数
        //6、回收棋子
        //7、认输
        //8、退出游戏                暂时保留这个
        public struct UpdatePlayerInfo
        {
            public int type;                   //这个消息所属的类型                     
            public int uid;                    //玩家的id
            public int pawnId;                 //棋子的id
            public int targetId;               //目标的id
            public int skillId;                //技能的id
            //房间id为隐藏属性，只有在执行的时候才回去获取
        };
        
        //type的含义，
        //0、无效
        //1、受到伤害
        //2、受到治疗
        //3、消耗魔法
        //4、扣除魔法
        //5、回复魔法
        //6、受到技能影响
        //7、受到buff影响
        //回传的消息
        public struct UpdatePawnMsg
        {
            public int roomId;
            public int pawnId;
            public int type;               
            public int num;                //具体的数值
            public int sourceId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public int[] targetId;
        };
        
        //回传的消息
        public struct UpdateCombatMsg
        {
            public int roomId;
	
        };
        
        //玩家操作相关
        public struct Cmd
        {
            public int id;                     //cmd预留的id
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string name;              //cmd的名称
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
            public string msg;             //具体的内容
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public int[] targetId;            //目标棋子id
            public int sourceId;               //自身的id
        };
    }
}