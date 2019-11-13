namespace Pool
{
    public interface IPool
    {
        object Create();

        bool Store(object value);

        void Destory(object value);

        object Get();

        object GetUnique();
    }

//    public interface Impl
//    {
//        
//    }

    class Pair<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Pair(TFirst f, TSecond s)
        {
            First = f;
            Second = s;
        }
    }
}