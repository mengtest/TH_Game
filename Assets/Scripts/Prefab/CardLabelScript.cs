using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    /// <summary>
    /// 选择卡组的时候，左侧的简要信息展示
    /// </summary>
    public class CardLabelScript: MonoBehaviour
    {
        /// <summary>
        /// 当前所显示的icon
        /// </summary>
        public Image icon;

        /// <summary>
        /// 当前所显示的名称
        /// </summary>
        public Text label;

        /// <summary>
        /// 当前显示的数量
        /// </summary>
        public Text count;

        /// <summary>
        /// 卡牌的数量
        /// </summary>
        public int number;

        /// <summary>
        /// 
        /// </summary>
        public string cardName;

        /// <summary>
        /// 
        /// </summary>
        public string rareType;
    }
}