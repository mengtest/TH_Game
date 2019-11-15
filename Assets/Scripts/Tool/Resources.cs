using System.IO;
using Entity.Card.Extend;
using Entity.Chapters;
using Entity.Config;
using Entity.Save;
using UnityEngine;

partial class Global
{
    public class Resources
    {
        private static Resources _loader;
        private Save _save;
        private Cards _cards;
        //真正的配置信息
        private LocalConfig _config;
        //临时的配置信息，充当缓存的作用
        private LocalConfig _tempConfig;
        //所有的章节信息，可能还会有扩展
        private Chapters _chapters;
        public LocalConfig Config => _tempConfig;
        public Save Save => _save;
        public Cards Cards => _cards;
        public Chapters Chapters => _chapters;
        public static Resources Instance => _loader;
        public static void Init()
        {
            if (_loader == null)
            {
                _loader = new Resources();
                _loader.ResourcesInit();
            }
        }

        private bool ResourcesInit()
        {
            //存档资源的初始化
            _save = Save.FromJson(UnityEngine.Resources.Load<TextAsset>("Json/Saves").text);
            //卡片资源初始化
            _cards = Cards.CreateCard();
            //读取配置文件
            var res = UnityEngine.Resources.Load<TextAsset>("Config/Config").text;
            _config = LocalConfig.FromJson(res);
            _tempConfig = LocalConfig.FromJson(res);
            //章节信息的初始化
            _chapters = Chapters.FromJson(UnityEngine.Resources.Load<TextAsset>("Json/Chapters").text);
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
            _tempConfig = LocalConfig.FromJson(UnityEngine.Resources.Load<TextAsset>("Config/DefaultConfig").text);
        }

        private Resources()
        {

        }
    }
}