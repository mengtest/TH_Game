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
    public class UtilModelDialogWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Util.ModelDialog);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetText", _m_SetText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetOkText", _m_SetOkText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCancelText", _m_SetCancelText);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowDialog", _m_ShowDialog);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OkBtnCallback", _e_OkBtnCallback);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelBtnCallback", _e_CancelBtnCallback);
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Util.ModelDialog gen_ret = new Util.ModelDialog();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING) && translator.Assignable<Util.ModelDialog.ButtonCallback>(L, 5) && translator.Assignable<Util.ModelDialog.ButtonCallback>(L, 6))
				{
					string _text = LuaAPI.lua_tostring(L, 2);
					string _okText = LuaAPI.lua_tostring(L, 3);
					string _cancelText = LuaAPI.lua_tostring(L, 4);
					Util.ModelDialog.ButtonCallback _okCallback = translator.GetDelegate<Util.ModelDialog.ButtonCallback>(L, 5);
					Util.ModelDialog.ButtonCallback _cancelCallback = translator.GetDelegate<Util.ModelDialog.ButtonCallback>(L, 6);
					
					Util.ModelDialog gen_ret = new Util.ModelDialog(_text, _okText, _cancelText, _okCallback, _cancelCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING) && translator.Assignable<Util.ModelDialog.ButtonCallback>(L, 5))
				{
					string _text = LuaAPI.lua_tostring(L, 2);
					string _okText = LuaAPI.lua_tostring(L, 3);
					string _cancelText = LuaAPI.lua_tostring(L, 4);
					Util.ModelDialog.ButtonCallback _okCallback = translator.GetDelegate<Util.ModelDialog.ButtonCallback>(L, 5);
					
					Util.ModelDialog gen_ret = new Util.ModelDialog(_text, _okText, _cancelText, _okCallback);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING))
				{
					string _text = LuaAPI.lua_tostring(L, 2);
					string _okText = LuaAPI.lua_tostring(L, 3);
					string _cancelText = LuaAPI.lua_tostring(L, 4);
					
					Util.ModelDialog gen_ret = new Util.ModelDialog(_text, _okText, _cancelText);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
				{
					string _text = LuaAPI.lua_tostring(L, 2);
					string _okText = LuaAPI.lua_tostring(L, 3);
					
					Util.ModelDialog gen_ret = new Util.ModelDialog(_text, _okText);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _text = LuaAPI.lua_tostring(L, 2);
					
					Util.ModelDialog gen_ret = new Util.ModelDialog(_text);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Util.ModelDialog constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetText(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.ModelDialog gen_to_be_invoked = (Util.ModelDialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _text = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetText( _text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetOkText(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.ModelDialog gen_to_be_invoked = (Util.ModelDialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _text = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetOkText( _text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCancelText(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.ModelDialog gen_to_be_invoked = (Util.ModelDialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _text = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetCancelText( _text );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowDialog(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Util.ModelDialog gen_to_be_invoked = (Util.ModelDialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ShowDialog(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OkBtnCallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Util.ModelDialog gen_to_be_invoked = (Util.ModelDialog)translator.FastGetCSObj(L, 1);
                Util.ModelDialog.ButtonCallback gen_delegate = translator.GetDelegate<Util.ModelDialog.ButtonCallback>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Util.ModelDialog.ButtonCallback!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.OkBtnCallback += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.OkBtnCallback -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Util.ModelDialog.OkBtnCallback!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_CancelBtnCallback(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			Util.ModelDialog gen_to_be_invoked = (Util.ModelDialog)translator.FastGetCSObj(L, 1);
                Util.ModelDialog.ButtonCallback gen_delegate = translator.GetDelegate<Util.ModelDialog.ButtonCallback>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need Util.ModelDialog.ButtonCallback!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.CancelBtnCallback += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.CancelBtnCallback -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to Util.ModelDialog.CancelBtnCallback!");
            return 0;
        }
        
		
		
    }
}
