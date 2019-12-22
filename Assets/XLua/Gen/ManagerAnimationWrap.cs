#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class ManagerAnimationWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Manager.Animation);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Play", _m_Play_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PauseTo", _m_PauseTo_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Stop", _m_Stop_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Continue", _m_Continue_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Manager.Animation does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<string[]>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Action>(L, 5)) 
                {
                    string[] _paths = (string[])translator.GetObject(L, 1, typeof(string[]));
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 3);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 4);
                    System.Action _callback = translator.GetDelegate<System.Action>(L, 5);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _paths, _interval, out _id, _loop, _delay, _callback );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& translator.Assignable<string[]>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string[] _paths = (string[])translator.GetObject(L, 1, typeof(string[]));
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 3);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _paths, _interval, out _id, _loop, _delay );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 3&& translator.Assignable<string[]>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string[] _paths = (string[])translator.GetObject(L, 1, typeof(string[]));
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _paths, _interval, out _id, _loop );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& translator.Assignable<string[]>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string[] _paths = (string[])translator.GetObject(L, 1, typeof(string[]));
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _paths, _interval, out _id );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Action>(L, 5)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 3);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 4);
                    System.Action _callback = translator.GetDelegate<System.Action>(L, 5);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, out _id, _loop, _delay, _callback );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 3);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, out _id, _loop, _delay );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 3);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, out _id, _loop );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _id;
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, out _id );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<System.Action>(L, 7)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _start = LuaAPI.xlua_tointeger(L, 3);
                    int _end = LuaAPI.xlua_tointeger(L, 4);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 5);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    System.Action _callback = translator.GetDelegate<System.Action>(L, 7);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, _start, _end, out _id, _loop, _delay, _callback );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _start = LuaAPI.xlua_tointeger(L, 3);
                    int _end = LuaAPI.xlua_tointeger(L, 4);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 5);
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, _start, _end, out _id, _loop, _delay );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _start = LuaAPI.xlua_tointeger(L, 3);
                    int _end = LuaAPI.xlua_tointeger(L, 4);
                    int _id;
                    int _loop = LuaAPI.xlua_tointeger(L, 5);
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, _start, _end, out _id, _loop );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    float _interval = (float)LuaAPI.lua_tonumber(L, 2);
                    int _start = LuaAPI.xlua_tointeger(L, 3);
                    int _end = LuaAPI.xlua_tointeger(L, 4);
                    int _id;
                    
                        UnityEngine.GameObject gen_ret = Manager.Animation.Play( _path, _interval, _start, _end, out _id );
                        translator.Push(L, gen_ret);
                    LuaAPI.xlua_pushinteger(L, _id);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Manager.Animation.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PauseTo_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    Manager.Animation.PauseTo( _id, _index );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    
                    Manager.Animation.PauseTo( _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Manager.Animation.PauseTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Stop_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    
                    Manager.Animation.Stop( _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Continue_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    
                    Manager.Animation.Continue( _id );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
