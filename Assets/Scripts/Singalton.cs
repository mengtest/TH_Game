public partial class Singleton
{
    public static string Chinese = "Chinese";
    public static string English = "English";
    public static string DefaultLang = "Chinese";

    public static Singleton Instance => _instance;

    public Words Language => _words;

    //对象的初始化
    public static void Init()
    {
        _instance = new Singleton {_words = new Words()};
    }

    private Singleton()
    {
        
    }

    private static Singleton _instance;
    private Words _words;
}