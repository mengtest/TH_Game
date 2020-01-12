--@SuperType [luaIde#CS.System.Object]
CS.LoginRes = {}
--[[
	@return [luaIde#CS.LoginRes]
]]
function CS.LoginRes() end
--[[
	@other CS.LoginRes
	@return [luaIde#CS.LoginRes]
]]
function CS.LoginRes(other) end
--[[
	CS.Google.Protobuf.MessageParser`1{{LoginRes, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	 Get 
--]]
CS.LoginRes.Parser = nil
--[[
	CS.Google.Protobuf.Reflection.MessageDescriptor
	 Get 
--]]
CS.LoginRes.Descriptor = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.LoginRes.Res = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginRes.Uid = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.LoginRes.Nickname = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.LoginRes.Msg = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginRes.ResFieldNumber = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginRes.UidFieldNumber = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginRes.NicknameFieldNumber = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginRes.MsgFieldNumber = nil
function CS.LoginRes:Clone() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.LoginRes:Equals(other) end
--[[
	@other CS.LoginRes
	return CS.System.Boolean
--]]
function CS.LoginRes:Equals(other) end
function CS.LoginRes:GetHashCode() end
function CS.LoginRes:ToString() end
--[[
	@output CS.Google.Protobuf.CodedOutputStream
--]]
function CS.LoginRes:WriteTo(output) end
function CS.LoginRes:CalculateSize() end
--[[
	@other CS.LoginRes
--]]
function CS.LoginRes:MergeFrom(other) end
--[[
	@input CS.Google.Protobuf.CodedInputStream
--]]
function CS.LoginRes:MergeFrom(input) end

--@SuperType [luaIde#CS.System.Object]
CS.LoginMsg = {}
--[[
	@return [luaIde#CS.LoginMsg]
]]
function CS.LoginMsg() end
--[[
	@other CS.LoginMsg
	@return [luaIde#CS.LoginMsg]
]]
function CS.LoginMsg(other) end
--[[
	CS.Google.Protobuf.MessageParser`1{{LoginMsg, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	 Get 
--]]
CS.LoginMsg.Parser = nil
--[[
	CS.Google.Protobuf.Reflection.MessageDescriptor
	 Get 
--]]
CS.LoginMsg.Descriptor = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.LoginMsg.Username = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.LoginMsg.Userpwd = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginMsg.UsernameFieldNumber = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.LoginMsg.UserpwdFieldNumber = nil
function CS.LoginMsg:Clone() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.LoginMsg:Equals(other) end
--[[
	@other CS.LoginMsg
	return CS.System.Boolean
--]]
function CS.LoginMsg:Equals(other) end
function CS.LoginMsg:GetHashCode() end
function CS.LoginMsg:ToString() end
--[[
	@output CS.Google.Protobuf.CodedOutputStream
--]]
function CS.LoginMsg:WriteTo(output) end
function CS.LoginMsg:CalculateSize() end
--[[
	@other CS.LoginMsg
--]]
function CS.LoginMsg:MergeFrom(other) end
--[[
	@input CS.Google.Protobuf.CodedInputStream
--]]
function CS.LoginMsg:MergeFrom(input) end

--@SuperType [luaIde#CS.System.Object]
CS.Global = {}
--[[
	CS.UnityEngine.SceneManagement.Scene
	 Get 
--]]
CS.Global.Scene = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.Global.ToastShort = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.Global.ToastLong = nil
--[[
	@msg CS.System.String
	@level CS.Global.Level
--]]
function CS.Global:Log(msg,level) end
--[[
	@name CS.System.String
	return CS.UnityEngine.GameObject
--]]
function CS.Global:GetRootObject(name) end
function CS.Global:GetCurCanvas() end
--[[
	@text CS.System.String
--]]
function CS.Global:Alert(text) end
--[[
	@text CS.System.String
	@time CS.System.Single
--]]
function CS.Global:MakeToast(text,time) end
--[[
	@name CS.System.String
	@loading CS.System.Boolean
--]]
function CS.Global:NavigateTo(name,loading) end
--[[
	@id CS.System.Int32
	@loading CS.System.Boolean
--]]
function CS.Global:NavigateTo(id,loading) end
function CS.Global:Refresh() end
function CS.Global:Return() end

--@SuperType [luaIde#CS.System.Object]
CS.Timer = {}
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.Timer.duration = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.Timer.isLooped = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.Timer.isCompleted = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.Timer.usesRealTime = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.Timer.isPaused = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.Timer.isCancelled = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.Timer.isDone = nil
--[[
	@duration CS.System.Single
	@onComplete CS.System.Action
	@onUpdate CS.System.Action`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@isLooped CS.System.Boolean
	@useRealTime CS.System.Boolean
	@autoDestroyOwner CS.UnityEngine.MonoBehaviour
	@return [luaIde#CS.Timer]
--]]
function CS.Timer:Register(duration,onComplete,onUpdate,isLooped,useRealTime,autoDestroyOwner) end
--[[
	@timer CS.Timer
--]]
function CS.Timer:Cancel(timer) end
--[[
	@timer CS.Timer
--]]
function CS.Timer:Pause(timer) end
--[[
	@timer CS.Timer
--]]
function CS.Timer:Resume(timer) end
function CS.Timer:CancelAllRegisteredTimers() end
function CS.Timer:Cancel() end
function CS.Timer:Pause() end
function CS.Timer:Resume() end
function CS.Timer:GetTimeElapsed() end
function CS.Timer:GetTimeRemaining() end
function CS.Timer:GetRatioComplete() end
function CS.Timer:GetRatioRemaining() end

--@SuperType [luaIde#CS.System.Object]
CS.Tutorial.BaseClass = {}
--[[
	@return [luaIde#CS.Tutorial.BaseClass]
]]
function CS.Tutorial.BaseClass() end
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.Tutorial.BaseClass.BMF = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.Tutorial.BaseClass.BSF = nil
function CS.Tutorial.BaseClass:BSFunc() end
function CS.Tutorial.BaseClass:BMFunc() end

--@SuperType [luaIde#CS.System.Enum]
CS.Tutorial.TestEnum = {}
--[[
	CS.Tutorial.TestEnum
	 Get 	 Set 
--]]
CS.Tutorial.TestEnum.E1 = 0
--[[
	CS.Tutorial.TestEnum
	 Get 	 Set 
--]]
CS.Tutorial.TestEnum.E2 = 1

--@SuperType [luaIde#CS.Tutorial.BaseClass]
CS.Tutorial.DerivedClass = {}
--[[
	@return [luaIde#CS.Tutorial.DerivedClass]
]]
function CS.Tutorial.DerivedClass() end
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.Tutorial.DerivedClass.DMF = nil
--[[
	CS.System.Action`1{{System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	 Get 	 Set 
--]]
CS.Tutorial.DerivedClass.TestDelegate = nil
function CS.Tutorial.DerivedClass:DMFunc() end
--[[
	@p1 CS.Tutorial.Param1
	@p2 CS.System.Int32&
	@p3 CS.System.String&
	@luafunc CS.System.Action
	@csfunc CS.System.Action&
	return CS.System.Double
--]]
function CS.Tutorial.DerivedClass:ComplexFunc(p1,p2,p3,luafunc,csfunc) end
--[[
	@i CS.System.Int32
--]]
function CS.Tutorial.DerivedClass:TestFunc(i) end
--[[
	@i CS.System.String
--]]
function CS.Tutorial.DerivedClass:TestFunc(i) end
--[[
	@a CS.Tutorial.DerivedClass
	@b CS.Tutorial.DerivedClass
	@return [luaIde#CS.Tutorial.DerivedClass]
--]]
function CS.Tutorial.DerivedClass:op_Addition(a,b) end
--[[
	@a CS.System.Int32
	@b CS.System.String
	@c CS.System.String
--]]
function CS.Tutorial.DerivedClass:DefaultValueFunc(a,b,c) end
--[[
	@a CS.System.Int32
	@strs CS.System.String{}
--]]
function CS.Tutorial.DerivedClass:VariableParamsFunc(a,strs) end
--[[
	@e CS.Tutorial.TestEnum
	return CS.Tutorial.TestEnum
--]]
function CS.Tutorial.DerivedClass:EnumTestFunc(e) end
--[[
	@value CS.System.Action
--]]
function CS.Tutorial.DerivedClass:add_TestEvent(value) end
--[[
	@value CS.System.Action
--]]
function CS.Tutorial.DerivedClass:remove_TestEvent(value) end
function CS.Tutorial.DerivedClass:CallEvent() end
--[[
	@n CS.System.Int64
	return CS.System.UInt64
--]]
function CS.Tutorial.DerivedClass:TestLong(n) end
function CS.Tutorial.DerivedClass:GetCalc() end

CS.Tutorial.ICalc = {}
--[[
	@a CS.System.Int32
	@b CS.System.Int32
	return CS.System.Int32
--]]
function CS.Tutorial.ICalc:add(a,b) end

--@SuperType [luaIde#CS.System.Object]
CS.Tutorial.DerivedClassExtensions = {}

--@SuperType [luaIde#CS.System.Object]
CS.Util.Listener = {}
--[[
	@RefType [luaIde#CS.Util.Listener]
	 Get 
--]]
CS.Util.Listener.Instance = nil
--[[
	CS.UnityEngine.GameObject
	 Get 	 Set 
--]]
CS.Util.Listener._eventListener = nil
function CS.Util.Listener:Init() end
--[[
	@code CS.System.Int32
	@action CS.Util.Listener.AsyncCall
--]]
function CS.Util.Listener:On(code,action) end
--[[
	@type CS.System.String
	@caller CS.UnityEngine.Object
	@call CS.Util.Listener.AsyncCall
--]]
function CS.Util.Listener:On(type,caller,call) end
--[[
	@code CS.System.Int32
	@o1 CS.System.Object
	@o2 CS.System.Object
	@o3 CS.System.Object
--]]
function CS.Util.Listener:Event(code,o1,o2,o3) end
--[[
	@type CS.System.String
	@code CS.Lib.KeyCode
	@caller CS.UnityEngine.Object
	@callback CS.Util.Listener.Callback
	@once CS.System.Boolean
--]]
function CS.Util.Listener:On(type,code,caller,callback,once) end
--[[
	@type CS.System.String
	@caller CS.UnityEngine.Object
	@predicate CS.Util.Listener.Predicate
	@callback CS.Util.Listener.Callback
	@once CS.System.Boolean
--]]
function CS.Util.Listener:On(type,caller,predicate,callback,once) end
--[[
	@type CS.System.String
	@caller CS.UnityEngine.Object
	@o1 CS.System.Object
	@o2 CS.System.Object
	@o3 CS.System.Object
--]]
function CS.Util.Listener:Event(type,caller,o1,o2,o3) end
--[[
	@type CS.System.String
	@caller CS.UnityEngine.Object
--]]
function CS.Util.Listener:Off(type,caller) end

CS.Util.ILoader = {}
--[[
	@path CS.System.String
	return CS.UnityEngine.Object
--]]
function CS.Util.ILoader:Load(path) end
--[[
	@path CS.System.String
	@type CS.System.Type
	return CS.UnityEngine.Object
--]]
function CS.Util.ILoader:Load(path,type) end
--[[
	@obj CS.UnityEngine.Object
--]]
function CS.Util.ILoader:Unload(obj) end
--[[
	@path CS.System.String
	@text CS.System.String
--]]
function CS.Util.ILoader:Write(path,text) end

--@SuperType [luaIde#CS.System.Object]
CS.Util.Loader = {}
function CS.Util.Loader:Init() end
--[[
	@path CS.System.String
	return CS.UnityEngine.Object
--]]
function CS.Util.Loader:Load(path) end
--[[
	@obj CS.UnityEngine.Object
--]]
function CS.Util.Loader:Unload(obj) end
--[[
	@path CS.System.String
	@text CS.System.String
--]]
function CS.Util.Loader:Write(path,text) end
--[[
	@path CS.System.String
	return CS.System.String
--]]
function CS.Util.Loader:Read(path) end

--@SuperType [luaIde#CS.System.Object]
CS.Util.ModelDialog = {}
--[[
	@return [luaIde#CS.Util.ModelDialog]
]]
function CS.Util.ModelDialog() end
--[[
	@text CS.System.String
	@okText CS.System.String
	@cancelText CS.System.String
	@okCallback CS.Util.ModelDialog.ButtonCallback
	@cancelCallback CS.Util.ModelDialog.ButtonCallback
	@return [luaIde#CS.Util.ModelDialog]
]]
function CS.Util.ModelDialog(text,okText,cancelText,okCallback,cancelCallback) end
--[[
	@value CS.Util.ModelDialog.ButtonCallback
--]]
function CS.Util.ModelDialog:add_OkBtnCallback(value) end
--[[
	@value CS.Util.ModelDialog.ButtonCallback
--]]
function CS.Util.ModelDialog:remove_OkBtnCallback(value) end
--[[
	@value CS.Util.ModelDialog.ButtonCallback
--]]
function CS.Util.ModelDialog:add_CancelBtnCallback(value) end
--[[
	@value CS.Util.ModelDialog.ButtonCallback
--]]
function CS.Util.ModelDialog:remove_CancelBtnCallback(value) end
--[[
	@text CS.System.String
--]]
function CS.Util.ModelDialog:SetText(text) end
--[[
	@text CS.System.String
--]]
function CS.Util.ModelDialog:SetOkText(text) end
--[[
	@text CS.System.String
--]]
function CS.Util.ModelDialog:SetCancelText(text) end
function CS.Util.ModelDialog:ShowDialog() end

--@SuperType [luaIde#CS.System.Object]
CS.Util.Pool = {}
--[[
	@sign CS.System.String
	@pool CS.Util.pool.IPool
--]]
function CS.Util.Pool:AddPool(sign,pool) end
--[[
	@sign CS.System.String
--]]
function CS.Util.Pool:ClearSign(sign) end
--[[
	@sign CS.System.String
	@value CS.System.Object
--]]
function CS.Util.Pool:Store(sign,value) end
function CS.Util.Pool:ClearAll() end
--[[
	@sign CS.System.String
	return CS.UnityEngine.GameObject
--]]
function CS.Util.Pool:GetItem(sign) end
--[[
	@sign CS.System.String
	@function CS.System.Func`1{{UnityEngine.GameObject, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.UnityEngine.GameObject
--]]
function CS.Util.Pool:GetItemByFunc(sign,function) end
function CS.Util.Pool:Init() end

CS.Util.pool.IPool = {}
function CS.Util.pool.IPool:GetItem() end
--[[
	@item CS.UnityEngine.GameObject
--]]
function CS.Util.pool.IPool:AddItem(item) end
function CS.Util.pool.IPool:Count() end
function CS.Util.pool.IPool:Create() end
--[[
	@go CS.UnityEngine.GameObject
--]]
function CS.Util.pool.IPool:Destroy(go) end
function CS.Util.pool.IPool:Clear() end

--@SuperType [luaIde#CS.System.Object]
CS.Util.pool.DefaultPool = {}
--[[
	@return [luaIde#CS.Util.pool.DefaultPool]
]]
function CS.Util.pool.DefaultPool() end
function CS.Util.pool.DefaultPool:GetItem() end
--[[
	@item CS.UnityEngine.GameObject
--]]
function CS.Util.pool.DefaultPool:AddItem(item) end
function CS.Util.pool.DefaultPool:Count() end
function CS.Util.pool.DefaultPool:Create() end
--[[
	@go CS.UnityEngine.GameObject
--]]
function CS.Util.pool.DefaultPool:Destroy(go) end
function CS.Util.pool.DefaultPool:Clear() end

--@SuperType [luaIde#CS.System.Object]
CS.Util.pool.GameObjectPool = {}
--[[
	@return [luaIde#CS.Util.pool.GameObjectPool]
]]
function CS.Util.pool.GameObjectPool() end
--[[
	@creator CS.Util.pool.GameObjectPool.Creator
	@deleter CS.Util.pool.GameObjectPool.Operator
	@getter CS.Util.pool.GameObjectPool.Operator
	@setter CS.Util.pool.GameObjectPool.Operator
	@return [luaIde#CS.Util.pool.IPool]
--]]
function CS.Util.pool.GameObjectPool:CreatePool(creator,deleter,getter,setter) end
function CS.Util.pool.GameObjectPool:GetItem() end
--[[
	@item CS.UnityEngine.GameObject
--]]
function CS.Util.pool.GameObjectPool:AddItem(item) end
function CS.Util.pool.GameObjectPool:Count() end
function CS.Util.pool.GameObjectPool:Create() end
--[[
	@go CS.UnityEngine.GameObject
--]]
function CS.Util.pool.GameObjectPool:Destroy(go) end
function CS.Util.pool.GameObjectPool:Clear() end

--@SuperType [luaIde#CS.UnityEngine.MonoBehaviour]
CS.Scene.SettingScene.VoicePanel = {}
--[[
	@return [luaIde#CS.Scene.SettingScene.VoicePanel]
]]
function CS.Scene.SettingScene.VoicePanel() end
--[[
	CS.UnityEngine.UI.Text
	 Get 	 Set 
--]]
CS.Scene.SettingScene.VoicePanel.voice = nil
--[[
	CS.UnityEngine.UI.Slider
	 Get 	 Set 
--]]
CS.Scene.SettingScene.VoicePanel.slider = nil
--[[
	CS.UnityEngine.UI.Toggle
	 Get 	 Set 
--]]
CS.Scene.SettingScene.VoicePanel.checker = nil

--@SuperType [luaIde#CS.System.Object]
CS.Net.NetHelper = {}
function CS.Net.NetHelper:GetInstance() end
function CS.Net.NetHelper:Init() end
--[[
	@msg CS.Msg
--]]
function CS.Net.NetHelper:ReceiveMsg(msg) end
--[[
	@username CS.System.String
	@userpwd CS.System.String
	@callName CS.System.String
--]]
function CS.Net.NetHelper:Login(username,userpwd,callName) end
function CS.Net.NetHelper:Logout() end
function CS.Net.NetHelper:DrawCard() end
function CS.Net.NetHelper:Draw() end
function CS.Net.NetHelper:Connect() end
function CS.Net.NetHelper:Disconnect() end
function CS.Net.NetHelper:Update() end
--[[
	@version CS.System.String
	return CS.System.Boolean
--]]
function CS.Net.NetHelper:CheckVersion(version) end

--@SuperType [luaIde#CS.System.Object]
CS.Manager.Animation = {}
--[[
	@paths CS.System.String{}
	@interval CS.System.Single
	@id CS.System.Int32&
	@loop CS.System.Int32
	@delay CS.System.Single
	@callback CS.System.Action
	return CS.UnityEngine.GameObject
--]]
function CS.Manager.Animation:Play(paths,interval,id,loop,delay,callback) end
--[[
	@path CS.System.String
	@interval CS.System.Single
	@start CS.System.Int32
	@end_ CS.System.Int32
	@id CS.System.Int32&
	@loop CS.System.Int32
	@delay CS.System.Single
	@callback CS.System.Action
	return CS.UnityEngine.GameObject
--]]
function CS.Manager.Animation:Play(path,interval,start,end_,id,loop,delay,callback) end
--[[
	@path CS.System.String
	@interval CS.System.Single
	@id CS.System.Int32&
	@loop CS.System.Int32
	@delay CS.System.Single
	@callback CS.System.Action
	return CS.UnityEngine.GameObject
--]]
function CS.Manager.Animation:Play(path,interval,id,loop,delay,callback) end
--[[
	@id CS.System.Int32
	@index CS.System.Int32
--]]
function CS.Manager.Animation:PauseTo(id,index) end
--[[
	@id CS.System.Int32
--]]
function CS.Manager.Animation:Stop(id) end
--[[
	@id CS.System.Int32
--]]
function CS.Manager.Animation:Continue(id) end

--@SuperType [luaIde#CS.System.Enum]
CS.Lib.KeyCode = {}
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.None = 0
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Backspace = 8
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Tab = 9
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Clear = 12
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Return = 13
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Pause = 19
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Escape = 27
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Space = 32
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Exclaim = 33
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.DoubleQuote = 34
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Hash = 35
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Dollar = 36
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Percent = 37
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Ampersand = 38
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Quote = 39
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftParen = 40
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightParen = 41
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Asterisk = 42
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Plus = 43
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Comma = 44
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Minus = 45
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Period = 46
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Slash = 47
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha0 = 48
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha1 = 49
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha2 = 50
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha3 = 51
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha4 = 52
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha5 = 53
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha6 = 54
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha7 = 55
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha8 = 56
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Alpha9 = 57
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Colon = 58
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Semicolon = 59
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Less = 60
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Equals = 61
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Greater = 62
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Question = 63
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.At = 64
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftBracket = 91
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Backslash = 92
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightBracket = 93
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Caret = 94
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Underscore = 95
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.BackQuote = 96
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.A = 97
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.B = 98
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.C = 99
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.D = 100
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.E = 101
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F = 102
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.G = 103
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.H = 104
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.I = 105
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.J = 106
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.K = 107
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.L = 108
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.M = 109
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.N = 110
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.O = 111
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.P = 112
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Q = 113
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.R = 114
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.S = 115
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.T = 116
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.U = 117
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.V = 118
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.W = 119
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.X = 120
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Y = 121
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Z = 122
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftCurlyBracket = 123
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Pipe = 124
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightCurlyBracket = 125
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Tilde = 126
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Delete = 127
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad0 = 256
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad1 = 257
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad2 = 258
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad3 = 259
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad4 = 260
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad5 = 261
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad6 = 262
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad7 = 263
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad8 = 264
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Keypad9 = 265
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadPeriod = 266
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadDivide = 267
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadMultiply = 268
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadMinus = 269
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadPlus = 270
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadEnter = 271
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.KeypadEquals = 272
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.UpArrow = 273
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.DownArrow = 274
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightArrow = 275
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftArrow = 276
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Insert = 277
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Home = 278
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.End = 279
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.PageUp = 280
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.PageDown = 281
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F1 = 282
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F2 = 283
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F3 = 284
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F4 = 285
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F5 = 286
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F6 = 287
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F7 = 288
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F8 = 289
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F9 = 290
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F10 = 291
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F11 = 292
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F12 = 293
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F13 = 294
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F14 = 295
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.F15 = 296
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Numlock = 300
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.CapsLock = 301
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.ScrollLock = 302
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightShift = 303
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftShift = 304
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightControl = 305
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftControl = 306
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightAlt = 307
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftAlt = 308
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightApple = 309
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightCommand = 309
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftApple = 310
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftCommand = 310
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.LeftWindows = 311
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.RightWindows = 312
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.AltGr = 313
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Help = 315
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Print = 316
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.SysReq = 317
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Break = 318
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Menu = 319
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse0 = 323
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse1 = 324
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse2 = 325
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse3 = 326
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse4 = 327
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse5 = 328
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Mouse6 = 329
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton0 = 330
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton1 = 331
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton2 = 332
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton3 = 333
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton4 = 334
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton5 = 335
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton6 = 336
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton7 = 337
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton8 = 338
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton9 = 339
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton10 = 340
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton11 = 341
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton12 = 342
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton13 = 343
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton14 = 344
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton15 = 345
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton16 = 346
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton17 = 347
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton18 = 348
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.JoystickButton19 = 349
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button0 = 350
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button1 = 351
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button2 = 352
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button3 = 353
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button4 = 354
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button5 = 355
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button6 = 356
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button7 = 357
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button8 = 358
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button9 = 359
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button10 = 360
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button11 = 361
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button12 = 362
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button13 = 363
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button14 = 364
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button15 = 365
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button16 = 366
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button17 = 367
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button18 = 368
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick1Button19 = 369
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button0 = 370
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button1 = 371
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button2 = 372
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button3 = 373
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button4 = 374
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button5 = 375
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button6 = 376
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button7 = 377
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button8 = 378
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button9 = 379
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button10 = 380
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button11 = 381
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button12 = 382
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button13 = 383
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button14 = 384
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button15 = 385
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button16 = 386
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button17 = 387
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button18 = 388
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick2Button19 = 389
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button0 = 390
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button1 = 391
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button2 = 392
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button3 = 393
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button4 = 394
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button5 = 395
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button6 = 396
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button7 = 397
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button8 = 398
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button9 = 399
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button10 = 400
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button11 = 401
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button12 = 402
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button13 = 403
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button14 = 404
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button15 = 405
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button16 = 406
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button17 = 407
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button18 = 408
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick3Button19 = 409
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button0 = 410
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button1 = 411
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button2 = 412
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button3 = 413
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button4 = 414
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button5 = 415
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button6 = 416
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button7 = 417
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button8 = 418
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button9 = 419
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button10 = 420
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button11 = 421
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button12 = 422
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button13 = 423
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button14 = 424
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button15 = 425
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button16 = 426
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button17 = 427
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button18 = 428
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick4Button19 = 429
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button0 = 430
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button1 = 431
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button2 = 432
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button3 = 433
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button4 = 434
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button5 = 435
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button6 = 436
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button7 = 437
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button8 = 438
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button9 = 439
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button10 = 440
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button11 = 441
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button12 = 442
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button13 = 443
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button14 = 444
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button15 = 445
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button16 = 446
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button17 = 447
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button18 = 448
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick5Button19 = 449
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button0 = 450
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button1 = 451
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button2 = 452
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button3 = 453
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button4 = 454
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button5 = 455
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button6 = 456
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button7 = 457
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button8 = 458
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button9 = 459
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button10 = 460
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button11 = 461
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button12 = 462
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button13 = 463
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button14 = 464
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button15 = 465
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button16 = 466
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button17 = 467
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button18 = 468
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick6Button19 = 469
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button0 = 470
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button1 = 471
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button2 = 472
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button3 = 473
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button4 = 474
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button5 = 475
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button6 = 476
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button7 = 477
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button8 = 478
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button9 = 479
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button10 = 480
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button11 = 481
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button12 = 482
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button13 = 483
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button14 = 484
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button15 = 485
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button16 = 486
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button17 = 487
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button18 = 488
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick7Button19 = 489
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button0 = 490
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button1 = 491
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button2 = 492
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button3 = 493
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button4 = 494
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button5 = 495
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button6 = 496
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button7 = 497
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button8 = 498
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button9 = 499
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button10 = 500
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button11 = 501
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button12 = 502
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button13 = 503
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button14 = 504
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button15 = 505
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button16 = 506
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button17 = 507
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button18 = 508
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.Joystick8Button19 = 509
--[[
	CS.Lib.KeyCode
	 Get 	 Set 
--]]
CS.Lib.KeyCode.AnyKey = 2000

CS.Game.IBuff = {}
function CS.Game.IBuff:GetName() end
function CS.Game.IBuff:GetId() end
function CS.Game.IBuff:LastTime() end
function CS.Game.IBuff:RestTime() end

CS.Game.ICard = {}

CS.Game.IPlayer = {}
function CS.Game.IPlayer:GetName() end
function CS.Game.IPlayer:GetId() end
function CS.Game.IPlayer:GetUserName() end

CS.Game.ISkill = {}
function CS.Game.ISkill:GetName() end
function CS.Game.ISkill:GetId() end
function CS.Game.ISkill:Execute() end
--[[
	@card CS.Game.ICard
	@return [luaIde#CS.Game.ISkill]
--]]
function CS.Game.ISkill:BindTarget(card) end

--@SuperType [luaIde#CS.System.Enum]
CS.Tutorial.DerivedClass.TestEnumInner = {}
--[[
	CS.Tutorial.DerivedClass.TestEnumInner
	 Get 	 Set 
--]]
CS.Tutorial.DerivedClass.TestEnumInner.E3 = 0
--[[
	CS.Tutorial.DerivedClass.TestEnumInner
	 Get 	 Set 
--]]
CS.Tutorial.DerivedClass.TestEnumInner.E4 = 1

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.AutoPlay = {}
--[[
	CS.DG.Tweening.AutoPlay
	 Get 	 Set 
--]]
CS.DG.Tweening.AutoPlay.None = 0
--[[
	CS.DG.Tweening.AutoPlay
	 Get 	 Set 
--]]
CS.DG.Tweening.AutoPlay.AutoPlaySequences = 1
--[[
	CS.DG.Tweening.AutoPlay
	 Get 	 Set 
--]]
CS.DG.Tweening.AutoPlay.AutoPlayTweeners = 2
--[[
	CS.DG.Tweening.AutoPlay
	 Get 	 Set 
--]]
CS.DG.Tweening.AutoPlay.All = 3

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.AxisConstraint = {}
--[[
	CS.DG.Tweening.AxisConstraint
	 Get 	 Set 
--]]
CS.DG.Tweening.AxisConstraint.None = 0
--[[
	CS.DG.Tweening.AxisConstraint
	 Get 	 Set 
--]]
CS.DG.Tweening.AxisConstraint.X = 2
--[[
	CS.DG.Tweening.AxisConstraint
	 Get 	 Set 
--]]
CS.DG.Tweening.AxisConstraint.Y = 4
--[[
	CS.DG.Tweening.AxisConstraint
	 Get 	 Set 
--]]
CS.DG.Tweening.AxisConstraint.Z = 8
--[[
	CS.DG.Tweening.AxisConstraint
	 Get 	 Set 
--]]
CS.DG.Tweening.AxisConstraint.W = 16

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.Ease = {}
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.Unset = 0
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.Linear = 1
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InSine = 2
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutSine = 3
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutSine = 4
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InQuad = 5
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutQuad = 6
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutQuad = 7
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InCubic = 8
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutCubic = 9
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutCubic = 10
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InQuart = 11
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutQuart = 12
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutQuart = 13
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InQuint = 14
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutQuint = 15
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutQuint = 16
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InExpo = 17
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutExpo = 18
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutExpo = 19
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InCirc = 20
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutCirc = 21
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutCirc = 22
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InElastic = 23
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutElastic = 24
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutElastic = 25
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InBack = 26
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutBack = 27
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutBack = 28
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InBounce = 29
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutBounce = 30
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutBounce = 31
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.Flash = 32
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InFlash = 33
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.OutFlash = 34
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.InOutFlash = 35
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.INTERNAL_Zero = 36
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.Ease.INTERNAL_Custom = 37

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.LogBehaviour = {}
--[[
	CS.DG.Tweening.LogBehaviour
	 Get 	 Set 
--]]
CS.DG.Tweening.LogBehaviour.Default = 0
--[[
	CS.DG.Tweening.LogBehaviour
	 Get 	 Set 
--]]
CS.DG.Tweening.LogBehaviour.Verbose = 1
--[[
	CS.DG.Tweening.LogBehaviour
	 Get 	 Set 
--]]
CS.DG.Tweening.LogBehaviour.ErrorsOnly = 2

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.LoopType = {}
--[[
	CS.DG.Tweening.LoopType
	 Get 	 Set 
--]]
CS.DG.Tweening.LoopType.Restart = 0
--[[
	CS.DG.Tweening.LoopType
	 Get 	 Set 
--]]
CS.DG.Tweening.LoopType.Yoyo = 1
--[[
	CS.DG.Tweening.LoopType
	 Get 	 Set 
--]]
CS.DG.Tweening.LoopType.Incremental = 2

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.PathMode = {}
--[[
	CS.DG.Tweening.PathMode
	 Get 	 Set 
--]]
CS.DG.Tweening.PathMode.Ignore = 0
--[[
	CS.DG.Tweening.PathMode
	 Get 	 Set 
--]]
CS.DG.Tweening.PathMode.Full3D = 1
--[[
	CS.DG.Tweening.PathMode
	 Get 	 Set 
--]]
CS.DG.Tweening.PathMode.TopDown2D = 2
--[[
	CS.DG.Tweening.PathMode
	 Get 	 Set 
--]]
CS.DG.Tweening.PathMode.Sidescroller2D = 3

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.PathType = {}
--[[
	CS.DG.Tweening.PathType
	 Get 	 Set 
--]]
CS.DG.Tweening.PathType.Linear = 0
--[[
	CS.DG.Tweening.PathType
	 Get 	 Set 
--]]
CS.DG.Tweening.PathType.CatmullRom = 1
--[[
	CS.DG.Tweening.PathType
	 Get 	 Set 
--]]
CS.DG.Tweening.PathType.CubicBezier = 2

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.RotateMode = {}
--[[
	CS.DG.Tweening.RotateMode
	 Get 	 Set 
--]]
CS.DG.Tweening.RotateMode.Fast = 0
--[[
	CS.DG.Tweening.RotateMode
	 Get 	 Set 
--]]
CS.DG.Tweening.RotateMode.FastBeyond360 = 1
--[[
	CS.DG.Tweening.RotateMode
	 Get 	 Set 
--]]
CS.DG.Tweening.RotateMode.WorldAxisAdd = 2
--[[
	CS.DG.Tweening.RotateMode
	 Get 	 Set 
--]]
CS.DG.Tweening.RotateMode.LocalAxisAdd = 3

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.ScrambleMode = {}
--[[
	CS.DG.Tweening.ScrambleMode
	 Get 	 Set 
--]]
CS.DG.Tweening.ScrambleMode.None = 0
--[[
	CS.DG.Tweening.ScrambleMode
	 Get 	 Set 
--]]
CS.DG.Tweening.ScrambleMode.All = 1
--[[
	CS.DG.Tweening.ScrambleMode
	 Get 	 Set 
--]]
CS.DG.Tweening.ScrambleMode.Uppercase = 2
--[[
	CS.DG.Tweening.ScrambleMode
	 Get 	 Set 
--]]
CS.DG.Tweening.ScrambleMode.Lowercase = 3
--[[
	CS.DG.Tweening.ScrambleMode
	 Get 	 Set 
--]]
CS.DG.Tweening.ScrambleMode.Numerals = 4
--[[
	CS.DG.Tweening.ScrambleMode
	 Get 	 Set 
--]]
CS.DG.Tweening.ScrambleMode.Custom = 5

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.TweenType = {}
--[[
	CS.DG.Tweening.TweenType
	 Get 	 Set 
--]]
CS.DG.Tweening.TweenType.Tweener = 0
--[[
	CS.DG.Tweening.TweenType
	 Get 	 Set 
--]]
CS.DG.Tweening.TweenType.Sequence = 1
--[[
	CS.DG.Tweening.TweenType
	 Get 	 Set 
--]]
CS.DG.Tweening.TweenType.Callback = 2

--@SuperType [luaIde#CS.System.Enum]
CS.DG.Tweening.UpdateType = {}
--[[
	CS.DG.Tweening.UpdateType
	 Get 	 Set 
--]]
CS.DG.Tweening.UpdateType.Normal = 0
--[[
	CS.DG.Tweening.UpdateType
	 Get 	 Set 
--]]
CS.DG.Tweening.UpdateType.Late = 1
--[[
	CS.DG.Tweening.UpdateType
	 Get 	 Set 
--]]
CS.DG.Tweening.UpdateType.Fixed = 2
--[[
	CS.DG.Tweening.UpdateType
	 Get 	 Set 
--]]
CS.DG.Tweening.UpdateType.Manual = 3

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.DOTweenModuleUI = {}

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.DOTween = {}
--[[
	@return [luaIde#CS.DG.Tweening.DOTween]
]]
function CS.DG.Tweening.DOTween() end
--[[
	CS.DG.Tweening.LogBehaviour
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.logBehaviour = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.Version = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.useSafeMode = nil
--[[
	CS.DG.Tweening.Core.Enums.NestedTweenFailureBehaviour
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.nestedTweenFailureBehaviour = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.showUnityEditorReport = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.timeScale = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.useSmoothDeltaTime = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.maxSmoothUnscaledTime = nil
--[[
	CS.System.Func`3{{UnityEngine.LogType, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.onWillLog = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.drawGizmos = nil
--[[
	CS.DG.Tweening.UpdateType
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultUpdateType = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultTimeScaleIndependent = nil
--[[
	CS.DG.Tweening.AutoPlay
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultAutoPlay = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultAutoKill = nil
--[[
	CS.DG.Tweening.LoopType
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultLoopType = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultRecyclable = nil
--[[
	CS.DG.Tweening.Ease
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultEaseType = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultEaseOvershootOrAmplitude = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.defaultEasePeriod = nil
--[[
	CS.DG.Tweening.Core.DOTweenComponent
	 Get 	 Set 
--]]
CS.DG.Tweening.DOTween.instance = nil
--[[
	@recycleAllByDefault CS.System.Nullable`1{{System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@useSafeMode CS.System.Nullable`1{{System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@logBehaviour CS.System.Nullable`1{{DG.Tweening.LogBehaviour, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.DG.Tweening.IDOTweenInit
--]]
function CS.DG.Tweening.DOTween:Init(recycleAllByDefault,useSafeMode,logBehaviour) end
--[[
	@tweenersCapacity CS.System.Int32
	@sequencesCapacity CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:SetTweensCapacity(tweenersCapacity,sequencesCapacity) end
--[[
	@destroy CS.System.Boolean
--]]
function CS.DG.Tweening.DOTween:Clear(destroy) end
function CS.DG.Tweening.DOTween:ClearCachedTweens() end
function CS.DG.Tweening.DOTween:Validate() end
--[[
	@deltaTime CS.System.Single
	@unscaledDeltaTime CS.System.Single
--]]
function CS.DG.Tweening.DOTween:ManualUpdate(deltaTime,unscaledDeltaTime) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.Single
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.FloatOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.Double
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.NoOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.Int32
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.NoOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.UInt32
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.UintOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.Int64
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.NoOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.UInt64
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.NoOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@endValue CS.System.String
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089},{DG.Tweening.Plugins.Options.StringOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector2, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector2, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.Vector2
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector2, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector2, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.Vector3
	@duration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}]
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector4, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector4, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.Vector4
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector4, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector4, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Quaternion, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Quaternion, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.Vector3
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Quaternion, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.QuaternionOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.Color
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Rect, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Rect, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.Rect
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Rect, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Rect, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.RectOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.RectOffset, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.RectOffset, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.UnityEngine.RectOffset
	@duration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.DOTween:To(getter,setter,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.System.Single
	@duration CS.System.Single
	@axisConstraint CS.DG.Tweening.AxisConstraint
	@return [luaIde#CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}]
--]]
function CS.DG.Tweening.DOTween:ToAxis(getter,setter,endValue,duration,axisConstraint) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValue CS.System.Single
	@duration CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Color, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.ColorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:ToAlpha(getter,setter,endValue,duration) end
--[[
	@setter CS.DG.Tweening.Core.DOSetter`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@startValue CS.System.Single
	@endValue CS.System.Single
	@duration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.DOTween:To(setter,startValue,endValue,duration) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@direction CS.UnityEngine.Vector3
	@duration CS.System.Single
	@vibrato CS.System.Int32
	@elasticity CS.System.Single
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3{}, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.Vector3ArrayOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:Punch(getter,setter,direction,duration,vibrato,elasticity) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@duration CS.System.Single
	@strength CS.System.Single
	@vibrato CS.System.Int32
	@randomness CS.System.Single
	@ignoreZAxis CS.System.Boolean
	@fadeOut CS.System.Boolean
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3{}, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.Vector3ArrayOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:Shake(getter,setter,duration,strength,vibrato,randomness,ignoreZAxis,fadeOut) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@duration CS.System.Single
	@strength CS.UnityEngine.Vector3
	@vibrato CS.System.Int32
	@randomness CS.System.Single
	@fadeOut CS.System.Boolean
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3{}, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.Vector3ArrayOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:Shake(getter,setter,duration,strength,vibrato,randomness,fadeOut) end
--[[
	@getter CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@setter CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@endValues CS.UnityEngine.Vector3{}
	@durations CS.System.Single{}
	return CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3{}, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.Vector3ArrayOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:ToArray(getter,setter,endValues,durations) end
function CS.DG.Tweening.DOTween:Sequence() end
--[[
	@withCallbacks CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:CompleteAll(withCallbacks) end
--[[
	@targetOrId CS.System.Object
	@withCallbacks CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Complete(targetOrId,withCallbacks) end
function CS.DG.Tweening.DOTween:FlipAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Flip(targetOrId) end
--[[
	@to CS.System.Single
	@andPlay CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:GotoAll(to,andPlay) end
--[[
	@targetOrId CS.System.Object
	@to CS.System.Single
	@andPlay CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Goto(targetOrId,to,andPlay) end
--[[
	@complete CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:KillAll(complete) end
--[[
	@complete CS.System.Boolean
	@idsOrTargetsToExclude CS.System.Object{}
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:KillAll(complete,idsOrTargetsToExclude) end
--[[
	@targetOrId CS.System.Object
	@complete CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Kill(targetOrId,complete) end
function CS.DG.Tweening.DOTween:PauseAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Pause(targetOrId) end
function CS.DG.Tweening.DOTween:PlayAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Play(targetOrId) end
--[[
	@target CS.System.Object
	@id CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Play(target,id) end
function CS.DG.Tweening.DOTween:PlayBackwardsAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:PlayBackwards(targetOrId) end
--[[
	@target CS.System.Object
	@id CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:PlayBackwards(target,id) end
function CS.DG.Tweening.DOTween:PlayForwardAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:PlayForward(targetOrId) end
--[[
	@target CS.System.Object
	@id CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:PlayForward(target,id) end
--[[
	@includeDelay CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:RestartAll(includeDelay) end
--[[
	@targetOrId CS.System.Object
	@includeDelay CS.System.Boolean
	@changeDelayTo CS.System.Single
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Restart(targetOrId,includeDelay,changeDelayTo) end
--[[
	@target CS.System.Object
	@id CS.System.Object
	@includeDelay CS.System.Boolean
	@changeDelayTo CS.System.Single
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Restart(target,id,includeDelay,changeDelayTo) end
--[[
	@includeDelay CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:RewindAll(includeDelay) end
--[[
	@targetOrId CS.System.Object
	@includeDelay CS.System.Boolean
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:Rewind(targetOrId,includeDelay) end
function CS.DG.Tweening.DOTween:SmoothRewindAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:SmoothRewind(targetOrId) end
function CS.DG.Tweening.DOTween:TogglePauseAll() end
--[[
	@targetOrId CS.System.Object
	return CS.System.Int32
--]]
function CS.DG.Tweening.DOTween:TogglePause(targetOrId) end
--[[
	@targetOrId CS.System.Object
	@alsoCheckIfIsPlaying CS.System.Boolean
	return CS.System.Boolean
--]]
function CS.DG.Tweening.DOTween:IsTweening(targetOrId,alsoCheckIfIsPlaying) end
function CS.DG.Tweening.DOTween:TotalPlayingTweens() end
--[[
	@fillableList CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:PlayingTweens(fillableList) end
--[[
	@fillableList CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:PausedTweens(fillableList) end
--[[
	@id CS.System.Object
	@playingOnly CS.System.Boolean
	@fillableList CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:TweensById(id,playingOnly,fillableList) end
--[[
	@target CS.System.Object
	@playingOnly CS.System.Boolean
	@fillableList CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.System.Collections.Generic.List`1{{DG.Tweening.Tween, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.DG.Tweening.DOTween:TweensByTarget(target,playingOnly,fillableList) end

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.DOVirtual = {}
--[[
	@from CS.System.Single
	@to CS.System.Single
	@duration CS.System.Single
	@onVirtualUpdate CS.DG.Tweening.TweenCallback`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.DOVirtual:Float(from,to,duration,onVirtualUpdate) end
--[[
	@from CS.System.Single
	@to CS.System.Single
	@lifetimePercentage CS.System.Single
	@easeType CS.DG.Tweening.Ease
	return CS.System.Single
--]]
function CS.DG.Tweening.DOVirtual:EasedValue(from,to,lifetimePercentage,easeType) end
--[[
	@from CS.System.Single
	@to CS.System.Single
	@lifetimePercentage CS.System.Single
	@easeType CS.DG.Tweening.Ease
	@overshoot CS.System.Single
	return CS.System.Single
--]]
function CS.DG.Tweening.DOVirtual:EasedValue(from,to,lifetimePercentage,easeType,overshoot) end
--[[
	@from CS.System.Single
	@to CS.System.Single
	@lifetimePercentage CS.System.Single
	@easeType CS.DG.Tweening.Ease
	@amplitude CS.System.Single
	@period CS.System.Single
	return CS.System.Single
--]]
function CS.DG.Tweening.DOVirtual:EasedValue(from,to,lifetimePercentage,easeType,amplitude,period) end
--[[
	@from CS.System.Single
	@to CS.System.Single
	@lifetimePercentage CS.System.Single
	@easeCurve CS.UnityEngine.AnimationCurve
	return CS.System.Single
--]]
function CS.DG.Tweening.DOVirtual:EasedValue(from,to,lifetimePercentage,easeCurve) end
--[[
	@delay CS.System.Single
	@callback CS.DG.Tweening.TweenCallback
	@ignoreTimeScale CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Tween]
--]]
function CS.DG.Tweening.DOVirtual:DelayedCall(delay,callback,ignoreTimeScale) end

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.EaseFactory = {}
--[[
	@return [luaIde#CS.DG.Tweening.EaseFactory]
]]
function CS.DG.Tweening.EaseFactory() end
--[[
	@motionFps CS.System.Int32
	@ease CS.System.Nullable`1{{DG.Tweening.Ease, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	return CS.DG.Tweening.EaseFunction
--]]
function CS.DG.Tweening.EaseFactory:StopMotion(motionFps,ease) end
--[[
	@motionFps CS.System.Int32
	@animCurve CS.UnityEngine.AnimationCurve
	return CS.DG.Tweening.EaseFunction
--]]
function CS.DG.Tweening.EaseFactory:StopMotion(motionFps,animCurve) end
--[[
	@motionFps CS.System.Int32
	@customEase CS.DG.Tweening.EaseFunction
	return CS.DG.Tweening.EaseFunction
--]]
function CS.DG.Tweening.EaseFactory:StopMotion(motionFps,customEase) end

--@SuperType [luaIde#CS.DG.Tweening.Tween]
CS.DG.Tweening.Tweener = {}
--[[
	@newStartValue CS.System.Object
	@newDuration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Tweener:ChangeStartValue(newStartValue,newDuration) end
--[[
	@newEndValue CS.System.Object
	@newDuration CS.System.Single
	@snapStartValue CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Tweener:ChangeEndValue(newEndValue,newDuration,snapStartValue) end
--[[
	@newEndValue CS.System.Object
	@snapStartValue CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Tweener:ChangeEndValue(newEndValue,snapStartValue) end
--[[
	@newStartValue CS.System.Object
	@newEndValue CS.System.Object
	@newDuration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Tweener:ChangeValues(newStartValue,newEndValue,newDuration) end

--@SuperType [luaIde#CS.DG.Tweening.Core.ABSSequentiable]
CS.DG.Tweening.Tween = {}
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.isRelative = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.active = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.fullPosition = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.playedOnce = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.position = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.timeScale = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.isBackwards = nil
--[[
	CS.System.Object
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.id = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.stringId = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.intId = nil
--[[
	CS.System.Object
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.target = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onPlay = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onPause = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onRewind = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onUpdate = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onStepComplete = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onComplete = nil
--[[
	CS.DG.Tweening.TweenCallback
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onKill = nil
--[[
	CS.DG.Tweening.TweenCallback`1{{System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.onWaypointChange = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.easeOvershootOrAmplitude = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.DG.Tweening.Tween.easePeriod = nil

--@SuperType [luaIde#CS.DG.Tweening.Tween]
CS.DG.Tweening.Sequence = {}

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.TweenParams = {}
--[[
	@return [luaIde#CS.DG.Tweening.TweenParams]
]]
function CS.DG.Tweening.TweenParams() end
--[[
	@RefType [luaIde#CS.DG.Tweening.TweenParams]
	 Get 	 Set 
--]]
CS.DG.Tweening.TweenParams.Params = nil
function CS.DG.Tweening.TweenParams:Clear() end
--[[
	@autoKillOnCompletion CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetAutoKill(autoKillOnCompletion) end
--[[
	@id CS.System.Object
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetId(id) end
--[[
	@target CS.System.Object
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetTarget(target) end
--[[
	@loops CS.System.Int32
	@loopType CS.System.Nullable`1{{DG.Tweening.LoopType, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetLoops(loops,loopType) end
--[[
	@ease CS.DG.Tweening.Ease
	@overshootOrAmplitude CS.System.Nullable`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@period CS.System.Nullable`1{{System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetEase(ease,overshootOrAmplitude,period) end
--[[
	@animCurve CS.UnityEngine.AnimationCurve
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetEase(animCurve) end
--[[
	@customEase CS.DG.Tweening.EaseFunction
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetEase(customEase) end
--[[
	@recyclable CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetRecyclable(recyclable) end
--[[
	@isIndependentUpdate CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetUpdate(isIndependentUpdate) end
--[[
	@updateType CS.DG.Tweening.UpdateType
	@isIndependentUpdate CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetUpdate(updateType,isIndependentUpdate) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnStart(action) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnPlay(action) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnRewind(action) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnUpdate(action) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnStepComplete(action) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnComplete(action) end
--[[
	@action CS.DG.Tweening.TweenCallback
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnKill(action) end
--[[
	@action CS.DG.Tweening.TweenCallback`1{{System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089}}
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:OnWaypointChange(action) end
--[[
	@delay CS.System.Single
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetDelay(delay) end
--[[
	@isRelative CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetRelative(isRelative) end
--[[
	@isSpeedBased CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.TweenParams]
--]]
function CS.DG.Tweening.TweenParams:SetSpeedBased(isSpeedBased) end

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.Core.ABSSequentiable = {}

--@SuperType [luaIde#CS.DG.Tweening.Tweener]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] = {}
--[[
	CS.UnityEngine.Vector3
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].startValue = nil
--[[
	CS.UnityEngine.Vector3
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].endValue = nil
--[[
	CS.UnityEngine.Vector3
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].changeValue = nil
--[[
	CS.DG.Tweening.Plugins.Options.VectorOptions
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].plugOptions = nil
--[[
	CS.DG.Tweening.Core.DOGetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].getter = nil
--[[
	CS.DG.Tweening.Core.DOSetter`1{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].setter = nil
--[[
	@newStartValue CS.System.Object
	@newDuration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeStartValue(newStartValue,newDuration) end
--[[
	@newEndValue CS.System.Object
	@snapStartValue CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeEndValue(newEndValue,snapStartValue) end
--[[
	@newEndValue CS.System.Object
	@newDuration CS.System.Single
	@snapStartValue CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeEndValue(newEndValue,newDuration,snapStartValue) end
--[[
	@newStartValue CS.System.Object
	@newEndValue CS.System.Object
	@newDuration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Tweener]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeValues(newStartValue,newEndValue,newDuration) end
--[[
	@newStartValue CS.UnityEngine.Vector3
	@newDuration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeStartValue(newStartValue,newDuration) end
--[[
	@newEndValue CS.UnityEngine.Vector3
	@snapStartValue CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeEndValue(newEndValue,snapStartValue) end
--[[
	@newEndValue CS.UnityEngine.Vector3
	@newDuration CS.System.Single
	@snapStartValue CS.System.Boolean
	@return [luaIde#CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeEndValue(newEndValue,newDuration,snapStartValue) end
--[[
	@newStartValue CS.UnityEngine.Vector3
	@newEndValue CS.UnityEngine.Vector3
	@newDuration CS.System.Single
	@return [luaIde#CS.DG.Tweening.Core.TweenerCore`3{{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null},{DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}}]
--]]
function CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]:ChangeValues(newStartValue,newEndValue,newDuration) end

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.TweenExtensions = {}

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.TweenSettingsExtensions = {}

--@SuperType [luaIde#CS.System.Object]
CS.DG.Tweening.ShortcutExtensions = {}

