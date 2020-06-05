using UnityEngine;
using UnityEngine.UI;

// https://blog.csdn.net/yzx5452830/article/details/80280864
//这个是位图字体的参考文章
// https://blog.csdn.net/u014230923/article/details/51352284?utm_medium=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-3.nonecase&depth_1-utm_source=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-3.nonecase
//这个是拖拽效果的参考文章
// https://www.cnblogs.com/MrZivChu/p/hotupdate.html
// 资源热更新的文件下载参考文章
// https://zhuanlan.zhihu.com/p/66582899
// 帧同步
// https://blog.csdn.net/dingxiaowei2013/article/details/77814966
// 客户端资源下载

// https://zhuanlan.zhihu.com/p/78669458
// skynet


namespace Prefab
{
    public class CombatSceneCombatCardScript: MonoBehaviour
    {
        //先想想所有的卡牌控件有哪些信息
        //hp
        //mp
        //def
        //主要是技能要如何表示出来

        //需要实现的功能有
        //  显示图片的更新
        //  属性的更新
        //  类型外框的更新
        //  点击自己或者敌方的棋子后可以显示其详细信息
        //  向前拖拽自己的棋子后可以对敌方的棋子(或玩家)发动攻击
        //  点击棋子后再详细信息中有当前棋子的技能(或者，直接将当前棋子所有的技能显示在棋子的底部)


        public Text hp;

        public Text mp;

        //点击这里时需要展示这个卡牌的相信信息
        [Tooltip("卡牌的内容")]
        public Image content;

        [Tooltip("卡牌的外框")]
        public Image boarder;

        //长按这个技能展示这个技能的详细信息
        //点击每个技能时，如果是主动技能则根据这个技能的实际情况判断是否需要释放这个技能
        //如果不满足技能的使用条件，需要显示为灰色，同时点击这个技能使用时提示不满足条件无法使用
        [Tooltip("当前卡牌所拥有的所有技能")]
        public Image[] skill;

        private void Awake() 
        {
            
        }

        private void Start() 
        {
            
        }
    };
}