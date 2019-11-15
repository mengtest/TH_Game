using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
            StartCoroutine(LoadScene("Scenes/MainScene"));
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
            yield return _async;
        }
    
        private IEnumerator LoadScene(int sceneId)
        {
            yield return new WaitForEndOfFrame();
            _async = SceneManager.LoadSceneAsync(sceneId);
            yield return _async;
        }
    }
}