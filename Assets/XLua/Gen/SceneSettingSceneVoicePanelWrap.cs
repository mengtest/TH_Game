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
    public class SceneSettingSceneVoicePanelWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Scene.SettingScene.VoicePanel);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddCheckerChangeEvent", _m_AddCheckerChangeEvent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSliderChangeEvent", _m_AddSliderChangeEvent);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "voice", _g_get_voice);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "slider", _g_get_slider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "checker", _g_get_checker);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "voice", _s_set_voice);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "slider", _s_set_slider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "checker", _s_set_checker);
            
			
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
					
					Scene.SettingScene.VoicePanel gen_ret = new Scene.SettingScene.VoicePanel();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Scene.SettingScene.VoicePanel constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddCheckerChangeEvent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Events.UnityAction<bool> _act = translator.GetDelegate<UnityEngine.Events.UnityAction<bool>>(L, 2);
                    
                    gen_to_be_invoked.AddCheckerChangeEvent( _act );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSliderChangeEvent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Events.UnityAction<float> _act = translator.GetDelegate<UnityEngine.Events.UnityAction<float>>(L, 2);
                    
                    gen_to_be_invoked.AddSliderChangeEvent( _act );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_voice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.voice);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_slider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.slider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_checker(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.checker);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_voice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.voice = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_slider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.slider = (UnityEngine.UI.Slider)translator.GetObject(L, 2, typeof(UnityEngine.UI.Slider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_checker(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Scene.SettingScene.VoicePanel gen_to_be_invoked = (Scene.SettingScene.VoicePanel)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.checker = (UnityEngine.UI.Toggle)translator.GetObject(L, 2, typeof(UnityEngine.UI.Toggle));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
