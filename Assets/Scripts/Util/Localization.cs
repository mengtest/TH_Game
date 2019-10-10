using System;
using UnityEngine;
using UnityEngine.UI;

namespace Util
{
    [AddComponentMenu("yuki/Localization")]
    public class Localization : MonoBehaviour
    {
        void Start()
        {
            //对该组件下的所有为text的组件做出多语言处理
            foreach (var child in GetComponentsInChildren<Text>())
            {
                child.text = Singleton.Singleton.Instance.GetLocal().GetWord(child.text);
            }

            //对一些组件做出特殊处理
            var dropDown = GetComponent<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.GetLocal().GetWord(option.text);
                }
            }

            dropDown = GetComponentInChildren<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.GetLocal().GetWord(option.text);
                }
            }
        }

        private void OnEnable()
        {
            //对该组件下的所有为text的组件做出多语言处理
            foreach (var child in GetComponentsInChildren<Text>())
            {
                child.text = Singleton.Singleton.Instance.GetLocal().GetWord(child.text);
            }

            //对一些组件做出特殊处理
            var dropDown = GetComponent<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.GetLocal().GetWord(option.text);
                }
            }

            dropDown = GetComponentInChildren<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.GetLocal().GetWord(option.text);
                }
            }
        }
    }
}
