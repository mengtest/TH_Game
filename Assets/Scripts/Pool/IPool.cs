namespace Pool
{
    public interface IPool
    {
        object Create();
        
        object Create(int key);

        bool Store(int key, object value);
        
        bool Store(object value);

        void Destory(int key, bool release = false);
        
        void Destory(bool release = false);

        object Get(int key);

        void Get();
    }
}