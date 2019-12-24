﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Util;

namespace Prefab
{
    public class LoadingLayerScript : MonoBehaviour
    {
        private Text _text;
        private string _t;
        private int _count = 0;
        private AsyncOperation _async;

        private void Awake()
        {
            _text = GetComponentInChildren<Text>();
        }

        private void Start()
        {
            _t = _text.text;
            Invoke(nameof(Timer), 0.5f);
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
            Invoke(nameof(Timer), 0.5f);
        }

        private IEnumerator LoadScene(string sceneName)
        {
            yield return new WaitForEndOfFrame();
            _async = SceneManager.LoadSceneAsync(sceneName);
            _async.completed += operation =>
            {
                Listener.Instance.Event("scene_changed", null, sceneName);
            };
            yield return _async;
        }
    
        private IEnumerator LoadScene(int sceneId)
        {
            yield return new WaitForEndOfFrame();
            _async = SceneManager.LoadSceneAsync(sceneId);
            _async.completed += (op) =>
            {
                Listener.Instance.Event("scene_changed", null, sceneId);
            };
            yield return _async;
        }
    }
}