partial class Global
{
    public class Resources
    {
        private static Resources _loader;
        
        public static void Init()
        {
            if (_loader == null)
            {
                _loader = new Resources();
            }
        }

        //保存配置文件，写入文件
        public void SaveConfig()
        {
            //跟文件交互的是config
            //跟内存交互的是tempCOnfig
            //缓存持久化
//            _config = LocalConfig.FromJson(_tempConfig.ToJson());
//            //这里没有考虑到安卓端写入的问题
//            var dir = new DirectoryInfo("Assets/Resources/Config");
//            var fs = new FileStream(dir.FullName + "/Config.json", FileMode.Open, FileAccess.Write);
//            //这里单独使用一格变量存储config转json的结果
//            //如果直接传递config.Json会存储失败（多出来一部分字符）
//            var res = _config.ToJson();
//            var bytes = System.Text.Encoding.Default.GetBytes(res);
//            fs.Write(bytes, 0, bytes.Length);
//            fs.Close();
        }

        private Resources()
        {
            
        }
    }
}