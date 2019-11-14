namespace Pool
{
    public interface IPool
    {
        //创建一个对象，创建失败会返回空
        object Create();

        //存储一个对象，返回时候存储成功
        bool Store(object value);

        //将一个对象标记为未使用
        void Destory(object value);

        //获取一个没有被使用的对象
        object Get();

        //获取一个独占的对象(目标对象会从池子中删除)
        object GetUnique();

        //获取当前池子的容量
        int Size();

        //自动修改大小，可以变大，也可以变小，返回池子的大小
        int AutoResize();

        //扩大池子的大小，返回是否成功扩容
        bool Expand(int size);
    }

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