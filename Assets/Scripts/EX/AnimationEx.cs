using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace EX
{
    /// <summary>
    /// 播放帧动画的类
    /// </summary>
    [RequireComponent(typeof(Image))]
    public class AnimationEx: MonoBehaviour
    {
        /// <summary>
        /// 当前动画所处的状态
        /// </summary>
        public enum State
        {
            Pause,
            Play,
            Null,
        }
        
        [FormerlySerializedAs("_frames")]
        [SerializeField]
        private Sprite[] frames;

        [FormerlySerializedAs("_image")]
        [SerializeField] 
        private Image image;
        
        [FormerlySerializedAs("_curFrameIndex")]
        [SerializeField]
        private int curFrameIndex;

        private Action _callback;
        
        private int _loop = 0;
        private int _times = 0;
        private float _interval = 1;
        private State _pause = State.Null;

        //加载图片
        public void LoadImages([NotNull] string[] paths)
        {
            frames = new Sprite[paths.Length];
            var index = 0;
            foreach (var path in paths)
            {
                var res = Util.Loader.Load<Sprite>(path)/* as Texture2D*/;
                frames[index] = /*Sprite.Create(res, new Rect(0, 0, res.width, res.height), new Vector2(0.5f, 0.5f));*/
                    res;
                index++;
            }
        }

        public void LoadImages([NotNull] string path)
        {
            throw new Exception("暂时无法使用这个api");
            
            // if (path[path.Length - 1] != '/')
            // {
            //     throw new Exception("无法为单张图片播放动画");
            // }
            
            // _frames = Resources.LoadAll<Sprite>(path);
        }

        private void Awake()
        {
            image = GetComponent<Image>();
        }

        //将该动画停止到第几帧
        public void Pause(int frame = -1)
        {
            if (frame >= 0 && frame < this.frames.Length)
            {
                //将动画停止到对应的帧
                _pause = State.Pause;
                curFrameIndex = frame;
                image.sprite = frames[frame];
            }
            else
            {
                //暂停当前动画的播放
                _pause = State.Pause;
            }
        }

        //停止当前动画
        public void Stop(bool destroy = true)
        {
            Destroy(gameObject);
        }
        
        //时间全部以秒为单位
        public void Play(float delay, float interval, int loop = 1, Action callback = null)
        {
            _loop = loop;
            _times = 0;
            _interval = interval;
            _callback = callback;
            _pause = State.Play;
            Invoke(nameof(PlayFrame), delay);
        }

        public void Continue()
        {
            if (_pause != State.Null)
            {
                _pause = 0;
                PlayFrame();    
            }
        }
        
        private void PlayFrame()
        {
            if (_pause == State.Pause)
            {
                return;
            }
            //当前播放对应的帧
            image.sprite = frames[curFrameIndex];
            image.SetNativeSize();
            curFrameIndex++;
            //如果帧数超过动画的总数，重回第一帧，播放次数加一
            if (curFrameIndex >= frames.Length)
            {
                curFrameIndex = 0;
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