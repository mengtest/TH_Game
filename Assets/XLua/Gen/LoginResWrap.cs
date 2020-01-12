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
    public class LoginResWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LoginRes);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 4, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clone", _m_Clone);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteTo", _m_WriteTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateSize", _m_CalculateSize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MergeFrom", _m_MergeFrom);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Res", _g_get_Res);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Uid", _g_get_Uid);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Nickname", _g_get_Nickname);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Msg", _g_get_Msg);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Res", _s_set_Res);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Uid", _s_set_Uid);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Nickname", _s_set_Nickname);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Msg", _s_set_Msg);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 2, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ParseFrom", _m_ParseFrom_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ResFieldNumber", LoginRes.ResFieldNumber);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UidFieldNumber", LoginRes.UidFieldNumber);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NicknameFieldNumber", LoginRes.NicknameFieldNumber);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MsgFieldNumber", LoginRes.MsgFieldNumber);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Parser", _g_get_Parser);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Descriptor", _g_get_Descriptor);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					LoginRes gen_ret = new LoginRes();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<LoginRes>(L, 2))
				{
					LoginRes _other = (LoginRes)translator.GetObject(L, 2, typeof(LoginRes));
					
					LoginRes gen_ret = new LoginRes(_other);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to LoginRes constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ParseFrom_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    byte[] _bytes = LuaAPI.lua_tobytes(L, 1);
                    
                        LoginRes gen_ret = LoginRes.ParseFrom( _bytes );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        LoginRes gen_ret = gen_to_be_invoked.Clone(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _other = translator.GetObject(L, 2, typeof(object));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<LoginRes>(L, 2)) 
                {
                    LoginRes _other = (LoginRes)translator.GetObject(L, 2, typeof(LoginRes));
                    
                        bool gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LoginRes.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        string gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WriteTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Google.Protobuf.CodedOutputStream _output = (Google.Protobuf.CodedOutputStream)translator.GetObject(L, 2, typeof(Google.Protobuf.CodedOutputStream));
                    
                    gen_to_be_invoked.WriteTo( _output );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateSize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.CalculateSize(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MergeFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<LoginRes>(L, 2)) 
                {
                    LoginRes _other = (LoginRes)translator.GetObject(L, 2, typeof(LoginRes));
                    
                    gen_to_be_invoked.MergeFrom( _other );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<Google.Protobuf.CodedInputStream>(L, 2)) 
                {
                    Google.Protobuf.CodedInputStream _input = (Google.Protobuf.CodedInputStream)translator.GetObject(L, 2, typeof(Google.Protobuf.CodedInputStream));
                    
                    gen_to_be_invoked.MergeFrom( _input );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LoginRes.MergeFrom!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Parser(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, LoginRes.Parser);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Descriptor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, LoginRes.Descriptor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Res(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Res);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Uid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Uid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Nickname(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Nickname);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Msg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Msg);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Res(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Res = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Uid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Uid = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Nickname(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Nickname = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Msg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                LoginRes gen_to_be_invoked = (LoginRes)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Msg = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
