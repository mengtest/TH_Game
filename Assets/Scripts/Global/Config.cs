using System.Collections.Generic;
using System.IO;

namespace Global
{
    //这个类并不是单例类，原因是，只有在选择语言的地方才会需要用到这个类
    //所以在需要的时候去创建一个对象就好了，并不需要一直浪费内存作为一个单例
    public class Config
    {
        //就是创建一个config对象
        public static Config Load()
        {
            return new Config();
        }

        public List<string> Language => _languages;

        //在构造这个对象的时候，完成配置文件的读取，这里会读取语言文件夹下面所有的文件
        private Config()
        {
            //获取到这个目录下所有的文件
            var dir = new DirectoryInfo("Assets/Resources/Language");
            var files = dir.GetFiles("*.xml");
            //这里直接根据language文件夹下面的文件映射到对应的语言
            foreach (var file in files)
            {
                //去掉扩展名
                _languages.Add(file.Name.Replace(file.Extension, ""));
            }
        }

        private List<string> _languages = new List<string>();
    }
}