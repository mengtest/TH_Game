﻿using UnityEngine;
using UnityEngine.UI;

partial class Global
{
    public static class Translator
    {
        public static void Translate(Component self)
        {
            //对该组件下的所有为text的组件做出多语言处理
            foreach (var child in self.GetComponentsInChildren<Text>())
            {
                child.text = Singleton.Instance.Language.GetWord(child.text);
            }

            //对一些组件做出特殊处理
            var dropDowns = self.GetComponentsInChildren<Dropdown>();
            foreach (var dropDown in dropDowns)
            {
                foreach (var option in dropDown.options)
                {
                    option.text = Singleton.Instance.Language.GetWord(option.text);
                }
            }
        }
    }
}