using XLua;

namespace Game
{
    [LuaCallCSharp]
    [CSharpCallLua]
    public interface ISkill
    {
        string GetName();

        int GetId();

        //执行这个技能
        void Execute();

        //为这个技能绑定目标
        ISkill BindTarget(ICard card);
    }
}