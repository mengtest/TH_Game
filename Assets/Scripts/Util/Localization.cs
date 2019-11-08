using System;
using UnityEngine;
using UnityEngine.UI;


namespace Util
{
    //现在无法对后续通过代码添加的组件做本地化
    [AddComponentMenu("yuki/Localization")]
    public class Localization : MonoBehaviour
    {
        void Start()
        {
            //对该组件下的所有为text的组件做出多语言处理
            foreach (var child in GetComponentsInChildren<Text>())
            {
                child.text = Singleton.Singleton.Instance.Language.GetWord(child.text);
            }

            //对一些组件做出特殊处理
            var dropDown = GetComponent<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.Language.GetWord(option.text);
                }
            }

            dropDown = GetComponentInChildren<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.Language.GetWord(option.text);
                }
            }
        }

        private void OnEnable()
        {
            //对该组件下的所有为text的组件做出多语言处理
            foreach (var child in GetComponentsInChildren<Text>())
            {
                child.text = Singleton.Singleton.Instance.Language.GetWord(child.text);
            }

            //对一些组件做出特殊处理
            var dropDown = GetComponent<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.Language.GetWord(option.text);
                }
            }

            dropDown = GetComponentInChildren<Dropdown>();
            if (dropDown != null)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Singleton.Instance.Language.GetWord(option.text);
                }
            }
        }
    }
}
