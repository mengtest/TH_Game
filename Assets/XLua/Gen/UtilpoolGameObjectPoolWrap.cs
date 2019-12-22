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
    public class UtilpoolGameObjectPoolWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Util.pool.GameObjectPool);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetItem", _m_GetItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddItem", _m_AddItem);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Count", _m_Count);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Destroy", _m_Destroy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreatePool", _m_CreatePool_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Util.pool.GameObjectPool gen_ret = new Util.pool.GameObjectPool();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Util.pool.GameObjectPool constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreatePool_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<Util.pool.GameObjectPool.Creator>(L, 1)&& translator.Assignable<Util.pool.GameObjectPool.Operator>(L, 2)&& translator.Assignable<Util.pool.GameObjectPool.Operator>(L, 3)&& translator.Assignable<Util.pool.GameObjectPool.Operator>(L, 4)) 
                {
                    Util.pool.GameObjectPool.Creator _creator = translator.GetDelegate<Util.pool.GameObjectPool.Creator>(L, 1);
                    Util.pool.GameObjectPool.Operator _deleter = translator.GetDelegate<Util.pool.GameObjectPool.Operator>(L, 2);
                    Util.pool.GameObjectPool.Operator _getter = translator.GetDelegate<Util.pool.GameObjectPool.Operator>(L, 3);
                    Util.pool.GameObjectPool.Operator _setter = translator.GetDelegate<Util.pool.GameObjectPool.Operator>(L, 4);
                    
                        Util.pool.IPool gen_ret = Util.pool.GameObjectPool.CreatePool( _creator, _deleter, _getter, _setter );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<Util.pool.GameObjectPool.Creator>(L, 1)&& translator.Assignable<Util.pool.GameObjectPool.Operator>(L, 2)&& translator.Assignable<Util.pool.GameObjectPool.Operator>(L, 3)) 
                {
                    Util.pool.GameObjectPool.Creator _creator = translator.GetDelegate<Util.pool.GameObjectPool.Creator>(L, 1);
                    Util.pool.GameObjectPool.Operator _deleter = translator.GetDelegate<Util.pool.GameObjectPool.Operator>(L, 2);
                    Util.pool.GameObjectPool.Operator _getter = translator.GetDelegate<Util.pool.GameObjectPool.Operator>(L, 3);
                    
                        Util.pool.IPool gen_ret = Util.pool.GameObjectPool.CreatePool( _creator, _deleter, _getter );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<Util.pool.GameObjectPool.Creator>(L, 1)&& translator.Assignable<Util.pool.GameObjectPool.Operator>(L, 2)) 
                {
                    Util.pool.GameObjectPool.Creator _creator = translator.GetDelegate<Util.pool.GameObjectPool.Creator>(L, 1);
                    Util.pool.GameObjectPool.Operator _deleter = translator.GetDelegate<Util.pool.GameObjectPool.Operator>(L, 2);
                    
                        Util.pool.IPool gen_ret = Util.pool.GameObjectPool.CreatePool( _creator, _deleter );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to Util.pool.GameObjectPool.CreatePool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.pool.GameObjectPool gen_to_be_invoked = (Util.pool.GameObjectPool)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.GameObject gen_ret = gen_to_be_invoked.GetItem(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddItem(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.pool.GameObjectPool gen_to_be_invoked = (Util.pool.GameObjectPool)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _item = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    
                    gen_to_be_invoked.AddItem( _item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Count(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.pool.GameObjectPool gen_to_be_invoked = (Util.pool.GameObjectPool)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.Count(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.pool.GameObjectPool gen_to_be_invoked = (Util.pool.GameObjectPool)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        UnityEngine.GameObject gen_ret = gen_to_be_invoked.Create(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Destroy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.pool.GameObjectPool gen_to_be_invoked = (Util.pool.GameObjectPool)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _go = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    
                    gen_to_be_invoked.Destroy( _go );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.pool.GameObjectPool gen_to_be_invoked = (Util.pool.GameObjectPool)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
