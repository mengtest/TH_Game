using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EX
{
    [RequireComponent(typeof(Image))]
    //播放帧动画的类
    public class AnimationEx: MonoBehaviour
    {
        public enum State
        {
            PAUSE,
            PLAY,
            NULL,
        }
        
        [SerializeField]
        private Sprite[] _frames;

        [SerializeField] 
        private Image _image;
        
        [SerializeField]
        private int _curFrameIndex;

        private Action _callback;
        
        private int _loop = 0;
        private int _times = 0;
        private float _interval = 1;
        private State _pause = State.NULL;

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

        public void LoadImages([NotNull] string path)
        {
            if (path[path.Length - 1] != '/')
            {
                throw new Exception("无法为单张图片播放动画");
            }

            _frames = Resources.LoadAll<Sprite>(path);
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
                _pause = State.PAUSE;
                _curFrameIndex = frame;
                _image.sprite = _frames[frame];
            }
            else
            {
                //暂停当前动画的播放
                _pause = State.PAUSE;
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
            _pause = State.PLAY;
            Invoke(nameof(PlayFrame), delay);
        }

        public void Continue()
        {
            if (_pause != State.NULL)
            {
                _pause = 0;
                PlayFrame();    
            }
        }
        
        private void PlayFrame()
        {
            if (_pause == State.PAUSE)
            {
                return;
            }
            //当前播放对应的帧
            _image.sprite = _frames[_curFrameIndex];
            _image.SetNativeSize();
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