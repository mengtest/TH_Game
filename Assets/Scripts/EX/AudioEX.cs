using System;
using DG.Tweening;
using UnityEngine;


//暂时没有考虑暂停的问题，只是单纯的实现了连续播放的功能
namespace EX
{
    [RequireComponent(typeof(AudioSource))]
    //连续播放不同的音乐
    //这个类没有继承于AudioSource(sealed)，但是实际上就是对AudioSource功能的扩展
    public class AudioEx : MonoBehaviour
    {
        [Tooltip("要播放的音乐文件路径列表")]
        [SerializeField]
        private string[] _resources;

        public float Volume
        {
            get
            {
                if (_audio != null)
                {
                    return _audio.volume;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (_audio != null)
                {
                    _audio.volume = value;
                }
                else
                {
//                StartCoroutine(nameof(VolumeInit));
//                _audio.volume = value;
                }
            }
        }

        //指向当前正在播放的音乐的下标
        private int _index = 0;

        private AudioSource _audio;

        private bool _loop;

        // Start is called before the first frame update
        //    private void Start()
        //    {
        //        _audio = GetComponent<AudioSource>();
        //    }

        //在对象构造的时候调用，这个的调用比Start更早
        //Start会在脚本被启动(enable)的时候调用
        private void Awake()
        {
            _audio = GetComponent<AudioSource>();
        }

//    private IEnumerator VolumeInit()
//    {
//        yield return new WaitUntil(
//            () => _audio != null
//                  );
//    }

//    private async void VolumeInit()
//    {
//        await Task.Run(() =>
//        {
//            while (_audio != null)
//            {
//
//            }
//        });
//    }

        public void PlayList(string[] resources,float volume, bool loop)
        {
            if (_audio == null)
            {
//            Init();
            }
        
            _resources = resources;
            _loop = loop;
            _audio.volume = volume;
            Invoke(nameof(PlayNextSound), 1);
        }

        public void PlayList(AudioClip[] clips, float volume, bool loop)
        {
        
        }

        public void PlayNext()
        {
            PlayNextSound();
        }

        public void PlayPrev()
        {
            throw new Exception("未实现的函数");
        }

        public void Pause(float delay = -1)
        {
            if (delay > 0)
            {
                Invoke(nameof(PauseVoice), delay);
            }
            else
            {
                _audio.Pause();
            }
        }

        private void PauseVoice()
        {
            _audio.Pause();
        }

        public void Resume()
        {
            _audio.UnPause();
        }
    
        private void PlayNextSound()
        {
            //如果已经播放完毕，且不循环的话，则不再播放
            if (_index == _resources.Length)
            {
                if (!_loop)
                {
                    return;
                }
                else
                {
                    _index = 0;
                }
            }
       
            var clip = Resources.Load<AudioClip>(_resources[_index]);
            _audio.clip = clip;
            _audio.Play();
            _index++;

//            _audio.play

            //上一首歌播放完之后播放下一首
            Invoke(nameof(PlayNextSound), clip.length + 1);
        }
    }
}
