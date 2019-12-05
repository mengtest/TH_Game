using System;
using UnityEngine;

namespace EX
{
    [RequireComponent(typeof(SpriteRenderer))]
    //播放帧动画的类
    public class AnimationEx: MonoBehaviour
    {
        [SerializeField]
        private Sprite _frame;

        private void Awake()
        {
//            this._frame = this.GetComponent<SpriteRenderer>().sprite;
//            this._frame = Resources.Load<Sprite>("Effect/loading/00013.png");
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Effect/loading/00013");
        }
    }
}