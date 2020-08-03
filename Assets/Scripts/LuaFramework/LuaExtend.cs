using System.Runtime.InteropServices;
using XLua;

namespace XLua.LuaDLL
{ 
    public partial class Lua
    {

        #region rapidjson

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_rapidjson(System.IntPtr L);

        [MonoPInvokeCallback(typeof(LuaDLL.lua_CSFunction))]
        public static int LoadRapidJson(System.IntPtr L)
        {
            return luaopen_rapidjson(L);
        }

        #endregion
        

        #region gameplay

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_gameplay(System.IntPtr L);


        [MonoPInvokeCallback(typeof(LuaDLL.lua_CSFunction))]
        public static int LoadGamePlay(System.IntPtr L)
        {
            return luaopen_gameplay(L);
        }

        #endregion
        
        
        #region core

        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_core(System.IntPtr L);

        
        [MonoPInvokeCallback(typeof(LuaDLL.lua_CSFunction))]
        public static int LoadCore(System.IntPtr L)
        {
            return luaopen_core(L);
        }

        #endregion
    }
}