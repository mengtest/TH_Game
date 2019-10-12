namespace Singleton
{
    public partial class Singleton
    {
        public static string Chinese = "Chinese";
        public static string English = "English";
        public static string DefaultLang = "Chinese";

        public static Singleton Instance => _instance;

        public Language GetLocal()
        {
            return _language;
        }

        //对象的初始化
        public static bool Init()
        {
            _instance = new Singleton {_language = new Language()};
            return true;
        }

        private Singleton()
        {

        }

        private static Singleton _instance;
        private Language _language;
    }
}