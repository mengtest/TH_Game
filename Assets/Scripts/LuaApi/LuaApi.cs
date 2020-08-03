using System.Runtime.InteropServices;
using System;

public class LuaApi
{
    public struct AttrStruct
    {
        public int combatId;   //ս��ʵ����id           //���������Ҫ��Ϊ�ˣ����������ӷ���˵Ļ���������Ա�ʶΨһ��combat
        public int playerId;   //Ŀ����ҵ�id�����������ǰ����������ң�������Ϊ0
        public int objectId;   //���Ըı��˵�Ŀ������id(�������ӵ�id��buffId���������ң����Բ���)
        public int value;      //���Ըı���ֵ
        public int type;       //�ı������������(����ο�constant�������ٵ�ֵ)
        public int targetType; //�������ԣ���ʾ��ǰ�����ʾ���������͵ģ�0����Ч 1������ 2����� 3��buff 4��ս������
    };

    public struct BuffD
    {
        public int id;
        public int restTime;               //buff��ʣ��ʱ��
        public int unique_id;              //Ϊ���buff�����uid
        public int overlay;
    };

    public struct PawnD
    {
        //����ӵ�еļ�������Թ̶��ģ�ֻҪ֪����ʲô���Ӿ���֪�������������Щ���ܣ����Բ��������Ӽ��ܵ���Ϣ
        public int id;
        public int unique_id;          //����ս���лᱻ�����Ψһid(ÿ��ս����ʼ��ʱ�򣬻��ȡ������ҵ�ǰ�����п��ƣ�ͬʱΪ��Щ���Ʒ���Ψһ��id)
        public int hp;                 //����ֵ
        public int mp;                 //ħ��ֵ
        public int matk;               //ħ��������
        public int atk;                //������
        public int def;                //������
        public int mdef;               //ģ�·�����
        public int playerId;           //����������ӵ����id
        public int type;               //n��r��sr��ssr
        public int posType;            //��ǰ�������ڵĵط�������
        public int pos;                //�������ڵ��±�
    };

    struct PlayerS
    {
        public int uid;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public int[] cards;                          //����ս�����������ѡ��Ŀ�����Ϣ       ������id����unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public int[] pawns;                          //��ǰ��ҳ��е����п��Ƶ���Ϣ           ����Ӧ����unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public int[] handCards;           //��������ϳ��еĿ�����Ϣ              ����Ӧ����unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public int[] combatCards;                     //���������ս���Ŀ�����Ϣ              ����Ӧ����unique_id
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public int[] deckCards;                      //���������еĿ�����Ϣ                  ����Ӧ����unique_id
        public int hp;                                 //���ʣ���Ѫ��
        public int maxHp;                              //���Ѫ��
        public int energy;                             //��ҵ�ǰ������
        public int maxEnergy;                          //�������ӵ�е����������ָ����ÿ�غϿ�ʼ�����ӵ�еĳ�ʼ����
        public int gold;                               //��ҵ�ǰ�����еĽ����
    };

    public delegate void UpdateAction(AttrStruct attr);
    public delegate void NoticeFunction(string str);

    public const string DllName = @"THCore";

    //������CS��һЩapi
	//��ȡ��һ��buff��ʵ������(չʾ����)
    //��������ķ���ֵ������BuffS
    [DllImport(DllName)]
	public static extern IntPtr get_buff(int combatId, int buffId);

	//��ȡ��һ��pawn��ʵ������(չʾ����)
    //��������ķ���ֵ������PawnS
    [DllImport(DllName)]
	public static extern IntPtr get_pawn(int combatId, int pawnId);

	//��ȡ��һ����ҵ�ʵ������(չʾ����)
    //�����ʵ�ʷ�������ΪPlayerD��û��PlayerS����
    [DllImport(DllName)]
	public static extern IntPtr get_player(int combatId, int uid);

    //�����ȡcore�е�luaջ
    [DllImport(DllName)]
	public static extern IntPtr get_lua_state();

    //�����������cs�˻���js�˻�ȡ����ս�������е�������Ϣ����
    [DllImport(DllName)]
	public static extern void set_update_action(UpdateAction fun);

    //�����������cs�˻���js�˻�ȡս���е��Զ�����Ϣ�����յ���ϢΪһ���ַ���
	[DllImport(DllName)]
	public static extern void set_notice_action(NoticeFunction fun);
}