﻿using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

namespace Singleton
{
    partial class Singleton
    {
        public class Local
        {
            //这个值就是英文，同时也是文件名，会根据这个值去读取不同的文件
            private string _currentLanguage;

            public string CurrentLanguage
            {
                set
                {
                    if (_currentLanguage != value)
                    {
                        _currentLanguage = value;
                        _words.Clear();
                        ReadFile();
                    }
                }
                get => _currentLanguage;
            }

            public Local()
            {
                _words = new Dictionary<string, string>();
                CurrentLanguage = DefaultLang;
            }

            //重新加载文件
            private void ReadFile()
            {
                TextAsset text = Resources.Load<TextAsset>("Language/" + _currentLanguage);
                var doc = new XmlDocument();
                doc.LoadXml(text.text);
                if (doc.HasChildNodes)
                {
                    foreach (XmlNode words in doc.ChildNodes)
                    {
                        if (words.Name == "words")
                        {
                            foreach (XmlNode word in words.ChildNodes)
                            {
                                _words.Add(word["key"]?.InnerText.ToLower() ?? throw new Exception("属性key为空"), 
                                    word["value"]?.InnerText);
                            }
                        }
                    }
                }
            }

            //获取到key对应的值，如果没有对应的值，则返回key
            //convert为是否需要转化成小写
            public string GetWord(string key,bool convert = true)
            {
                if (convert)
                {
                    key = key.ToLower();
                }
                return _words.ContainsKey(key) ? _words[key] : key;
            }

            //获取key对应的值，不会为空
            public string FindWord(string key)
            {
                return _words[key];
            }

            //是否存在key
            public bool HasWord(string key)
            {
                return _words.ContainsKey(key);
            }

            private Dictionary<string, string> _words;
        }
    }
}