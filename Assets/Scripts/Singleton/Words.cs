using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public partial class Singleton
{
    public class Words
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

        public Words()
        {
            _words = new Dictionary<string, string>();
            CurrentLanguage = DefaultLang;
        }

        //重新加载文件
        private void ReadFile()
        {
            if (_words == null)
            {
                _words = new Dictionary<string, string>();
            }
            TextAsset text = Util.Loader.Load<TextAsset>("Language/" + _currentLanguage);
            var doc = new XmlDocument();
            doc.LoadXml(text.text);
            if (doc.HasChildNodes)
            {
                foreach (XmlNode words in doc.ChildNodes)
                {
                    //读取words与sentences下面所有的节点，其名称即为key，值为value
                    if (words.Name == "words" || words.Name == "sentences")
                    {
                        foreach (XmlNode word in words.ChildNodes)
                        {
                            //如果不存在这个key，则直接新建，
                            //否则修改原来的值
                            //可以在某种语言缺失键的情况下，使用上次使用的语言中的键值
                            if (_words.ContainsKey(word.Name.ToLower()))
                            {
                                _words[word.Name.ToLower()] = word.InnerText;
                            }
                            else
                            {
                                _words.Add(word.Name.ToLower(), word.InnerText);
                            }
                        }
                    }
                }
            }
        }

        //获取到key对应的值，如果没有对应的值，则直接返回小写的key
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
            if (!_words.ContainsKey(key))
            {
                throw new Exception("无效的键");
            }
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
