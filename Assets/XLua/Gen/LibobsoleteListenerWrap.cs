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
    public class LibobsoleteListenerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Lib.obsolete.Listener);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "On", _m_On);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Off", _m_Off);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Event", _m_Event);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OffAll", _m_OffAll);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Init", _m_Init_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KEY_EVENT", Lib.obsolete.Listener.KEY_EVENT);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MOUSE_EVENT", Lib.obsolete.Listener.MOUSE_EVENT);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Lib.obsolete.Listener gen_ret = new Lib.obsolete.Listener();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Lib.obsolete.Listener constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    Lib.obsolete.Listener.Init(  );
                    
                    
                    
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
            
            
                Lib.obsolete.Listener gen_to_be_invoked = (Lib.obsolete.Listener)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Lib.obsolete.Listener.Function>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<object>(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    string _eventName = LuaAPI.lua_tostring(L, 2);
                    Lib.obsolete.Listener.Function _func = translator.GetDelegate<Lib.obsolete.Listener.Function>(L, 3);
                    int _keycode = LuaAPI.xlua_tointeger(L, 4);
                    object _caller = translator.GetObject(L, 5, typeof(object));
                    bool _once = LuaAPI.lua_toboolean(L, 6);
                    
                    gen_to_be_invoked.On( _eventName, _func, _keycode, _caller, _once );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Lib.obsolete.Listener.Function>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _eventName = LuaAPI.lua_tostring(L, 2);
                    Lib.obsolete.Listener.Function _func = translator.GetDelegate<Lib.obsolete.Listener.Function>(L, 3);
                    int _keycode = LuaAPI.xlua_tointeger(L, 4);
                    object _caller = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.On( _eventName, _func, _keycode, _caller );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Lib.obsolete.Listener.Function>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _eventName = LuaAPI.lua_tostring(L, 2);
                    Lib.obsolete.Listener.Function _func = translator.GetDelegate<Lib.obsolete.Listener.Function>(L, 3);
                    int _keycode = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.On( _eventName, _func, _keycode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<Lib.obsolete.Listener.Function>(L, 3)) 
                {
                    string _eventName = LuaAPI.lua_tostring(L, 2);
                    Lib.obsolete.Listener.Function _func = translator.GetDelegate<Lib.obsolete.Listener.Function>(L, 3);
                    
                    gen_to_be_invoked.On( _eventName, _func );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Lib.obsolete.Listener.On!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Off(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Lib.obsolete.Listener gen_to_be_invoked = (Lib.obsolete.Listener)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _caller = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.Off( _caller );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _caller = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Off( _caller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Lib.obsolete.Listener.Off!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Event(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Lib.obsolete.Listener gen_to_be_invoked = (Lib.obsolete.Listener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _eventName = LuaAPI.lua_tostring(L, 2);
                    object[] _objs = translator.GetParams<object>(L, 3);
                    
                    gen_to_be_invoked.Event( _eventName, _objs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OffAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Lib.obsolete.Listener gen_to_be_invoked = (Lib.obsolete.Listener)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OffAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Lib.obsolete.Listener.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
