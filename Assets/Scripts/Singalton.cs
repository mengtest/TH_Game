public partial class Singleton
{
    public const string Chinese = "Chinese";
    public const string English = "English";
    // ReSharper disable once MemberCanBePrivate.Global
    public const string DefaultLang = "Chinese";

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