using System.Collections.Generic;
using System.IO;
using Game.Entity.Card.Extend;
using Game.Entity.Chapters;
using Game.Entity.Config;
using Game.Entity.Save;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Global
{
    //资源管理器
    public class ResourceManager
    {
        private static ResourceManager _loader;
        private Save _save;
        private Cards _cards;
        //真正的配置信息
        private LocalConfig _config;
        //临时的配置信息，充当缓存的作用
        private LocalConfig _tempConfig;
        //所有的章节信息，可能还会有扩展
        private Chapters _chapters;
        private Dictionary<string, Object> _resourcesMap;
        public LocalConfig Config => _tempConfig;
        public Save Save => _save;
        public Cards Cards => _cards;
        
        public Chapters Chapters => _chapters;

        public static ResourceManager Instance => _loader;

        public static bool Init()
        {
            if (_loader == null)
            {
                _loader = new ResourceManager();
                _loader.ResourcesInit();
                return true;
            }
            return false;
        }

        //清除缓存
        public void ClearCache()
        {
            _resourcesMap.Clear();
        }

        //加载资源
        public void Load(string[] resources)
        {
            foreach (var res in resources)
            {
                _resourcesMap.Add(res, Resources.Load(res));
            }
        }

        //加载资源
        public void Load(string resource)
        {
            _resourcesMap.Add(resource, Resources.Load(resource));
        }

        //获取资源，取得之后会删除
        public Object Require(string resource)
        {
            Object ins = null;
            if (_resourcesMap.ContainsKey(resource))
            {
                ins = _resourcesMap[resource];
                _resourcesMap.Remove(resource);
            }
            return ins;
        }
        
        //获取资源，取得之后会删除
        public T Require<T>(string resource) where T : Object
        {
            T ins = default(T);
            if (_resourcesMap.ContainsKey(resource))
            {
                ins = _resourcesMap[resource] as T;
                _resourcesMap.Remove(resource);
            }
            return ins;
        }
        
        //获取资源，取得之后会删除
        public Object[] Require(string[] resources)
        {
            Object[] ins = new Object[resources.Length];
            for (int index = 0; index < ins.Length; index++)
            {
                if (_resourcesMap.ContainsKey(resources[index]))
                {
                    ins[index] = _resourcesMap[resources[index]];
                    _resourcesMap.Remove(resources[index]);
                }
                else
                {
                    ins[index] = null;
                }
            }
            return ins;
        }

        private bool ResourcesInit()
        {
            //存档资源的初始化
            _save = Save.FromJson(Resources.Load<TextAsset>("Json/Save").text);
            //卡片资源初始化
            //_cards = Cards.FromJson(Resources.Load<TextAsset>("Json/Cards").text);
            _cards = Cards.CreateCard();
            //读取配置文件
            var res = Resources.Load<TextAsset>("Config/Config").text;
            _config = LocalConfig.FromJson(res);
            _tempConfig = LocalConfig.FromJson(res);
            //章节信息的初始化
            _chapters = Chapters.FromJson(Resources.Load<TextAsset>("Json/chapters").text);
            //用于存储临时的资源，在loading场景中去加载，所有资源加载完成之后
            _resourcesMap = new Dictionary<string, Object>();
            
            return true;
        }

        //建立新存档
        public void NewSave()
        {

        }

        //保存存档
        public void SaveSave()
        {

        }

        //修改存档
        public void ModifySave()
        {

        }

        //删除存档
        public void DeleteSave()
        {

        }

        //保存配置文件，写入文件
        public void SaveConfig()
        {
            //跟文件交互的是config
            //跟内存交互的是tempCOnfig
            //缓存持久化
            _config = LocalConfig.FromJson(_tempConfig.ToJson());
            //这里没有考虑到安卓端写入的问题
            var dir = new DirectoryInfo("Assets/Resources/Config");
            var fs = new FileStream(dir.FullName + "/Config.json", FileMode.Open, FileAccess.Write);
            //这里单独使用一格变量存储config转json的结果
            //如果直接传递config.Json会存储失败（多出来一部分字符）
            var res = _config.ToJson();
            var bytes = System.Text.Encoding.Default.GetBytes(res);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        //应用配置信息
        public void ApplyConfig()
        {
            //主要就是将临时的配置文件信息应用到真正的配置文件中

        }

        //修改配置文件，但是不做保存
        public void ModifyConfig()
        {
            
        }

        //还原配置，用于修改了配置项，但是没有保存的情况
        public void RecoverConfig()
        {

        }

        //恢复默认配置
        public void ResetConfig()
        {
            //读取默认的配置文件
            _tempConfig = LocalConfig.FromJson(Resources.Load<TextAsset>("Config/DefaultConfig").text);
        }

        private ResourceManager()
        {

        }
    }
}