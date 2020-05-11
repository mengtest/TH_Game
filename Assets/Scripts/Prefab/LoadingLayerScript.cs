using System;
using System.Collections;
using Lib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Prefab
{
    /// <summary>
    /// loading场景中用到的组件
    /// </summary>
    public class LoadingLayerScript : MonoBehaviour
    {
        private Text _text;
        private string _t;
        private int _count = 0;
        private AsyncOperation _async;

        private void Awake()
        {
            // Global.CallLoad();
            _text = GetComponentInChildren<Text>();
        }

        private void Start()
        {
            _t = _text.text;
            InvokeRepeating(nameof(Timer), 0.5f, 0.5f);
            if (Global.Cache.GetNextSceneId() != -1)
            {
                StartCoroutine(LoadScene(Global.Cache.GetNextSceneId()));
            }
            else if(Global.Cache.GetNextSceneName().Length != 0)
            {
                StartCoroutine(LoadScene(Global.Cache.GetNextSceneName()));
            }
            else
            {
                throw new Exception("不正确的场景参数");
            }
        }

        private void Timer()
        {
            switch (_count % 4)
            {
                case 0:
                    _text.text = _t + ".";
                    break;
                case 1:
                    _text.text = _t + "..";
                    break;
                case 2:
                    _text.text = _t + "...";
                    break;
                case 3:
                    _text.text = _t;
                    break;
                default:
                    _text.text = _t;
                    break;
            }
            _count++;
        }

        private IEnumerator LoadScene(string sceneName)
        {
            _async = SceneManager.LoadSceneAsync(sceneName);
            _async.allowSceneActivation = false;
            _async.completed += op =>
            {
                Listener.Instance.Event("scene_changed", sceneName);
            };
            while (Global.CountLoad() > 0)
            {
                Global.CallLoad();
                yield return new WaitForEndOfFrame();
            }
            _async.allowSceneActivation = true;
        }
    
        private IEnumerator LoadScene(int sceneId)
        {
            yield return new WaitForEndOfFrame();
            _async = SceneManager.LoadSceneAsync(sceneId);
            _async.allowSceneActivation = false;
            _async.completed += op =>
            {
                Listener.Instance.Event("scene_changed", sceneId);
            };
            while (Global.CountLoad() > 0)
            {
                //在loading场景中就执行这些函数
                // Global.CallLoad();
                yield return new WaitForEndOfFrame();
            }
            _async.allowSceneActivation = true;
        }
    }
}