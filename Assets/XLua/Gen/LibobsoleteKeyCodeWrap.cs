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
    public class LibobsoleteKeyCodeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Lib.obsolete.KeyCode);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 327, 327);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "None", _g_get_None);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Backspace", _g_get_Backspace);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Tab", _g_get_Tab);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Clear", _g_get_Clear);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Return", _g_get_Return);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Pause", _g_get_Pause);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Escape", _g_get_Escape);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Space", _g_get_Space);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Exclaim", _g_get_Exclaim);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DoubleQuote", _g_get_DoubleQuote);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Hash", _g_get_Hash);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Dollar", _g_get_Dollar);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Percent", _g_get_Percent);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Ampersand", _g_get_Ampersand);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Quote", _g_get_Quote);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftParen", _g_get_LeftParen);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightParen", _g_get_RightParen);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Asterisk", _g_get_Asterisk);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Plus", _g_get_Plus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Comma", _g_get_Comma);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Minus", _g_get_Minus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Period", _g_get_Period);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Slash", _g_get_Slash);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha0", _g_get_Alpha0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha1", _g_get_Alpha1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha2", _g_get_Alpha2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha3", _g_get_Alpha3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha4", _g_get_Alpha4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha5", _g_get_Alpha5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha6", _g_get_Alpha6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha7", _g_get_Alpha7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha8", _g_get_Alpha8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Alpha9", _g_get_Alpha9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Colon", _g_get_Colon);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Semicolon", _g_get_Semicolon);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Less", _g_get_Less);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Equal", _g_get_Equal);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Greater", _g_get_Greater);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Question", _g_get_Question);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "At", _g_get_At);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftBracket", _g_get_LeftBracket);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Backslash", _g_get_Backslash);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightBracket", _g_get_RightBracket);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Caret", _g_get_Caret);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Underscore", _g_get_Underscore);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BackQuote", _g_get_BackQuote);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "A", _g_get_A);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "B", _g_get_B);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "C", _g_get_C);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "D", _g_get_D);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "E", _g_get_E);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F", _g_get_F);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "G", _g_get_G);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "H", _g_get_H);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "I", _g_get_I);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "J", _g_get_J);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "K", _g_get_K);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "L", _g_get_L);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "M", _g_get_M);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "N", _g_get_N);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "O", _g_get_O);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "P", _g_get_P);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Q", _g_get_Q);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "R", _g_get_R);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "S", _g_get_S);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "T", _g_get_T);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "U", _g_get_U);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "V", _g_get_V);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "W", _g_get_W);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "X", _g_get_X);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Y", _g_get_Y);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Z", _g_get_Z);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftCurlyBracket", _g_get_LeftCurlyBracket);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Pipe", _g_get_Pipe);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightCurlyBracket", _g_get_RightCurlyBracket);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Tilde", _g_get_Tilde);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Delete", _g_get_Delete);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad0", _g_get_Keypad0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad1", _g_get_Keypad1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad2", _g_get_Keypad2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad3", _g_get_Keypad3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad4", _g_get_Keypad4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad5", _g_get_Keypad5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad6", _g_get_Keypad6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad7", _g_get_Keypad7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad8", _g_get_Keypad8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Keypad9", _g_get_Keypad9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadPeriod", _g_get_KeypadPeriod);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadDivide", _g_get_KeypadDivide);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadMultiply", _g_get_KeypadMultiply);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadMinus", _g_get_KeypadMinus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadPlus", _g_get_KeypadPlus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadEnter", _g_get_KeypadEnter);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "KeypadEquals", _g_get_KeypadEquals);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "UpArrow", _g_get_UpArrow);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "DownArrow", _g_get_DownArrow);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightArrow", _g_get_RightArrow);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftArrow", _g_get_LeftArrow);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Insert", _g_get_Insert);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Home", _g_get_Home);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "End", _g_get_End);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "PageUp", _g_get_PageUp);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "PageDown", _g_get_PageDown);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F1", _g_get_F1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F2", _g_get_F2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F3", _g_get_F3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F4", _g_get_F4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F5", _g_get_F5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F6", _g_get_F6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F7", _g_get_F7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F8", _g_get_F8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F9", _g_get_F9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F10", _g_get_F10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F11", _g_get_F11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F12", _g_get_F12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F13", _g_get_F13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F14", _g_get_F14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "F15", _g_get_F15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Numlock", _g_get_Numlock);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CapsLock", _g_get_CapsLock);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ScrollLock", _g_get_ScrollLock);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightShift", _g_get_RightShift);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftShift", _g_get_LeftShift);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightControl", _g_get_RightControl);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftControl", _g_get_LeftControl);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightAlt", _g_get_RightAlt);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftAlt", _g_get_LeftAlt);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightApple", _g_get_RightApple);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightCommand", _g_get_RightCommand);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftApple", _g_get_LeftApple);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftCommand", _g_get_LeftCommand);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LeftWindows", _g_get_LeftWindows);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RightWindows", _g_get_RightWindows);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AltGr", _g_get_AltGr);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Help", _g_get_Help);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Print", _g_get_Print);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "SysReq", _g_get_SysReq);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Break", _g_get_Break);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Menu", _g_get_Menu);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse0", _g_get_Mouse0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse1", _g_get_Mouse1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse2", _g_get_Mouse2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse3", _g_get_Mouse3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse4", _g_get_Mouse4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse5", _g_get_Mouse5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Mouse6", _g_get_Mouse6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton0", _g_get_JoystickButton0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton1", _g_get_JoystickButton1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton2", _g_get_JoystickButton2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton3", _g_get_JoystickButton3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton4", _g_get_JoystickButton4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton5", _g_get_JoystickButton5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton6", _g_get_JoystickButton6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton7", _g_get_JoystickButton7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton8", _g_get_JoystickButton8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton9", _g_get_JoystickButton9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton10", _g_get_JoystickButton10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton11", _g_get_JoystickButton11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton12", _g_get_JoystickButton12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton13", _g_get_JoystickButton13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton14", _g_get_JoystickButton14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton15", _g_get_JoystickButton15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton16", _g_get_JoystickButton16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton17", _g_get_JoystickButton17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton18", _g_get_JoystickButton18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "JoystickButton19", _g_get_JoystickButton19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button0", _g_get_Joystick1Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button1", _g_get_Joystick1Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button2", _g_get_Joystick1Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button3", _g_get_Joystick1Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button4", _g_get_Joystick1Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button5", _g_get_Joystick1Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button6", _g_get_Joystick1Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button7", _g_get_Joystick1Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button8", _g_get_Joystick1Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button9", _g_get_Joystick1Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button10", _g_get_Joystick1Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button11", _g_get_Joystick1Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button12", _g_get_Joystick1Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button13", _g_get_Joystick1Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button14", _g_get_Joystick1Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button15", _g_get_Joystick1Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button16", _g_get_Joystick1Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button17", _g_get_Joystick1Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button18", _g_get_Joystick1Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick1Button19", _g_get_Joystick1Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button0", _g_get_Joystick2Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button1", _g_get_Joystick2Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button2", _g_get_Joystick2Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button3", _g_get_Joystick2Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button4", _g_get_Joystick2Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button5", _g_get_Joystick2Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button6", _g_get_Joystick2Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button7", _g_get_Joystick2Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button8", _g_get_Joystick2Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button9", _g_get_Joystick2Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button10", _g_get_Joystick2Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button11", _g_get_Joystick2Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button12", _g_get_Joystick2Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button13", _g_get_Joystick2Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button14", _g_get_Joystick2Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button15", _g_get_Joystick2Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button16", _g_get_Joystick2Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button17", _g_get_Joystick2Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button18", _g_get_Joystick2Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick2Button19", _g_get_Joystick2Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button0", _g_get_Joystick3Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button1", _g_get_Joystick3Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button2", _g_get_Joystick3Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button3", _g_get_Joystick3Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button4", _g_get_Joystick3Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button5", _g_get_Joystick3Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button6", _g_get_Joystick3Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button7", _g_get_Joystick3Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button8", _g_get_Joystick3Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button9", _g_get_Joystick3Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button10", _g_get_Joystick3Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button11", _g_get_Joystick3Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button12", _g_get_Joystick3Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button13", _g_get_Joystick3Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button14", _g_get_Joystick3Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button15", _g_get_Joystick3Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button16", _g_get_Joystick3Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button17", _g_get_Joystick3Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button18", _g_get_Joystick3Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick3Button19", _g_get_Joystick3Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button0", _g_get_Joystick4Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button1", _g_get_Joystick4Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button2", _g_get_Joystick4Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button3", _g_get_Joystick4Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button4", _g_get_Joystick4Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button5", _g_get_Joystick4Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button6", _g_get_Joystick4Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button7", _g_get_Joystick4Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button8", _g_get_Joystick4Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button9", _g_get_Joystick4Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button10", _g_get_Joystick4Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button11", _g_get_Joystick4Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button12", _g_get_Joystick4Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button13", _g_get_Joystick4Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button14", _g_get_Joystick4Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button15", _g_get_Joystick4Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button16", _g_get_Joystick4Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button17", _g_get_Joystick4Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button18", _g_get_Joystick4Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick4Button19", _g_get_Joystick4Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button0", _g_get_Joystick5Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button1", _g_get_Joystick5Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button2", _g_get_Joystick5Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button3", _g_get_Joystick5Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button4", _g_get_Joystick5Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button5", _g_get_Joystick5Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button6", _g_get_Joystick5Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button7", _g_get_Joystick5Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button8", _g_get_Joystick5Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button9", _g_get_Joystick5Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button10", _g_get_Joystick5Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button11", _g_get_Joystick5Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button12", _g_get_Joystick5Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button13", _g_get_Joystick5Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button14", _g_get_Joystick5Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button15", _g_get_Joystick5Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button16", _g_get_Joystick5Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button17", _g_get_Joystick5Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button18", _g_get_Joystick5Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick5Button19", _g_get_Joystick5Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button0", _g_get_Joystick6Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button1", _g_get_Joystick6Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button2", _g_get_Joystick6Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button3", _g_get_Joystick6Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button4", _g_get_Joystick6Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button5", _g_get_Joystick6Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button6", _g_get_Joystick6Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button7", _g_get_Joystick6Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button8", _g_get_Joystick6Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button9", _g_get_Joystick6Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button10", _g_get_Joystick6Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button11", _g_get_Joystick6Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button12", _g_get_Joystick6Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button13", _g_get_Joystick6Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button14", _g_get_Joystick6Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button15", _g_get_Joystick6Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button16", _g_get_Joystick6Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button17", _g_get_Joystick6Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button18", _g_get_Joystick6Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick6Button19", _g_get_Joystick6Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button0", _g_get_Joystick7Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button1", _g_get_Joystick7Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button2", _g_get_Joystick7Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button3", _g_get_Joystick7Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button4", _g_get_Joystick7Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button5", _g_get_Joystick7Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button6", _g_get_Joystick7Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button7", _g_get_Joystick7Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button8", _g_get_Joystick7Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button9", _g_get_Joystick7Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button10", _g_get_Joystick7Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button11", _g_get_Joystick7Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button12", _g_get_Joystick7Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button13", _g_get_Joystick7Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button14", _g_get_Joystick7Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button15", _g_get_Joystick7Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button16", _g_get_Joystick7Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button17", _g_get_Joystick7Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button18", _g_get_Joystick7Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick7Button19", _g_get_Joystick7Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button0", _g_get_Joystick8Button0);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button1", _g_get_Joystick8Button1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button2", _g_get_Joystick8Button2);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button3", _g_get_Joystick8Button3);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button4", _g_get_Joystick8Button4);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button5", _g_get_Joystick8Button5);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button6", _g_get_Joystick8Button6);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button7", _g_get_Joystick8Button7);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button8", _g_get_Joystick8Button8);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button9", _g_get_Joystick8Button9);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button10", _g_get_Joystick8Button10);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button11", _g_get_Joystick8Button11);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button12", _g_get_Joystick8Button12);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button13", _g_get_Joystick8Button13);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button14", _g_get_Joystick8Button14);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button15", _g_get_Joystick8Button15);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button16", _g_get_Joystick8Button16);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button17", _g_get_Joystick8Button17);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button18", _g_get_Joystick8Button18);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Joystick8Button19", _g_get_Joystick8Button19);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AnyKey", _g_get_AnyKey);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "None", _s_set_None);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Backspace", _s_set_Backspace);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Tab", _s_set_Tab);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Clear", _s_set_Clear);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Return", _s_set_Return);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Pause", _s_set_Pause);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Escape", _s_set_Escape);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Space", _s_set_Space);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Exclaim", _s_set_Exclaim);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "DoubleQuote", _s_set_DoubleQuote);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Hash", _s_set_Hash);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Dollar", _s_set_Dollar);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Percent", _s_set_Percent);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Ampersand", _s_set_Ampersand);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Quote", _s_set_Quote);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftParen", _s_set_LeftParen);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightParen", _s_set_RightParen);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Asterisk", _s_set_Asterisk);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Plus", _s_set_Plus);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Comma", _s_set_Comma);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Minus", _s_set_Minus);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Period", _s_set_Period);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Slash", _s_set_Slash);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha0", _s_set_Alpha0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha1", _s_set_Alpha1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha2", _s_set_Alpha2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha3", _s_set_Alpha3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha4", _s_set_Alpha4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha5", _s_set_Alpha5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha6", _s_set_Alpha6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha7", _s_set_Alpha7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha8", _s_set_Alpha8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Alpha9", _s_set_Alpha9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Colon", _s_set_Colon);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Semicolon", _s_set_Semicolon);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Less", _s_set_Less);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Equal", _s_set_Equal);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Greater", _s_set_Greater);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Question", _s_set_Question);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "At", _s_set_At);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftBracket", _s_set_LeftBracket);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Backslash", _s_set_Backslash);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightBracket", _s_set_RightBracket);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Caret", _s_set_Caret);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Underscore", _s_set_Underscore);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "BackQuote", _s_set_BackQuote);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "A", _s_set_A);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "B", _s_set_B);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "C", _s_set_C);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "D", _s_set_D);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "E", _s_set_E);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F", _s_set_F);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "G", _s_set_G);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "H", _s_set_H);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "I", _s_set_I);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "J", _s_set_J);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "K", _s_set_K);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "L", _s_set_L);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "M", _s_set_M);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "N", _s_set_N);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "O", _s_set_O);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "P", _s_set_P);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Q", _s_set_Q);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "R", _s_set_R);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "S", _s_set_S);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "T", _s_set_T);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "U", _s_set_U);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "V", _s_set_V);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "W", _s_set_W);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "X", _s_set_X);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Y", _s_set_Y);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Z", _s_set_Z);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftCurlyBracket", _s_set_LeftCurlyBracket);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Pipe", _s_set_Pipe);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightCurlyBracket", _s_set_RightCurlyBracket);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Tilde", _s_set_Tilde);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Delete", _s_set_Delete);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad0", _s_set_Keypad0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad1", _s_set_Keypad1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad2", _s_set_Keypad2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad3", _s_set_Keypad3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad4", _s_set_Keypad4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad5", _s_set_Keypad5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad6", _s_set_Keypad6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad7", _s_set_Keypad7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad8", _s_set_Keypad8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Keypad9", _s_set_Keypad9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadPeriod", _s_set_KeypadPeriod);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadDivide", _s_set_KeypadDivide);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadMultiply", _s_set_KeypadMultiply);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadMinus", _s_set_KeypadMinus);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadPlus", _s_set_KeypadPlus);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadEnter", _s_set_KeypadEnter);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "KeypadEquals", _s_set_KeypadEquals);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "UpArrow", _s_set_UpArrow);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "DownArrow", _s_set_DownArrow);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightArrow", _s_set_RightArrow);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftArrow", _s_set_LeftArrow);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Insert", _s_set_Insert);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Home", _s_set_Home);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "End", _s_set_End);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "PageUp", _s_set_PageUp);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "PageDown", _s_set_PageDown);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F1", _s_set_F1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F2", _s_set_F2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F3", _s_set_F3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F4", _s_set_F4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F5", _s_set_F5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F6", _s_set_F6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F7", _s_set_F7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F8", _s_set_F8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F9", _s_set_F9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F10", _s_set_F10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F11", _s_set_F11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F12", _s_set_F12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F13", _s_set_F13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F14", _s_set_F14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "F15", _s_set_F15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Numlock", _s_set_Numlock);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CapsLock", _s_set_CapsLock);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ScrollLock", _s_set_ScrollLock);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightShift", _s_set_RightShift);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftShift", _s_set_LeftShift);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightControl", _s_set_RightControl);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftControl", _s_set_LeftControl);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightAlt", _s_set_RightAlt);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftAlt", _s_set_LeftAlt);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightApple", _s_set_RightApple);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightCommand", _s_set_RightCommand);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftApple", _s_set_LeftApple);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftCommand", _s_set_LeftCommand);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LeftWindows", _s_set_LeftWindows);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "RightWindows", _s_set_RightWindows);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "AltGr", _s_set_AltGr);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Help", _s_set_Help);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Print", _s_set_Print);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "SysReq", _s_set_SysReq);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Break", _s_set_Break);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Menu", _s_set_Menu);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse0", _s_set_Mouse0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse1", _s_set_Mouse1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse2", _s_set_Mouse2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse3", _s_set_Mouse3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse4", _s_set_Mouse4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse5", _s_set_Mouse5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Mouse6", _s_set_Mouse6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton0", _s_set_JoystickButton0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton1", _s_set_JoystickButton1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton2", _s_set_JoystickButton2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton3", _s_set_JoystickButton3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton4", _s_set_JoystickButton4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton5", _s_set_JoystickButton5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton6", _s_set_JoystickButton6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton7", _s_set_JoystickButton7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton8", _s_set_JoystickButton8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton9", _s_set_JoystickButton9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton10", _s_set_JoystickButton10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton11", _s_set_JoystickButton11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton12", _s_set_JoystickButton12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton13", _s_set_JoystickButton13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton14", _s_set_JoystickButton14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton15", _s_set_JoystickButton15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton16", _s_set_JoystickButton16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton17", _s_set_JoystickButton17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton18", _s_set_JoystickButton18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "JoystickButton19", _s_set_JoystickButton19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button0", _s_set_Joystick1Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button1", _s_set_Joystick1Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button2", _s_set_Joystick1Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button3", _s_set_Joystick1Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button4", _s_set_Joystick1Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button5", _s_set_Joystick1Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button6", _s_set_Joystick1Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button7", _s_set_Joystick1Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button8", _s_set_Joystick1Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button9", _s_set_Joystick1Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button10", _s_set_Joystick1Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button11", _s_set_Joystick1Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button12", _s_set_Joystick1Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button13", _s_set_Joystick1Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button14", _s_set_Joystick1Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button15", _s_set_Joystick1Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button16", _s_set_Joystick1Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button17", _s_set_Joystick1Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button18", _s_set_Joystick1Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick1Button19", _s_set_Joystick1Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button0", _s_set_Joystick2Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button1", _s_set_Joystick2Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button2", _s_set_Joystick2Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button3", _s_set_Joystick2Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button4", _s_set_Joystick2Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button5", _s_set_Joystick2Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button6", _s_set_Joystick2Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button7", _s_set_Joystick2Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button8", _s_set_Joystick2Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button9", _s_set_Joystick2Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button10", _s_set_Joystick2Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button11", _s_set_Joystick2Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button12", _s_set_Joystick2Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button13", _s_set_Joystick2Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button14", _s_set_Joystick2Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button15", _s_set_Joystick2Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button16", _s_set_Joystick2Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button17", _s_set_Joystick2Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button18", _s_set_Joystick2Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick2Button19", _s_set_Joystick2Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button0", _s_set_Joystick3Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button1", _s_set_Joystick3Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button2", _s_set_Joystick3Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button3", _s_set_Joystick3Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button4", _s_set_Joystick3Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button5", _s_set_Joystick3Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button6", _s_set_Joystick3Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button7", _s_set_Joystick3Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button8", _s_set_Joystick3Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button9", _s_set_Joystick3Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button10", _s_set_Joystick3Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button11", _s_set_Joystick3Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button12", _s_set_Joystick3Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button13", _s_set_Joystick3Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button14", _s_set_Joystick3Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button15", _s_set_Joystick3Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button16", _s_set_Joystick3Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button17", _s_set_Joystick3Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button18", _s_set_Joystick3Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick3Button19", _s_set_Joystick3Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button0", _s_set_Joystick4Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button1", _s_set_Joystick4Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button2", _s_set_Joystick4Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button3", _s_set_Joystick4Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button4", _s_set_Joystick4Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button5", _s_set_Joystick4Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button6", _s_set_Joystick4Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button7", _s_set_Joystick4Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button8", _s_set_Joystick4Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button9", _s_set_Joystick4Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button10", _s_set_Joystick4Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button11", _s_set_Joystick4Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button12", _s_set_Joystick4Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button13", _s_set_Joystick4Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button14", _s_set_Joystick4Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button15", _s_set_Joystick4Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button16", _s_set_Joystick4Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button17", _s_set_Joystick4Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button18", _s_set_Joystick4Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick4Button19", _s_set_Joystick4Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button0", _s_set_Joystick5Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button1", _s_set_Joystick5Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button2", _s_set_Joystick5Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button3", _s_set_Joystick5Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button4", _s_set_Joystick5Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button5", _s_set_Joystick5Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button6", _s_set_Joystick5Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button7", _s_set_Joystick5Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button8", _s_set_Joystick5Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button9", _s_set_Joystick5Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button10", _s_set_Joystick5Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button11", _s_set_Joystick5Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button12", _s_set_Joystick5Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button13", _s_set_Joystick5Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button14", _s_set_Joystick5Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button15", _s_set_Joystick5Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button16", _s_set_Joystick5Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button17", _s_set_Joystick5Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button18", _s_set_Joystick5Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick5Button19", _s_set_Joystick5Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button0", _s_set_Joystick6Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button1", _s_set_Joystick6Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button2", _s_set_Joystick6Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button3", _s_set_Joystick6Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button4", _s_set_Joystick6Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button5", _s_set_Joystick6Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button6", _s_set_Joystick6Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button7", _s_set_Joystick6Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button8", _s_set_Joystick6Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button9", _s_set_Joystick6Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button10", _s_set_Joystick6Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button11", _s_set_Joystick6Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button12", _s_set_Joystick6Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button13", _s_set_Joystick6Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button14", _s_set_Joystick6Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button15", _s_set_Joystick6Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button16", _s_set_Joystick6Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button17", _s_set_Joystick6Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button18", _s_set_Joystick6Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick6Button19", _s_set_Joystick6Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button0", _s_set_Joystick7Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button1", _s_set_Joystick7Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button2", _s_set_Joystick7Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button3", _s_set_Joystick7Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button4", _s_set_Joystick7Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button5", _s_set_Joystick7Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button6", _s_set_Joystick7Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button7", _s_set_Joystick7Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button8", _s_set_Joystick7Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button9", _s_set_Joystick7Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button10", _s_set_Joystick7Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button11", _s_set_Joystick7Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button12", _s_set_Joystick7Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button13", _s_set_Joystick7Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button14", _s_set_Joystick7Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button15", _s_set_Joystick7Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button16", _s_set_Joystick7Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button17", _s_set_Joystick7Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button18", _s_set_Joystick7Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick7Button19", _s_set_Joystick7Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button0", _s_set_Joystick8Button0);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button1", _s_set_Joystick8Button1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button2", _s_set_Joystick8Button2);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button3", _s_set_Joystick8Button3);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button4", _s_set_Joystick8Button4);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button5", _s_set_Joystick8Button5);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button6", _s_set_Joystick8Button6);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button7", _s_set_Joystick8Button7);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button8", _s_set_Joystick8Button8);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button9", _s_set_Joystick8Button9);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button10", _s_set_Joystick8Button10);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button11", _s_set_Joystick8Button11);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button12", _s_set_Joystick8Button12);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button13", _s_set_Joystick8Button13);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button14", _s_set_Joystick8Button14);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button15", _s_set_Joystick8Button15);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button16", _s_set_Joystick8Button16);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button17", _s_set_Joystick8Button17);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button18", _s_set_Joystick8Button18);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Joystick8Button19", _s_set_Joystick8Button19);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "AnyKey", _s_set_AnyKey);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					Lib.obsolete.KeyCode gen_ret = new Lib.obsolete.KeyCode();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Lib.obsolete.KeyCode constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_None(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.None);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Backspace(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Backspace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Tab(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Tab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Clear(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Clear);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Return(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Return);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Pause(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Pause);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Escape(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Escape);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Space(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Space);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Exclaim(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Exclaim);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DoubleQuote(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.DoubleQuote);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Hash(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Hash);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Dollar(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Dollar);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Percent(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Percent);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ampersand(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Ampersand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Quote(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Quote);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftParen(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftParen);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightParen(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightParen);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Asterisk(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Asterisk);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Plus(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Plus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Comma(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Comma);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Minus(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Minus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Period(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Period);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Slash(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Slash);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alpha9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Alpha9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Colon(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Colon);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Semicolon(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Semicolon);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Less(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Less);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Equal(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Equal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Greater(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Greater);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Question(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Question);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_At(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.At);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftBracket(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftBracket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Backslash(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Backslash);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightBracket(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightBracket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Caret(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Caret);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Underscore(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Underscore);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BackQuote(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.BackQuote);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_A(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.A);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_B(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.B);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_C(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.C);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_D(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.D);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_E(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.E);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_G(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.G);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_H(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.H);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_I(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.I);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_J(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.J);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_K(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.K);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_L(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.L);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_M(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.M);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_N(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.N);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_O(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.O);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_P(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.P);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Q(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Q);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_R(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.R);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_S(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.S);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_T(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.T);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_U(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.U);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_V(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.V);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_W(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.W);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_X(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.X);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Y(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Y);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Z(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Z);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftCurlyBracket(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftCurlyBracket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Pipe(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Pipe);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightCurlyBracket(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightCurlyBracket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Tilde(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Tilde);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Delete(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Delete);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Keypad9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Keypad9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadPeriod(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadPeriod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadDivide(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadDivide);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadMultiply(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadMultiply);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadMinus(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadMinus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadPlus(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadPlus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadEnter(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadEnter);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KeypadEquals(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.KeypadEquals);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_UpArrow(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.UpArrow);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DownArrow(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.DownArrow);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightArrow(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightArrow);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftArrow(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftArrow);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Insert(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Insert);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Home(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Home);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_End(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.End);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PageUp(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.PageUp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PageDown(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.PageDown);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_F15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.F15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Numlock(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Numlock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CapsLock(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.CapsLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ScrollLock(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.ScrollLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightShift(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightShift);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftShift(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftShift);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightControl(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightControl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftControl(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftControl);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightAlt(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightAlt);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftAlt(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftAlt);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightApple(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightApple);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightCommand(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightCommand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftApple(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftApple);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftCommand(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftCommand);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LeftWindows(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.LeftWindows);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RightWindows(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.RightWindows);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AltGr(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.AltGr);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Help(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Help);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Print(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Print);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SysReq(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.SysReq);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Break(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Break);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Menu(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Menu);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Mouse6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Mouse6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_JoystickButton19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.JoystickButton19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick1Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick1Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick2Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick2Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick3Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick3Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick4Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick4Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick5Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick5Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick6Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick6Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick7Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick7Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button0(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button0);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button1(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button2(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button3(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button3);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button4(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button5(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button5);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button6(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button6);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button7(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button7);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button8(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button8);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button9(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button9);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button10(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button10);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button11(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button11);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button12(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button12);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button13(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button13);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button14(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button14);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button15(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button15);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button16(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button16);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button17(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button17);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button18(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button18);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Joystick8Button19(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.Joystick8Button19);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AnyKey(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, Lib.obsolete.KeyCode.AnyKey);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_None(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.None = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Backspace(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Backspace = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Tab(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Tab = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Clear(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Clear = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Return(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Return = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Pause(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Pause = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Escape(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Escape = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Space(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Space = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Exclaim(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Exclaim = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DoubleQuote(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.DoubleQuote = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Hash(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Hash = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Dollar(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Dollar = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Percent(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Percent = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Ampersand(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Ampersand = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Quote(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Quote = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftParen(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftParen = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightParen(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightParen = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Asterisk(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Asterisk = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Plus(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Plus = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Comma(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Comma = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Minus(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Minus = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Period(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Period = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Slash(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Slash = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alpha9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Alpha9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Colon(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Colon = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Semicolon(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Semicolon = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Less(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Less = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Equal(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Equal = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Greater(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Greater = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Question(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Question = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_At(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.At = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftBracket(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftBracket = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Backslash(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Backslash = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightBracket(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightBracket = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Caret(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Caret = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Underscore(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Underscore = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BackQuote(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.BackQuote = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_A(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.A = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_B(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.B = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_C(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.C = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_D(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.D = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_E(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.E = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_G(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.G = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_H(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.H = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_I(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.I = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_J(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.J = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_K(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.K = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_L(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.L = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_M(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.M = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_N(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.N = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_O(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.O = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_P(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.P = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Q(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Q = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_R(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.R = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_S(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.S = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_T(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.T = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_U(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.U = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_V(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.V = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_W(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.W = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_X(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.X = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Y(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Y = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Z(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Z = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftCurlyBracket(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftCurlyBracket = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Pipe(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Pipe = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightCurlyBracket(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightCurlyBracket = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Tilde(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Tilde = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Delete(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Delete = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Keypad9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Keypad9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadPeriod(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadPeriod = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadDivide(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadDivide = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadMultiply(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadMultiply = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadMinus(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadMinus = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadPlus(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadPlus = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadEnter(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadEnter = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_KeypadEquals(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.KeypadEquals = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_UpArrow(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.UpArrow = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_DownArrow(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.DownArrow = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightArrow(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightArrow = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftArrow(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftArrow = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Insert(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Insert = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Home(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Home = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_End(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.End = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PageUp(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.PageUp = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PageDown(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.PageDown = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_F15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.F15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Numlock(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Numlock = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CapsLock(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.CapsLock = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ScrollLock(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.ScrollLock = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightShift(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightShift = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftShift(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftShift = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightControl(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightControl = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftControl(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftControl = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightAlt(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightAlt = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftAlt(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftAlt = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightApple(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightApple = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightCommand(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightCommand = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftApple(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftApple = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftCommand(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftCommand = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LeftWindows(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.LeftWindows = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_RightWindows(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.RightWindows = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AltGr(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.AltGr = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Help(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Help = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Print(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Print = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SysReq(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.SysReq = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Break(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Break = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Menu(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Menu = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Mouse6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Mouse6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_JoystickButton19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.JoystickButton19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick1Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick1Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick2Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick2Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick3Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick3Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick4Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick4Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick5Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick5Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick6Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick6Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick7Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick7Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button0(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button0 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button1(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button1 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button2(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button2 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button3(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button3 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button4(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button4 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button5(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button5 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button6(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button6 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button7(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button7 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button8(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button8 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button9(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button9 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button10(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button10 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button11(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button11 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button12(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button12 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button13(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button13 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button14(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button14 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button15(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button15 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button16(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button16 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button17(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button17 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button18(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button18 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Joystick8Button19(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.Joystick8Button19 = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AnyKey(RealStatePtr L)
        {
		    try {
                
			    Lib.obsolete.KeyCode.AnyKey = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
