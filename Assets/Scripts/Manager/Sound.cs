using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EX;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;
using Object = UnityEngine.Object;

namespace Manager
{
    [LuaCallCSharp]
    public static class Sound
    {
        private static Dictionary<int, AudioEx> _audioExes;
        private static GameObject _soundMgr;
        
        public delegate void SoundPlayCompleteCallback(AudioEx audio);
        
        public static void PlayBgm(string[] resources,bool loop)
        {
            Play(resources, 0.2f, loop);
        }
        
        public static void PlayEffect(string[] resources,bool loop)
        {
            Play(resources, 0.5f, loop);
        }
        
        public static void PlayCharacterVoice(string[] resources,bool loop)
        {
            Play(resources, 0.5f, loop);
        }
        
        
        public static void PlayBgm(string resource, bool loop = true)
        {
            Play(resource, 0.2f, loop);
        }

        public static void PlayEffect(string resource, bool loop = false)
        {
            Play(resource, 0.5f, loop);
        }

        public static void PlayEffect(AudioClip resource, bool loop = false)
        {
            Play(resource, 0.5f, loop);
        }

        public static void PlayCharacterVoice(string resource, bool loop = false)
        {
            Play(resource, 0.5f, loop);
        }

        private static void Play(string[] resources,float vol, bool loop, SoundPlayCompleteCallback callback = null)
        {
            var sound = new GameObject("SoundList");
            SceneManager.MoveGameObjectToScene(sound.gameObject, SceneManager.GetActiveScene());
            var audioEx = sound.AddComponent<AudioEx>();

            audioEx.PlayList(resources, vol, loop);

            //播放列表里头的所有音频文件时，不需要去停止
        }

        //播放音效
        private static void Play(string soundPath, float vol, bool loop, bool destroy = true,  SoundPlayCompleteCallback callback = null)
        {
            var clip = Util.Loader.Load<AudioClip>(soundPath);
            Play(clip, vol, loop, destroy, callback);
        }

        public static void AddSoundManager()
        {
            if (_soundMgr == null)
            {
                _soundMgr = new GameObject("SoundManager");
                SceneManager.MoveGameObjectToScene(_soundMgr, Global.Scene);
                _audioExes = new Dictionary<int, AudioEx>();
            }
        }

        private static void Play(AudioClip clip, float vol, bool loop, bool destroy = true,  SoundPlayCompleteCallback callback = null)
        {
            if (_soundMgr == null)
            {
                AddSoundManager();
            }
            var sound = new GameObject("Sound");
            sound.transform.SetParent(_soundMgr.transform);
            var audio = sound.AddComponent<AudioEx>();
            audio.Audio.volume = vol;
            audio.Audio.loop = loop;
            audio.Audio.clip = clip;
            audio.Audio.Play();
            // var code = audio.GetHashCode();
            // if (!_audioExes.ContainsKey(code))
            // {
            //     _audioExes.Add(audio.GetHashCode(), audio);    
            // }
            // else
            // {
            //     Object.Destroy(_audioExes[code]);
            //     _audioExes[code] = audio;
            // }

            //如果是循环播放，则不需要去释放这段内存
            if (!loop)
            {

                Timer.Register(clip.length, () =>
                {
                    if (destroy)
                    {
                        Object.Destroy(sound);
                        // _audioExes.Remove(code);
                    }
                    else
                    {
                        callback?.Invoke(audio);
                        // _audioExes.Remove(code);
                    }
                });
            }
        }
    }
}