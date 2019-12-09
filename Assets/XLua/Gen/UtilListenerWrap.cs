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
    public class UtilListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Util.Listener);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Register", _m_Register);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Call", _m_Call);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Inject", _m_Inject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "On", _m_On);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Event", _m_Event);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Off", _m_Off);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Init", _m_Init_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Util.Listener does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    Util.Listener.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Register(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.Listener gen_to_be_invoked = (Util.Listener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _code = LuaAPI.xlua_tointeger(L, 2);
                    Util.Listener.AsyncCall _action = translator.GetDelegate<Util.Listener.AsyncCall>(L, 3);
                    
                    gen_to_be_invoked.Register( _code, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Call(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.Listener gen_to_be_invoked = (Util.Listener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _code = LuaAPI.xlua_tointeger(L, 2);
                    object _o1 = translator.GetObject(L, 3, typeof(object));
                    object _o2 = translator.GetObject(L, 4, typeof(object));
                    object _o3 = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.Call( _code, _o1, _o2, _o3 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Inject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.Listener gen_to_be_invoked = (Util.Listener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _signal = LuaAPI.lua_tostring(L, 2);
                    Util.Listener.Callback _callback = translator.GetDelegate<Util.Listener.Callback>(L, 3);
                    
                    gen_to_be_invoked.Inject( _signal, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_On(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.Listener gen_to_be_invoked = (Util.Listener)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Util.Listener.AsyncCall>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    Util.Listener.AsyncCall _call = translator.GetDelegate<Util.Listener.AsyncCall>(L, 3);
                    int _signal = LuaAPI.xlua_tointeger(L, 4);
                    bool _once = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.On( _type, _call, _signal, _once );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Util.Listener.AsyncCall>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    Util.Listener.AsyncCall _call = translator.GetDelegate<Util.Listener.AsyncCall>(L, 3);
                    int _signal = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.On( _type, _call, _signal );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Util.Listener.AsyncCall>(L, 3)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    Util.Listener.AsyncCall _call = translator.GetDelegate<Util.Listener.AsyncCall>(L, 3);
                    
                    gen_to_be_invoked.On( _type, _call );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Lib.KeyCode>(L, 3)&& translator.Assignable<Util.Listener.Callback>(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string _signal = LuaAPI.lua_tostring(L, 2);
                    Lib.KeyCode _code;translator.Get(L, 3, out _code);
                    Util.Listener.Callback _callback = translator.GetDelegate<Util.Listener.Callback>(L, 4);
                    bool _once = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.On( _signal, _code, _callback, _once );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Lib.KeyCode>(L, 3)&& translator.Assignable<Util.Listener.Callback>(L, 4)) 
                {
                    string _signal = LuaAPI.lua_tostring(L, 2);
                    Lib.KeyCode _code;translator.Get(L, 3, out _code);
                    Util.Listener.Callback _callback = translator.GetDelegate<Util.Listener.Callback>(L, 4);
                    
                    gen_to_be_invoked.On( _signal, _code, _callback );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<Util.Listener.Predicate>(L, 2)&& translator.Assignable<Util.Listener.Callback>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    Util.Listener.Predicate _predicate = translator.GetDelegate<Util.Listener.Predicate>(L, 2);
                    Util.Listener.Callback _callback = translator.GetDelegate<Util.Listener.Callback>(L, 3);
                    string _signal = LuaAPI.lua_tostring(L, 4);
                    bool _once = LuaAPI.lua_toboolean(L, 5);
                    
                    gen_to_be_invoked.On( _predicate, _callback, _signal, _once );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<Util.Listener.Predicate>(L, 2)&& translator.Assignable<Util.Listener.Callback>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    Util.Listener.Predicate _predicate = translator.GetDelegate<Util.Listener.Predicate>(L, 2);
                    Util.Listener.Callback _callback = translator.GetDelegate<Util.Listener.Callback>(L, 3);
                    string _signal = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.On( _predicate, _callback, _signal );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Util.Listener.On!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Event(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.Listener gen_to_be_invoked = (Util.Listener)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<object>(L, 4)&& translator.Assignable<object>(L, 5)&& translator.Assignable<object>(L, 6)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    int _signal = LuaAPI.xlua_tointeger(L, 3);
                    object _o1 = translator.GetObject(L, 4, typeof(object));
                    object _o2 = translator.GetObject(L, 5, typeof(object));
                    object _o3 = translator.GetObject(L, 6, typeof(object));
                    
                    gen_to_be_invoked.Event( _type, _signal, _o1, _o2, _o3 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<object>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    int _signal = LuaAPI.xlua_tointeger(L, 3);
                    object _o1 = translator.GetObject(L, 4, typeof(object));
                    object _o2 = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.Event( _type, _signal, _o1, _o2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    int _signal = LuaAPI.xlua_tointeger(L, 3);
                    object _o1 = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.Event( _type, _signal, _o1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    int _signal = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Event( _type, _signal );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Event( _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Util.Listener.Event!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Off(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.Listener gen_to_be_invoked = (Util.Listener)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    int _signal = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Off( _type, _signal );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Off( _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Util.Listener.Off!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Util.Listener.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
