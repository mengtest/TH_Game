namespace LuaEngine
{
    public enum ComponentType
    {
        Button,
    }

    public interface ILuaSupporter
    {
        ComponentType GetEnumType();

        void SetType(ComponentType type);

        string GetWord();

        void SetWord(string word);
    }
}