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
    
    public class TutorialTestEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.TestEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.TestEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.TestEnum), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E1", Tutorial.TestEnum.E1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E2", Tutorial.TestEnum.E2);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.TestEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialTestEnum(L, (Tutorial.TestEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "E1"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E2"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.TestEnum!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.TestEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class LibKeyCodeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Lib.KeyCode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Lib.KeyCode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Lib.KeyCode), L, null, 328, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", Lib.KeyCode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Backspace", Lib.KeyCode.Backspace);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tab", Lib.KeyCode.Tab);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Clear", Lib.KeyCode.Clear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Return", Lib.KeyCode.Return);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pause", Lib.KeyCode.Pause);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Escape", Lib.KeyCode.Escape);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Space", Lib.KeyCode.Space);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Exclaim", Lib.KeyCode.Exclaim);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DoubleQuote", Lib.KeyCode.DoubleQuote);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hash", Lib.KeyCode.Hash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dollar", Lib.KeyCode.Dollar);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Percent", Lib.KeyCode.Percent);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ampersand", Lib.KeyCode.Ampersand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Quote", Lib.KeyCode.Quote);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftParen", Lib.KeyCode.LeftParen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightParen", Lib.KeyCode.RightParen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Asterisk", Lib.KeyCode.Asterisk);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Plus", Lib.KeyCode.Plus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Comma", Lib.KeyCode.Comma);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Minus", Lib.KeyCode.Minus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Period", Lib.KeyCode.Period);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Slash", Lib.KeyCode.Slash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha0", Lib.KeyCode.Alpha0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha1", Lib.KeyCode.Alpha1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha2", Lib.KeyCode.Alpha2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha3", Lib.KeyCode.Alpha3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha4", Lib.KeyCode.Alpha4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha5", Lib.KeyCode.Alpha5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha6", Lib.KeyCode.Alpha6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha7", Lib.KeyCode.Alpha7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha8", Lib.KeyCode.Alpha8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Alpha9", Lib.KeyCode.Alpha9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Colon", Lib.KeyCode.Colon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Semicolon", Lib.KeyCode.Semicolon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Less", Lib.KeyCode.Less);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Equals", Lib.KeyCode.Equals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Greater", Lib.KeyCode.Greater);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Question", Lib.KeyCode.Question);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "At", Lib.KeyCode.At);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftBracket", Lib.KeyCode.LeftBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Backslash", Lib.KeyCode.Backslash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightBracket", Lib.KeyCode.RightBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Caret", Lib.KeyCode.Caret);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Underscore", Lib.KeyCode.Underscore);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackQuote", Lib.KeyCode.BackQuote);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "A", Lib.KeyCode.A);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "B", Lib.KeyCode.B);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "C", Lib.KeyCode.C);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "D", Lib.KeyCode.D);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E", Lib.KeyCode.E);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F", Lib.KeyCode.F);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "G", Lib.KeyCode.G);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "H", Lib.KeyCode.H);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "I", Lib.KeyCode.I);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "J", Lib.KeyCode.J);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "K", Lib.KeyCode.K);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "L", Lib.KeyCode.L);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "M", Lib.KeyCode.M);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "N", Lib.KeyCode.N);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "O", Lib.KeyCode.O);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "P", Lib.KeyCode.P);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Q", Lib.KeyCode.Q);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "R", Lib.KeyCode.R);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "S", Lib.KeyCode.S);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "T", Lib.KeyCode.T);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "U", Lib.KeyCode.U);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "V", Lib.KeyCode.V);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "W", Lib.KeyCode.W);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", Lib.KeyCode.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", Lib.KeyCode.Y);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Z", Lib.KeyCode.Z);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftCurlyBracket", Lib.KeyCode.LeftCurlyBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Pipe", Lib.KeyCode.Pipe);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightCurlyBracket", Lib.KeyCode.RightCurlyBracket);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tilde", Lib.KeyCode.Tilde);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Delete", Lib.KeyCode.Delete);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad0", Lib.KeyCode.Keypad0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad1", Lib.KeyCode.Keypad1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad2", Lib.KeyCode.Keypad2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad3", Lib.KeyCode.Keypad3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad4", Lib.KeyCode.Keypad4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad5", Lib.KeyCode.Keypad5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad6", Lib.KeyCode.Keypad6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad7", Lib.KeyCode.Keypad7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad8", Lib.KeyCode.Keypad8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Keypad9", Lib.KeyCode.Keypad9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadPeriod", Lib.KeyCode.KeypadPeriod);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadDivide", Lib.KeyCode.KeypadDivide);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadMultiply", Lib.KeyCode.KeypadMultiply);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadMinus", Lib.KeyCode.KeypadMinus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadPlus", Lib.KeyCode.KeypadPlus);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadEnter", Lib.KeyCode.KeypadEnter);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "KeypadEquals", Lib.KeyCode.KeypadEquals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UpArrow", Lib.KeyCode.UpArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DownArrow", Lib.KeyCode.DownArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightArrow", Lib.KeyCode.RightArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftArrow", Lib.KeyCode.LeftArrow);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Insert", Lib.KeyCode.Insert);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Home", Lib.KeyCode.Home);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "End", Lib.KeyCode.End);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PageUp", Lib.KeyCode.PageUp);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PageDown", Lib.KeyCode.PageDown);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F1", Lib.KeyCode.F1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F2", Lib.KeyCode.F2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F3", Lib.KeyCode.F3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F4", Lib.KeyCode.F4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F5", Lib.KeyCode.F5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F6", Lib.KeyCode.F6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F7", Lib.KeyCode.F7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F8", Lib.KeyCode.F8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F9", Lib.KeyCode.F9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F10", Lib.KeyCode.F10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F11", Lib.KeyCode.F11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F12", Lib.KeyCode.F12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F13", Lib.KeyCode.F13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F14", Lib.KeyCode.F14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "F15", Lib.KeyCode.F15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Numlock", Lib.KeyCode.Numlock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CapsLock", Lib.KeyCode.CapsLock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ScrollLock", Lib.KeyCode.ScrollLock);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightShift", Lib.KeyCode.RightShift);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftShift", Lib.KeyCode.LeftShift);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightControl", Lib.KeyCode.RightControl);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftControl", Lib.KeyCode.LeftControl);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightAlt", Lib.KeyCode.RightAlt);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftAlt", Lib.KeyCode.LeftAlt);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightApple", Lib.KeyCode.RightApple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightCommand", Lib.KeyCode.RightCommand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftApple", Lib.KeyCode.LeftApple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftCommand", Lib.KeyCode.LeftCommand);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftWindows", Lib.KeyCode.LeftWindows);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightWindows", Lib.KeyCode.RightWindows);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AltGr", Lib.KeyCode.AltGr);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Help", Lib.KeyCode.Help);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Print", Lib.KeyCode.Print);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SysReq", Lib.KeyCode.SysReq);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Break", Lib.KeyCode.Break);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Menu", Lib.KeyCode.Menu);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse0", Lib.KeyCode.Mouse0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse1", Lib.KeyCode.Mouse1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse2", Lib.KeyCode.Mouse2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse3", Lib.KeyCode.Mouse3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse4", Lib.KeyCode.Mouse4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse5", Lib.KeyCode.Mouse5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mouse6", Lib.KeyCode.Mouse6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton0", Lib.KeyCode.JoystickButton0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton1", Lib.KeyCode.JoystickButton1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton2", Lib.KeyCode.JoystickButton2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton3", Lib.KeyCode.JoystickButton3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton4", Lib.KeyCode.JoystickButton4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton5", Lib.KeyCode.JoystickButton5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton6", Lib.KeyCode.JoystickButton6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton7", Lib.KeyCode.JoystickButton7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton8", Lib.KeyCode.JoystickButton8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton9", Lib.KeyCode.JoystickButton9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton10", Lib.KeyCode.JoystickButton10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton11", Lib.KeyCode.JoystickButton11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton12", Lib.KeyCode.JoystickButton12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton13", Lib.KeyCode.JoystickButton13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton14", Lib.KeyCode.JoystickButton14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton15", Lib.KeyCode.JoystickButton15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton16", Lib.KeyCode.JoystickButton16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton17", Lib.KeyCode.JoystickButton17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton18", Lib.KeyCode.JoystickButton18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "JoystickButton19", Lib.KeyCode.JoystickButton19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button0", Lib.KeyCode.Joystick1Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button1", Lib.KeyCode.Joystick1Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button2", Lib.KeyCode.Joystick1Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button3", Lib.KeyCode.Joystick1Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button4", Lib.KeyCode.Joystick1Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button5", Lib.KeyCode.Joystick1Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button6", Lib.KeyCode.Joystick1Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button7", Lib.KeyCode.Joystick1Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button8", Lib.KeyCode.Joystick1Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button9", Lib.KeyCode.Joystick1Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button10", Lib.KeyCode.Joystick1Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button11", Lib.KeyCode.Joystick1Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button12", Lib.KeyCode.Joystick1Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button13", Lib.KeyCode.Joystick1Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button14", Lib.KeyCode.Joystick1Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button15", Lib.KeyCode.Joystick1Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button16", Lib.KeyCode.Joystick1Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button17", Lib.KeyCode.Joystick1Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button18", Lib.KeyCode.Joystick1Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick1Button19", Lib.KeyCode.Joystick1Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button0", Lib.KeyCode.Joystick2Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button1", Lib.KeyCode.Joystick2Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button2", Lib.KeyCode.Joystick2Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button3", Lib.KeyCode.Joystick2Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button4", Lib.KeyCode.Joystick2Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button5", Lib.KeyCode.Joystick2Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button6", Lib.KeyCode.Joystick2Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button7", Lib.KeyCode.Joystick2Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button8", Lib.KeyCode.Joystick2Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button9", Lib.KeyCode.Joystick2Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button10", Lib.KeyCode.Joystick2Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button11", Lib.KeyCode.Joystick2Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button12", Lib.KeyCode.Joystick2Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button13", Lib.KeyCode.Joystick2Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button14", Lib.KeyCode.Joystick2Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button15", Lib.KeyCode.Joystick2Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button16", Lib.KeyCode.Joystick2Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button17", Lib.KeyCode.Joystick2Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button18", Lib.KeyCode.Joystick2Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick2Button19", Lib.KeyCode.Joystick2Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button0", Lib.KeyCode.Joystick3Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button1", Lib.KeyCode.Joystick3Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button2", Lib.KeyCode.Joystick3Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button3", Lib.KeyCode.Joystick3Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button4", Lib.KeyCode.Joystick3Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button5", Lib.KeyCode.Joystick3Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button6", Lib.KeyCode.Joystick3Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button7", Lib.KeyCode.Joystick3Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button8", Lib.KeyCode.Joystick3Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button9", Lib.KeyCode.Joystick3Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button10", Lib.KeyCode.Joystick3Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button11", Lib.KeyCode.Joystick3Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button12", Lib.KeyCode.Joystick3Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button13", Lib.KeyCode.Joystick3Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button14", Lib.KeyCode.Joystick3Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button15", Lib.KeyCode.Joystick3Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button16", Lib.KeyCode.Joystick3Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button17", Lib.KeyCode.Joystick3Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button18", Lib.KeyCode.Joystick3Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick3Button19", Lib.KeyCode.Joystick3Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button0", Lib.KeyCode.Joystick4Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button1", Lib.KeyCode.Joystick4Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button2", Lib.KeyCode.Joystick4Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button3", Lib.KeyCode.Joystick4Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button4", Lib.KeyCode.Joystick4Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button5", Lib.KeyCode.Joystick4Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button6", Lib.KeyCode.Joystick4Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button7", Lib.KeyCode.Joystick4Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button8", Lib.KeyCode.Joystick4Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button9", Lib.KeyCode.Joystick4Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button10", Lib.KeyCode.Joystick4Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button11", Lib.KeyCode.Joystick4Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button12", Lib.KeyCode.Joystick4Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button13", Lib.KeyCode.Joystick4Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button14", Lib.KeyCode.Joystick4Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button15", Lib.KeyCode.Joystick4Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button16", Lib.KeyCode.Joystick4Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button17", Lib.KeyCode.Joystick4Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button18", Lib.KeyCode.Joystick4Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick4Button19", Lib.KeyCode.Joystick4Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button0", Lib.KeyCode.Joystick5Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button1", Lib.KeyCode.Joystick5Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button2", Lib.KeyCode.Joystick5Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button3", Lib.KeyCode.Joystick5Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button4", Lib.KeyCode.Joystick5Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button5", Lib.KeyCode.Joystick5Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button6", Lib.KeyCode.Joystick5Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button7", Lib.KeyCode.Joystick5Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button8", Lib.KeyCode.Joystick5Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button9", Lib.KeyCode.Joystick5Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button10", Lib.KeyCode.Joystick5Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button11", Lib.KeyCode.Joystick5Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button12", Lib.KeyCode.Joystick5Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button13", Lib.KeyCode.Joystick5Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button14", Lib.KeyCode.Joystick5Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button15", Lib.KeyCode.Joystick5Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button16", Lib.KeyCode.Joystick5Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button17", Lib.KeyCode.Joystick5Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button18", Lib.KeyCode.Joystick5Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick5Button19", Lib.KeyCode.Joystick5Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button0", Lib.KeyCode.Joystick6Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button1", Lib.KeyCode.Joystick6Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button2", Lib.KeyCode.Joystick6Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button3", Lib.KeyCode.Joystick6Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button4", Lib.KeyCode.Joystick6Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button5", Lib.KeyCode.Joystick6Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button6", Lib.KeyCode.Joystick6Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button7", Lib.KeyCode.Joystick6Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button8", Lib.KeyCode.Joystick6Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button9", Lib.KeyCode.Joystick6Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button10", Lib.KeyCode.Joystick6Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button11", Lib.KeyCode.Joystick6Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button12", Lib.KeyCode.Joystick6Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button13", Lib.KeyCode.Joystick6Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button14", Lib.KeyCode.Joystick6Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button15", Lib.KeyCode.Joystick6Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button16", Lib.KeyCode.Joystick6Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button17", Lib.KeyCode.Joystick6Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button18", Lib.KeyCode.Joystick6Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick6Button19", Lib.KeyCode.Joystick6Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button0", Lib.KeyCode.Joystick7Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button1", Lib.KeyCode.Joystick7Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button2", Lib.KeyCode.Joystick7Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button3", Lib.KeyCode.Joystick7Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button4", Lib.KeyCode.Joystick7Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button5", Lib.KeyCode.Joystick7Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button6", Lib.KeyCode.Joystick7Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button7", Lib.KeyCode.Joystick7Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button8", Lib.KeyCode.Joystick7Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button9", Lib.KeyCode.Joystick7Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button10", Lib.KeyCode.Joystick7Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button11", Lib.KeyCode.Joystick7Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button12", Lib.KeyCode.Joystick7Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button13", Lib.KeyCode.Joystick7Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button14", Lib.KeyCode.Joystick7Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button15", Lib.KeyCode.Joystick7Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button16", Lib.KeyCode.Joystick7Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button17", Lib.KeyCode.Joystick7Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button18", Lib.KeyCode.Joystick7Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick7Button19", Lib.KeyCode.Joystick7Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button0", Lib.KeyCode.Joystick8Button0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button1", Lib.KeyCode.Joystick8Button1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button2", Lib.KeyCode.Joystick8Button2);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button3", Lib.KeyCode.Joystick8Button3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button4", Lib.KeyCode.Joystick8Button4);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button5", Lib.KeyCode.Joystick8Button5);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button6", Lib.KeyCode.Joystick8Button6);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button7", Lib.KeyCode.Joystick8Button7);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button8", Lib.KeyCode.Joystick8Button8);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button9", Lib.KeyCode.Joystick8Button9);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button10", Lib.KeyCode.Joystick8Button10);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button11", Lib.KeyCode.Joystick8Button11);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button12", Lib.KeyCode.Joystick8Button12);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button13", Lib.KeyCode.Joystick8Button13);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button14", Lib.KeyCode.Joystick8Button14);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button15", Lib.KeyCode.Joystick8Button15);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button16", Lib.KeyCode.Joystick8Button16);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button17", Lib.KeyCode.Joystick8Button17);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button18", Lib.KeyCode.Joystick8Button18);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick8Button19", Lib.KeyCode.Joystick8Button19);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AnyKey", Lib.KeyCode.AnyKey);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Lib.KeyCode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushLibKeyCode(L, (Lib.KeyCode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Backspace"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Backspace);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tab"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Tab);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Clear"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Clear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Return"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Return);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pause"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Pause);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Escape"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Escape);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Space"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Space);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Exclaim"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Exclaim);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DoubleQuote"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.DoubleQuote);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hash"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Hash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dollar"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Dollar);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Percent"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Percent);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Ampersand"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Ampersand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Quote"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Quote);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftParen"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftParen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightParen"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightParen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Asterisk"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Asterisk);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Plus"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Plus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Comma"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Comma);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Minus"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Minus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Period"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Period);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Slash"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Slash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Alpha9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Alpha9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Colon"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Colon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Semicolon"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Semicolon);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Less"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Less);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Equals"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Equals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Greater"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Greater);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Question"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Question);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "At"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.At);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftBracket"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Backslash"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Backslash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightBracket"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Caret"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Caret);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Underscore"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Underscore);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackQuote"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.BackQuote);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "A"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.A);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "B"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.B);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "C"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.C);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "D"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.D);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.E);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "G"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.G);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "H"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.H);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "I"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.I);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "J"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.J);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "K"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.K);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "L"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.L);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "M"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.M);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "N"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.N);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "O"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.O);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "P"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.P);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Q"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Q);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "R"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.R);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "S"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.S);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "T"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.T);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "U"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.U);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "V"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.V);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "W"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.W);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Y);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Z"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Z);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftCurlyBracket"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftCurlyBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Pipe"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Pipe);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightCurlyBracket"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightCurlyBracket);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Tilde"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Tilde);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Delete"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Delete);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Keypad9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Keypad9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadPeriod"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadPeriod);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadDivide"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadDivide);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadMultiply"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadMultiply);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadMinus"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadMinus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadPlus"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadPlus);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadEnter"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadEnter);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "KeypadEquals"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.KeypadEquals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "UpArrow"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.UpArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DownArrow"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.DownArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightArrow"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftArrow"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftArrow);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Insert"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Insert);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Home"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Home);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "End"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.End);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PageUp"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.PageUp);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PageDown"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.PageDown);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "F15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.F15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Numlock"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Numlock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CapsLock"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.CapsLock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ScrollLock"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.ScrollLock);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightShift"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightShift);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftShift"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftShift);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightControl"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightControl);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftControl"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftControl);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightAlt"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightAlt);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftAlt"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftAlt);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightApple"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightApple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightCommand"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightCommand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftApple"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftApple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftCommand"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftCommand);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftWindows"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.LeftWindows);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightWindows"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.RightWindows);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AltGr"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.AltGr);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Help"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Help);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Print"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Print);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SysReq"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.SysReq);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Break"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Break);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Menu"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Menu);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mouse6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Mouse6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "JoystickButton19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.JoystickButton19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick1Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick1Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick2Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick2Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick3Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick3Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick4Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick4Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick5Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick5Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick6Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick6Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick7Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick7Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button0"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button0);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button1"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button2"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button2);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button3"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button4"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button4);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button5"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button5);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button6"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button6);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button7"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button7);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button8"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button8);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button9"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button9);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button10"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button10);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button11"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button11);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button12"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button12);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button13"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button13);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button14"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button14);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button15"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button15);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button16"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button16);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button17"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button17);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button18"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button18);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick8Button19"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.Joystick8Button19);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AnyKey"))
                {
                    translator.PushLibKeyCode(L, Lib.KeyCode.AnyKey);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Lib.KeyCode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Lib.KeyCode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class TutorialDerivedClassTestEnumInnerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E3", Tutorial.DerivedClass.TestEnumInner.E3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E4", Tutorial.DerivedClass.TestEnumInner.E4);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialDerivedClassTestEnumInner(L, (Tutorial.DerivedClass.TestEnumInner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "E3"))
                {
                    translator.PushTutorialDerivedClassTestEnumInner(L, Tutorial.DerivedClass.TestEnumInner.E3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E4"))
                {
                    translator.PushTutorialDerivedClassTestEnumInner(L, Tutorial.DerivedClass.TestEnumInner.E4);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.DerivedClass.TestEnumInner!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.DerivedClass.TestEnumInner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningAutoPlayWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.AutoPlay), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.AutoPlay), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.AutoPlay), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DG.Tweening.AutoPlay.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoPlaySequences", DG.Tweening.AutoPlay.AutoPlaySequences);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AutoPlayTweeners", DG.Tweening.AutoPlay.AutoPlayTweeners);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", DG.Tweening.AutoPlay.All);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.AutoPlay), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningAutoPlay(L, (DG.Tweening.AutoPlay)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDGTweeningAutoPlay(L, DG.Tweening.AutoPlay.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoPlaySequences"))
                {
                    translator.PushDGTweeningAutoPlay(L, DG.Tweening.AutoPlay.AutoPlaySequences);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "AutoPlayTweeners"))
                {
                    translator.PushDGTweeningAutoPlay(L, DG.Tweening.AutoPlay.AutoPlayTweeners);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushDGTweeningAutoPlay(L, DG.Tweening.AutoPlay.All);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.AutoPlay!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.AutoPlay! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningAxisConstraintWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.AxisConstraint), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.AxisConstraint), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.AxisConstraint), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DG.Tweening.AxisConstraint.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "X", DG.Tweening.AxisConstraint.X);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Y", DG.Tweening.AxisConstraint.Y);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Z", DG.Tweening.AxisConstraint.Z);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "W", DG.Tweening.AxisConstraint.W);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.AxisConstraint), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningAxisConstraint(L, (DG.Tweening.AxisConstraint)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDGTweeningAxisConstraint(L, DG.Tweening.AxisConstraint.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "X"))
                {
                    translator.PushDGTweeningAxisConstraint(L, DG.Tweening.AxisConstraint.X);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Y"))
                {
                    translator.PushDGTweeningAxisConstraint(L, DG.Tweening.AxisConstraint.Y);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Z"))
                {
                    translator.PushDGTweeningAxisConstraint(L, DG.Tweening.AxisConstraint.Z);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "W"))
                {
                    translator.PushDGTweeningAxisConstraint(L, DG.Tweening.AxisConstraint.W);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.AxisConstraint!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.AxisConstraint! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningEaseWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.Ease), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.Ease), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.Ease), L, null, 39, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unset", DG.Tweening.Ease.Unset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", DG.Tweening.Ease.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InSine", DG.Tweening.Ease.InSine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutSine", DG.Tweening.Ease.OutSine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutSine", DG.Tweening.Ease.InOutSine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InQuad", DG.Tweening.Ease.InQuad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutQuad", DG.Tweening.Ease.OutQuad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutQuad", DG.Tweening.Ease.InOutQuad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InCubic", DG.Tweening.Ease.InCubic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutCubic", DG.Tweening.Ease.OutCubic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutCubic", DG.Tweening.Ease.InOutCubic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InQuart", DG.Tweening.Ease.InQuart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutQuart", DG.Tweening.Ease.OutQuart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutQuart", DG.Tweening.Ease.InOutQuart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InQuint", DG.Tweening.Ease.InQuint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutQuint", DG.Tweening.Ease.OutQuint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutQuint", DG.Tweening.Ease.InOutQuint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InExpo", DG.Tweening.Ease.InExpo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutExpo", DG.Tweening.Ease.OutExpo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutExpo", DG.Tweening.Ease.InOutExpo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InCirc", DG.Tweening.Ease.InCirc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutCirc", DG.Tweening.Ease.OutCirc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutCirc", DG.Tweening.Ease.InOutCirc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InElastic", DG.Tweening.Ease.InElastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutElastic", DG.Tweening.Ease.OutElastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutElastic", DG.Tweening.Ease.InOutElastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InBack", DG.Tweening.Ease.InBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutBack", DG.Tweening.Ease.OutBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutBack", DG.Tweening.Ease.InOutBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InBounce", DG.Tweening.Ease.InBounce);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutBounce", DG.Tweening.Ease.OutBounce);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutBounce", DG.Tweening.Ease.InOutBounce);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flash", DG.Tweening.Ease.Flash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InFlash", DG.Tweening.Ease.InFlash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutFlash", DG.Tweening.Ease.OutFlash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutFlash", DG.Tweening.Ease.InOutFlash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "INTERNAL_Zero", DG.Tweening.Ease.INTERNAL_Zero);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "INTERNAL_Custom", DG.Tweening.Ease.INTERNAL_Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.Ease), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningEase(L, (DG.Tweening.Ease)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unset"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.Unset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InSine"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InSine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutSine"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutSine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutSine"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutSine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InQuad"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InQuad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutQuad"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutQuad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutQuad"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutQuad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InCubic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InCubic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutCubic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutCubic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutCubic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutCubic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InQuart"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InQuart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutQuart"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutQuart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutQuart"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutQuart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InQuint"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InQuint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutQuint"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutQuint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutQuint"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutQuint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InExpo"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InExpo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutExpo"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutExpo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutExpo"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutExpo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InCirc"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InCirc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutCirc"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutCirc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutCirc"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutCirc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InElastic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InElastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutElastic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutElastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutElastic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutElastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InBack"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutBack"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutBack"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InBounce"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InBounce);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutBounce"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutBounce);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutBounce"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutBounce);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Flash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.Flash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InFlash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InFlash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutFlash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutFlash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutFlash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutFlash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "INTERNAL_Zero"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.INTERNAL_Zero);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "INTERNAL_Custom"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.INTERNAL_Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.Ease!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.Ease! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningLogBehaviourWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.LogBehaviour), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.LogBehaviour), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.LogBehaviour), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Default", DG.Tweening.LogBehaviour.Default);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Verbose", DG.Tweening.LogBehaviour.Verbose);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ErrorsOnly", DG.Tweening.LogBehaviour.ErrorsOnly);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.LogBehaviour), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningLogBehaviour(L, (DG.Tweening.LogBehaviour)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Default"))
                {
                    translator.PushDGTweeningLogBehaviour(L, DG.Tweening.LogBehaviour.Default);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Verbose"))
                {
                    translator.PushDGTweeningLogBehaviour(L, DG.Tweening.LogBehaviour.Verbose);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ErrorsOnly"))
                {
                    translator.PushDGTweeningLogBehaviour(L, DG.Tweening.LogBehaviour.ErrorsOnly);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.LogBehaviour!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.LogBehaviour! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningLoopTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.LoopType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.LoopType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.LoopType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Restart", DG.Tweening.LoopType.Restart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Yoyo", DG.Tweening.LoopType.Yoyo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Incremental", DG.Tweening.LoopType.Incremental);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.LoopType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningLoopType(L, (DG.Tweening.LoopType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Restart"))
                {
                    translator.PushDGTweeningLoopType(L, DG.Tweening.LoopType.Restart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Yoyo"))
                {
                    translator.PushDGTweeningLoopType(L, DG.Tweening.LoopType.Yoyo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Incremental"))
                {
                    translator.PushDGTweeningLoopType(L, DG.Tweening.LoopType.Incremental);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.LoopType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.LoopType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningPathModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.PathMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.PathMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.PathMode), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ignore", DG.Tweening.PathMode.Ignore);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Full3D", DG.Tweening.PathMode.Full3D);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopDown2D", DG.Tweening.PathMode.TopDown2D);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sidescroller2D", DG.Tweening.PathMode.Sidescroller2D);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.PathMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningPathMode(L, (DG.Tweening.PathMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Ignore"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.Ignore);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Full3D"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.Full3D);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopDown2D"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.TopDown2D);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sidescroller2D"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.Sidescroller2D);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.PathMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.PathMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningPathTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.PathType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.PathType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.PathType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", DG.Tweening.PathType.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CatmullRom", DG.Tweening.PathType.CatmullRom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicBezier", DG.Tweening.PathType.CubicBezier);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.PathType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningPathType(L, (DG.Tweening.PathType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushDGTweeningPathType(L, DG.Tweening.PathType.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CatmullRom"))
                {
                    translator.PushDGTweeningPathType(L, DG.Tweening.PathType.CatmullRom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicBezier"))
                {
                    translator.PushDGTweeningPathType(L, DG.Tweening.PathType.CubicBezier);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.PathType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.PathType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningRotateModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.RotateMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.RotateMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.RotateMode), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fast", DG.Tweening.RotateMode.Fast);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FastBeyond360", DG.Tweening.RotateMode.FastBeyond360);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WorldAxisAdd", DG.Tweening.RotateMode.WorldAxisAdd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LocalAxisAdd", DG.Tweening.RotateMode.LocalAxisAdd);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.RotateMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningRotateMode(L, (DG.Tweening.RotateMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fast"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.Fast);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FastBeyond360"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.FastBeyond360);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WorldAxisAdd"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.WorldAxisAdd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LocalAxisAdd"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.LocalAxisAdd);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.RotateMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.RotateMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningScrambleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.ScrambleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.ScrambleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.ScrambleMode), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DG.Tweening.ScrambleMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", DG.Tweening.ScrambleMode.All);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Uppercase", DG.Tweening.ScrambleMode.Uppercase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lowercase", DG.Tweening.ScrambleMode.Lowercase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Numerals", DG.Tweening.ScrambleMode.Numerals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", DG.Tweening.ScrambleMode.Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.ScrambleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningScrambleMode(L, (DG.Tweening.ScrambleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.All);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Uppercase"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Uppercase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lowercase"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Lowercase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Numerals"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Numerals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.ScrambleMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.ScrambleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningTweenTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.TweenType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.TweenType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.TweenType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Tweener", DG.Tweening.TweenType.Tweener);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sequence", DG.Tweening.TweenType.Sequence);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Callback", DG.Tweening.TweenType.Callback);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.TweenType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningTweenType(L, (DG.Tweening.TweenType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Tweener"))
                {
                    translator.PushDGTweeningTweenType(L, DG.Tweening.TweenType.Tweener);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sequence"))
                {
                    translator.PushDGTweeningTweenType(L, DG.Tweening.TweenType.Sequence);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Callback"))
                {
                    translator.PushDGTweeningTweenType(L, DG.Tweening.TweenType.Callback);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.TweenType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.TweenType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningUpdateTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.UpdateType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.UpdateType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.UpdateType), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", DG.Tweening.UpdateType.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Late", DG.Tweening.UpdateType.Late);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", DG.Tweening.UpdateType.Fixed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Manual", DG.Tweening.UpdateType.Manual);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.UpdateType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningUpdateType(L, (DG.Tweening.UpdateType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushDGTweeningUpdateType(L, DG.Tweening.UpdateType.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Late"))
                {
                    translator.PushDGTweeningUpdateType(L, DG.Tweening.UpdateType.Late);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushDGTweeningUpdateType(L, DG.Tweening.UpdateType.Fixed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Manual"))
                {
                    translator.PushDGTweeningUpdateType(L, DG.Tweening.UpdateType.Manual);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.UpdateType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.UpdateType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}