using UnityEngine;
using XLua;

namespace Local
{
    [LuaCallCSharp]
    class Settings : Singleton<Settings>
    {
        //当前正在起效果的文件
        private QuickType.Json _used;
        //临时缓存，用于存储与取消相关的操作
        private QuickType.Json _temp;

        public QuickType.Json UserConfig
        {
            get => _used;
        }

        public QuickType.Json DefaultConfig
        {
            get => _temp;
        }

        private Settings()
        {
            
        }

        //加载默认的设置
        public void LoadDefault()
        {
            _used = QuickType.Json.FromJson(Util.Loader.Read("/Config/DefaultConfig"));
        }

        public Settings UseUserConfig()
        {
            return this;
        }

        public Settings UseDefaultConfig()
        {
            return this;
        }

        ///加载当前用户保存的设置
        public void Load()
        {
            _used = QuickType.Json.FromJson(Util.Loader.Read("/Config/Config"));
        }

        public void Apply()
        {
            Screen.SetResolution(_used.VideoConfig.Width, _used.VideoConfig.Height, _used.VideoConfig.FullScreen);
        }
    }
}