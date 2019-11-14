using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Prefab
{
    public class LoadingLayerScript : MonoBehaviour
    {
        private Text _text;
        private string _t;
        private int count = 0;
        
        private void Start()
        {
            _text = GetComponentInChildren<Text>();
            _t = _text.text;

            foreach (var child in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                if (child.GetComponent<Camera>() == null && child.name != "TimerManager")
                {
                    child.SetActive(false);
                }
            }

            gameObject.SetActive(true);
            
            Invoke(nameof(Timer), 0.5f);
        }

        private void Timer()
        {
            switch (count % 4)
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

            count++;
            Invoke(nameof(Timer), 0.5f);
        }

//        public void LoadResources(string[] resources, Action<Object[]> callback)
//        {
//            int index = 0;
//            foreach (var resource in resources)
//            {
//                var res = Resources.LoadAsync(resource);
//                res.completed += operation =>
//                {
//                    index++;
//                    if (index == resources.Length)
//                    {
//                        
//                    }
//                };
//            }
//            StartCoroutine(nameof(LoadResources));
//        }
//
//        public void LoadResources(string resources)
//        {
//            
//        }
    }
}