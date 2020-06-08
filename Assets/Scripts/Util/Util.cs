using System;
public abstract class Singleton<T> where T : class
{
    private static readonly object _lock = new object();

    public static T Instance 
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }
            return _instance;
        }
    }

    protected static T _instance;
}