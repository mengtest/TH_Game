using System.Collections.Generic;
using EX;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Manager
{
    public class Sound
    {
        private LinkedList<AudioSource> _audioSources;
        private LinkedList<AudioEx> _audioExes;
        
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
        
        
        public static void PlayBgm(string resourcePath, bool loop = true)
        {
            Play(resourcePath, 0.2f, loop);
        }

        public static void PlayEffect(string resourcePath, bool loop = false)
        {
            Play(resourcePath, 0.5f, loop);
        }

        public static void PlayCharacterVoice(string resourcePath, bool loop = false)
        {
            Play(resourcePath, 0.5f, loop);
        }

        private static void Play(string[] resources,float vol, bool loop)
        {
            var sound = new GameObject("Sound");
            SceneManager.MoveGameObjectToScene(sound.gameObject, SceneManager.GetActiveScene());
            var audioEx = sound.AddComponent<AudioEx>();

            audioEx.PlayList(resources, vol, loop);
        }

        //播放音效
        private static void Play(string soundPath, float vol, bool loop)
        {
            var sound = new GameObject("Sound");
            SceneManager.MoveGameObjectToScene(sound.gameObject, SceneManager.GetActiveScene());
            var audio = sound.AddComponent<AudioSource>();
            var clip = Resources.Load<AudioClip>(soundPath);
            audio.volume = vol;
            audio.loop = loop;
            audio.clip = clip;
            audio.Play();

            //如果是循环播放，则不需要去释放这段内存
            if (!loop)
            {
                Timer.Register(clip.length + 1, () => { Object.Destroy(sound); });
            }
        }

    }
}