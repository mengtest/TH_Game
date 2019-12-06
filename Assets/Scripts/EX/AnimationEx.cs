using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EX
{
    [RequireComponent(typeof(SpriteRenderer))]
    //播放帧动画的类
    public class AnimationEx: MonoBehaviour
    {
        [SerializeField]
        private Sprite[] _frames;

        [SerializeField] 
        private Image _image;
        
        [SerializeField]
        private int _curFrameIndex;

        private Action _callback;
        
        private int _loop = 0;
        private int _times = 0;
        private float _interval;
        private bool _pause;

        //加载图片
        public void LoadImages([NotNull] string[] paths)
        {
            _frames = new Sprite[paths.Length];
            var index = 0;
            foreach (var path in paths)
            {
                var res = Resources.Load<Sprite>(path);
                _frames[index] = res;
                index++;
            }
        }

        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        //将该动画停止到第几帧
        public void Pause(int frame = -1)
        {
            if (frame >= 0 && frame < this._frames.Length)
            {
                //将动画停止到对应的帧
                this._pause = true;
                this._curFrameIndex = frame;
                this._image.sprite = _frames[frame];
            }
            else
            {
                //暂停当前动画的播放
                this._pause = true;    
            }
        }

        //停止当前动画
        public void Stop(bool destroy = true)
        {
            
        }
        
        //时间全部以秒为单位
        public void Play(float delay, float interval, int loop = 1, Action callback = null)
        {
            _loop = loop;
            _times = 0;
            _interval = interval;
            _callback = callback;
            Invoke(nameof(PlayFrame), delay);
        }

        private void PlayFrame()
        {
            if (this._pause)
            {
                return;
            }
            //当前播放对应的帧
            _image.sprite = _frames[_curFrameIndex];
            _curFrameIndex++;
            //如果帧数超过动画的总数，重回第一帧，播放次数加一
            if (_curFrameIndex >= _frames.Length)
            {
                _curFrameIndex = 0;
                _times++;
            }
            //如果播放次数等于循环次数，则不再递归调用
            if (_times != _loop)
            {
                Invoke(nameof(PlayFrame), _interval);
            }
            else
            {
                _callback?.Invoke();
            }
        }
    }
}