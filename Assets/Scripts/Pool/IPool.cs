namespace Pool
{
    public interface IPool
    {
        T Create<T>();

        void Store<T>(T t);
    }
}