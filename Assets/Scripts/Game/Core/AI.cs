namespace Game.Core
{
    /// <summary>
    /// AI接口，会在lua端实例化出来
    /// </summary>
    public interface AI
    {
        /// <summary>
        /// 获取到这个AI的id
        /// </summary>
        /// <returns></returns>
        int GetId();

        /// <summary>
        /// 获取当前ai的名称(会随机为ai分配一个名称)
        /// </summary>
        /// <returns></returns>
        string GetName();

        // /// <summary>
        // /// 获取当前ai的所有卡牌
        // /// </summary>
        // /// <returns></returns>
        // int[] GetDeck();

        /// <summary>
        /// ai的初始化，进入战斗场景的时候调用
        /// </summary>
        void Init();

        /// <summary>
        /// 执行一次操作，轮到这个ai的回合时调用
        ///     会在lua端提供一些api来帮助ai运行
        /// </summary>
        void Invoke();

        /// <summary>
        /// 战斗结束后调用这个方法
        /// </summary>
        void Destroy();
    }
}