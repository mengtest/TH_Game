--@SuperType [luaIde#CS.System.Object]
CS.Global = {}
--[[
	CS.UnityEngine.SceneManagement.Scene
	 Get 
--]]
CS.Global.Scene = nil
--[[
	@str CS.System.String
	@level CS.Global.Level
--]]
function CS.Global:Log(str,level) end
--[[
	@name CS.System.String
	@return [luaIde#CS.UnityEngine.GameObject]
--]]
function CS.Global:GetRootObject(name) end
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

CS.System.Object = {}
--[[
	@return [luaIde#CS.System.Object]
]]
function CS.System.Object() end
--[[
	@obj CS.System.Object
	return CS.System.Boolean
--]]
function CS.System.Object:Equals(obj) end
--[[
	@objA CS.System.Object
	@objB CS.System.Object
	return CS.System.Boolean
--]]
function CS.System.Object:Equals(objA,objB) end
function CS.System.Object:GetHashCode() end
function CS.System.Object:GetType() end
function CS.System.Object:ToString() end
--[[
	@objA CS.System.Object
	@objB CS.System.Object
	return CS.System.Boolean
--]]
function CS.System.Object:ReferenceEquals(objA,objB) end

--@SuperType [luaIde#CS.System.Object]
CS.UnityEngine.Object = {}
--[[
	@return [luaIde#CS.UnityEngine.Object]
]]
function CS.UnityEngine.Object() end
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.UnityEngine.Object.name = nil
--[[
	CS.UnityEngine.HideFlags
	 Get 	 Set 
--]]
CS.UnityEngine.Object.hideFlags = nil
function CS.UnityEngine.Object:GetInstanceID() end
function CS.UnityEngine.Object:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Object:Equals(other) end
--[[
	@exists CS.UnityEngine.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Object:op_Implicit(exists) end
--[[
	@original CS.UnityEngine.Object
	@position CS.UnityEngine.Vector3
	@rotation CS.UnityEngine.Quaternion
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Object:Instantiate(original,position,rotation) end
--[[
	@original CS.UnityEngine.Object
	@position CS.UnityEngine.Vector3
	@rotation CS.UnityEngine.Quaternion
	@parent CS.UnityEngine.Transform
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Object:Instantiate(original,position,rotation,parent) end
--[[
	@original CS.UnityEngine.Object
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Object:Instantiate(original) end
--[[
	@original CS.UnityEngine.Object
	@parent CS.UnityEngine.Transform
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Object:Instantiate(original,parent) end
--[[
	@original CS.UnityEngine.Object
	@parent CS.UnityEngine.Transform
	@instantiateInWorldSpace CS.System.Boolean
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Object:Instantiate(original,parent,instantiateInWorldSpace) end
--[[
	@obj CS.UnityEngine.Object
	@t CS.System.Single
--]]
function CS.UnityEngine.Object:Destroy(obj,t) end
--[[
	@obj CS.UnityEngine.Object
--]]
function CS.UnityEngine.Object:Destroy(obj) end
--[[
	@obj CS.UnityEngine.Object
	@allowDestroyingAssets CS.System.Boolean
--]]
function CS.UnityEngine.Object:DestroyImmediate(obj,allowDestroyingAssets) end
--[[
	@obj CS.UnityEngine.Object
--]]
function CS.UnityEngine.Object:DestroyImmediate(obj) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Object:FindObjectsOfType(type) end
--[[
	@target CS.UnityEngine.Object
--]]
function CS.UnityEngine.Object:DontDestroyOnLoad(target) end
--[[
	@obj CS.UnityEngine.Object
	@t CS.System.Single
--]]
function CS.UnityEngine.Object:DestroyObject(obj,t) end
--[[
	@obj CS.UnityEngine.Object
--]]
function CS.UnityEngine.Object:DestroyObject(obj) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Object:FindSceneObjectsOfType(type) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Object:FindObjectsOfTypeIncludingAssets(type) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Object:FindObjectsOfTypeAll(type) end
--[[
	@type CS.System.Type
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Object:FindObjectOfType(type) end
function CS.UnityEngine.Object:ToString() end
--[[
	@x CS.UnityEngine.Object
	@y CS.UnityEngine.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Object:op_Equality(x,y) end
--[[
	@x CS.UnityEngine.Object
	@y CS.UnityEngine.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Object:op_Inequality(x,y) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Vector2 = {}
--[[
	@x CS.System.Single
	@y CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
]]
function CS.UnityEngine.Vector2(x,y) end
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.normalized = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Vector2.magnitude = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Vector2.sqrMagnitude = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.zero = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.one = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.up = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.down = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.left = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.right = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.positiveInfinity = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 
--]]
CS.UnityEngine.Vector2.negativeInfinity = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector2.x = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector2.y = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector2.kEpsilon = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector2.kEpsilonNormalSqrt = nil
--[[
	@newX CS.System.Single
	@newY CS.System.Single
--]]
function CS.UnityEngine.Vector2:Set(newX,newY) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:Lerp(a,b,t) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:LerpUnclamped(a,b,t) end
--[[
	@current CS.UnityEngine.Vector2
	@target CS.UnityEngine.Vector2
	@maxDistanceDelta CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:MoveTowards(current,target,maxDistanceDelta) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:Scale(a,b) end
--[[
	@scale CS.UnityEngine.Vector2
--]]
function CS.UnityEngine.Vector2:Scale(scale) end
function CS.UnityEngine.Vector2:Normalize() end
function CS.UnityEngine.Vector2:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Vector2:ToString(format) end
function CS.UnityEngine.Vector2:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector2:Equals(other) end
--[[
	@other CS.UnityEngine.Vector2
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector2:Equals(other) end
--[[
	@inDirection CS.UnityEngine.Vector2
	@inNormal CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:Reflect(inDirection,inNormal) end
--[[
	@inDirection CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:Perpendicular(inDirection) end
--[[
	@lhs CS.UnityEngine.Vector2
	@rhs CS.UnityEngine.Vector2
	return CS.System.Single
--]]
function CS.UnityEngine.Vector2:Dot(lhs,rhs) end
--[[
	@from CS.UnityEngine.Vector2
	@to CS.UnityEngine.Vector2
	return CS.System.Single
--]]
function CS.UnityEngine.Vector2:Angle(from,to) end
--[[
	@from CS.UnityEngine.Vector2
	@to CS.UnityEngine.Vector2
	return CS.System.Single
--]]
function CS.UnityEngine.Vector2:SignedAngle(from,to) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	return CS.System.Single
--]]
function CS.UnityEngine.Vector2:Distance(a,b) end
--[[
	@vector CS.UnityEngine.Vector2
	@maxLength CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:ClampMagnitude(vector,maxLength) end
--[[
	@a CS.UnityEngine.Vector2
	return CS.System.Single
--]]
function CS.UnityEngine.Vector2:SqrMagnitude(a) end
function CS.UnityEngine.Vector2:SqrMagnitude() end
--[[
	@lhs CS.UnityEngine.Vector2
	@rhs CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:Min(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Vector2
	@rhs CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:Max(lhs,rhs) end
--[[
	@current CS.UnityEngine.Vector2
	@target CS.UnityEngine.Vector2
	@currentVelocity CS.UnityEngine.Vector2&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:SmoothDamp(current,target,currentVelocity,smoothTime,maxSpeed) end
--[[
	@current CS.UnityEngine.Vector2
	@target CS.UnityEngine.Vector2
	@currentVelocity CS.UnityEngine.Vector2&
	@smoothTime CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:SmoothDamp(current,target,currentVelocity,smoothTime) end
--[[
	@current CS.UnityEngine.Vector2
	@target CS.UnityEngine.Vector2
	@currentVelocity CS.UnityEngine.Vector2&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	@deltaTime CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:SmoothDamp(current,target,currentVelocity,smoothTime,maxSpeed,deltaTime) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Addition(a,b) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Subtraction(a,b) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Multiply(a,b) end
--[[
	@a CS.UnityEngine.Vector2
	@b CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Division(a,b) end
--[[
	@a CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_UnaryNegation(a) end
--[[
	@a CS.UnityEngine.Vector2
	@d CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Multiply(a,d) end
--[[
	@d CS.System.Single
	@a CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Multiply(d,a) end
--[[
	@a CS.UnityEngine.Vector2
	@d CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Division(a,d) end
--[[
	@lhs CS.UnityEngine.Vector2
	@rhs CS.UnityEngine.Vector2
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector2:op_Equality(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Vector2
	@rhs CS.UnityEngine.Vector2
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector2:op_Inequality(lhs,rhs) end
--[[
	@v CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector2:op_Implicit(v) end
--[[
	@v CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector2:op_Implicit(v) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Vector3 = {}
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
]]
function CS.UnityEngine.Vector3(x,y,z) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
]]
function CS.UnityEngine.Vector3(x,y) end
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.normalized = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Vector3.magnitude = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Vector3.sqrMagnitude = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.zero = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.one = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.forward = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.back = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.up = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.down = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.left = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.right = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.positiveInfinity = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Vector3.negativeInfinity = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector3.kEpsilon = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector3.kEpsilonNormalSqrt = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector3.x = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector3.y = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector3.z = nil
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Slerp(a,b,t) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:SlerpUnclamped(a,b,t) end
--[[
	@normal CS.UnityEngine.Vector3&
	@tangent CS.UnityEngine.Vector3&
--]]
function CS.UnityEngine.Vector3:OrthoNormalize(normal,tangent) end
--[[
	@normal CS.UnityEngine.Vector3&
	@tangent CS.UnityEngine.Vector3&
	@binormal CS.UnityEngine.Vector3&
--]]
function CS.UnityEngine.Vector3:OrthoNormalize(normal,tangent,binormal) end
--[[
	@current CS.UnityEngine.Vector3
	@target CS.UnityEngine.Vector3
	@maxRadiansDelta CS.System.Single
	@maxMagnitudeDelta CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:RotateTowards(current,target,maxRadiansDelta,maxMagnitudeDelta) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Lerp(a,b,t) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:LerpUnclamped(a,b,t) end
--[[
	@current CS.UnityEngine.Vector3
	@target CS.UnityEngine.Vector3
	@maxDistanceDelta CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:MoveTowards(current,target,maxDistanceDelta) end
--[[
	@current CS.UnityEngine.Vector3
	@target CS.UnityEngine.Vector3
	@currentVelocity CS.UnityEngine.Vector3&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:SmoothDamp(current,target,currentVelocity,smoothTime,maxSpeed) end
--[[
	@current CS.UnityEngine.Vector3
	@target CS.UnityEngine.Vector3
	@currentVelocity CS.UnityEngine.Vector3&
	@smoothTime CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:SmoothDamp(current,target,currentVelocity,smoothTime) end
--[[
	@current CS.UnityEngine.Vector3
	@target CS.UnityEngine.Vector3
	@currentVelocity CS.UnityEngine.Vector3&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	@deltaTime CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:SmoothDamp(current,target,currentVelocity,smoothTime,maxSpeed,deltaTime) end
--[[
	@newX CS.System.Single
	@newY CS.System.Single
	@newZ CS.System.Single
--]]
function CS.UnityEngine.Vector3:Set(newX,newY,newZ) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Scale(a,b) end
--[[
	@scale CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Vector3:Scale(scale) end
--[[
	@lhs CS.UnityEngine.Vector3
	@rhs CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Cross(lhs,rhs) end
function CS.UnityEngine.Vector3:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector3:Equals(other) end
--[[
	@other CS.UnityEngine.Vector3
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector3:Equals(other) end
--[[
	@inDirection CS.UnityEngine.Vector3
	@inNormal CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Reflect(inDirection,inNormal) end
--[[
	@value CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Normalize(value) end
function CS.UnityEngine.Vector3:Normalize() end
--[[
	@lhs CS.UnityEngine.Vector3
	@rhs CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:Dot(lhs,rhs) end
--[[
	@vector CS.UnityEngine.Vector3
	@onNormal CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Project(vector,onNormal) end
--[[
	@vector CS.UnityEngine.Vector3
	@planeNormal CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:ProjectOnPlane(vector,planeNormal) end
--[[
	@from CS.UnityEngine.Vector3
	@to CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:Angle(from,to) end
--[[
	@from CS.UnityEngine.Vector3
	@to CS.UnityEngine.Vector3
	@axis CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:SignedAngle(from,to,axis) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:Distance(a,b) end
--[[
	@vector CS.UnityEngine.Vector3
	@maxLength CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:ClampMagnitude(vector,maxLength) end
--[[
	@vector CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:Magnitude(vector) end
--[[
	@vector CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:SqrMagnitude(vector) end
--[[
	@lhs CS.UnityEngine.Vector3
	@rhs CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Min(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Vector3
	@rhs CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Max(lhs,rhs) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:op_Addition(a,b) end
--[[
	@a CS.UnityEngine.Vector3
	@b CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:op_Subtraction(a,b) end
--[[
	@a CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:op_UnaryNegation(a) end
--[[
	@a CS.UnityEngine.Vector3
	@d CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:op_Multiply(a,d) end
--[[
	@d CS.System.Single
	@a CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:op_Multiply(d,a) end
--[[
	@a CS.UnityEngine.Vector3
	@d CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:op_Division(a,d) end
--[[
	@lhs CS.UnityEngine.Vector3
	@rhs CS.UnityEngine.Vector3
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector3:op_Equality(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Vector3
	@rhs CS.UnityEngine.Vector3
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector3:op_Inequality(lhs,rhs) end
function CS.UnityEngine.Vector3:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Vector3:ToString(format) end
--[[
	@from CS.UnityEngine.Vector3
	@to CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Vector3:AngleBetween(from,to) end
--[[
	@excludeThis CS.UnityEngine.Vector3
	@fromThat CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector3:Exclude(excludeThis,fromThat) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Vector4 = {}
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@w CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
]]
function CS.UnityEngine.Vector4(x,y,z,w) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
]]
function CS.UnityEngine.Vector4(x,y,z) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
]]
function CS.UnityEngine.Vector4(x,y) end
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 
--]]
CS.UnityEngine.Vector4.normalized = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Vector4.magnitude = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Vector4.sqrMagnitude = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 
--]]
CS.UnityEngine.Vector4.zero = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 
--]]
CS.UnityEngine.Vector4.one = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 
--]]
CS.UnityEngine.Vector4.positiveInfinity = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 
--]]
CS.UnityEngine.Vector4.negativeInfinity = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector4.kEpsilon = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector4.x = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector4.y = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector4.z = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Vector4.w = nil
--[[
	@newX CS.System.Single
	@newY CS.System.Single
	@newZ CS.System.Single
	@newW CS.System.Single
--]]
function CS.UnityEngine.Vector4:Set(newX,newY,newZ,newW) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:Lerp(a,b,t) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:LerpUnclamped(a,b,t) end
--[[
	@current CS.UnityEngine.Vector4
	@target CS.UnityEngine.Vector4
	@maxDistanceDelta CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:MoveTowards(current,target,maxDistanceDelta) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:Scale(a,b) end
--[[
	@scale CS.UnityEngine.Vector4
--]]
function CS.UnityEngine.Vector4:Scale(scale) end
function CS.UnityEngine.Vector4:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector4:Equals(other) end
--[[
	@other CS.UnityEngine.Vector4
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector4:Equals(other) end
--[[
	@a CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:Normalize(a) end
function CS.UnityEngine.Vector4:Normalize() end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	return CS.System.Single
--]]
function CS.UnityEngine.Vector4:Dot(a,b) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:Project(a,b) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	return CS.System.Single
--]]
function CS.UnityEngine.Vector4:Distance(a,b) end
--[[
	@a CS.UnityEngine.Vector4
	return CS.System.Single
--]]
function CS.UnityEngine.Vector4:Magnitude(a) end
--[[
	@lhs CS.UnityEngine.Vector4
	@rhs CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:Min(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Vector4
	@rhs CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:Max(lhs,rhs) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Addition(a,b) end
--[[
	@a CS.UnityEngine.Vector4
	@b CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Subtraction(a,b) end
--[[
	@a CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_UnaryNegation(a) end
--[[
	@a CS.UnityEngine.Vector4
	@d CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Multiply(a,d) end
--[[
	@d CS.System.Single
	@a CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Multiply(d,a) end
--[[
	@a CS.UnityEngine.Vector4
	@d CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Division(a,d) end
--[[
	@lhs CS.UnityEngine.Vector4
	@rhs CS.UnityEngine.Vector4
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector4:op_Equality(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Vector4
	@rhs CS.UnityEngine.Vector4
	return CS.System.Boolean
--]]
function CS.UnityEngine.Vector4:op_Inequality(lhs,rhs) end
--[[
	@v CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Implicit(v) end
--[[
	@v CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Vector4:op_Implicit(v) end
--[[
	@v CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Vector4:op_Implicit(v) end
--[[
	@v CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Vector4:op_Implicit(v) end
function CS.UnityEngine.Vector4:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Vector4:ToString(format) end
--[[
	@a CS.UnityEngine.Vector4
	return CS.System.Single
--]]
function CS.UnityEngine.Vector4:SqrMagnitude(a) end
function CS.UnityEngine.Vector4:SqrMagnitude() end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Quaternion = {}
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@w CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
]]
function CS.UnityEngine.Quaternion(x,y,z,w) end
--[[
	@RefType [luaIde#CS.UnityEngine.Quaternion]
	 Get 
--]]
CS.UnityEngine.Quaternion.identity = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Quaternion.eulerAngles = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Quaternion]
	 Get 
--]]
CS.UnityEngine.Quaternion.normalized = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Quaternion.x = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Quaternion.y = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Quaternion.z = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Quaternion.w = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Quaternion.kEpsilon = nil
--[[
	@fromDirection CS.UnityEngine.Vector3
	@toDirection CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:FromToRotation(fromDirection,toDirection) end
--[[
	@rotation CS.UnityEngine.Quaternion
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:Inverse(rotation) end
--[[
	@a CS.UnityEngine.Quaternion
	@b CS.UnityEngine.Quaternion
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:Slerp(a,b,t) end
--[[
	@a CS.UnityEngine.Quaternion
	@b CS.UnityEngine.Quaternion
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:SlerpUnclamped(a,b,t) end
--[[
	@a CS.UnityEngine.Quaternion
	@b CS.UnityEngine.Quaternion
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:Lerp(a,b,t) end
--[[
	@a CS.UnityEngine.Quaternion
	@b CS.UnityEngine.Quaternion
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:LerpUnclamped(a,b,t) end
--[[
	@angle CS.System.Single
	@axis CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:AngleAxis(angle,axis) end
--[[
	@forward CS.UnityEngine.Vector3
	@upwards CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:LookRotation(forward,upwards) end
--[[
	@forward CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:LookRotation(forward) end
--[[
	@newX CS.System.Single
	@newY CS.System.Single
	@newZ CS.System.Single
	@newW CS.System.Single
--]]
function CS.UnityEngine.Quaternion:Set(newX,newY,newZ,newW) end
--[[
	@lhs CS.UnityEngine.Quaternion
	@rhs CS.UnityEngine.Quaternion
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:op_Multiply(lhs,rhs) end
--[[
	@rotation CS.UnityEngine.Quaternion
	@point CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Quaternion:op_Multiply(rotation,point) end
--[[
	@lhs CS.UnityEngine.Quaternion
	@rhs CS.UnityEngine.Quaternion
	return CS.System.Boolean
--]]
function CS.UnityEngine.Quaternion:op_Equality(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Quaternion
	@rhs CS.UnityEngine.Quaternion
	return CS.System.Boolean
--]]
function CS.UnityEngine.Quaternion:op_Inequality(lhs,rhs) end
--[[
	@a CS.UnityEngine.Quaternion
	@b CS.UnityEngine.Quaternion
	return CS.System.Single
--]]
function CS.UnityEngine.Quaternion:Dot(a,b) end
--[[
	@view CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Quaternion:SetLookRotation(view) end
--[[
	@view CS.UnityEngine.Vector3
	@up CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Quaternion:SetLookRotation(view,up) end
--[[
	@a CS.UnityEngine.Quaternion
	@b CS.UnityEngine.Quaternion
	return CS.System.Single
--]]
function CS.UnityEngine.Quaternion:Angle(a,b) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:Euler(x,y,z) end
--[[
	@euler CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:Euler(euler) end
--[[
	@angle CS.System.Single&
	@axis CS.UnityEngine.Vector3&
--]]
function CS.UnityEngine.Quaternion:ToAngleAxis(angle,axis) end
--[[
	@fromDirection CS.UnityEngine.Vector3
	@toDirection CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Quaternion:SetFromToRotation(fromDirection,toDirection) end
--[[
	@from CS.UnityEngine.Quaternion
	@to CS.UnityEngine.Quaternion
	@maxDegreesDelta CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:RotateTowards(from,to,maxDegreesDelta) end
--[[
	@q CS.UnityEngine.Quaternion
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:Normalize(q) end
function CS.UnityEngine.Quaternion:Normalize() end
function CS.UnityEngine.Quaternion:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Quaternion:Equals(other) end
--[[
	@other CS.UnityEngine.Quaternion
	return CS.System.Boolean
--]]
function CS.UnityEngine.Quaternion:Equals(other) end
function CS.UnityEngine.Quaternion:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Quaternion:ToString(format) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:EulerRotation(x,y,z) end
--[[
	@euler CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:EulerRotation(euler) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
--]]
function CS.UnityEngine.Quaternion:SetEulerRotation(x,y,z) end
--[[
	@euler CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Quaternion:SetEulerRotation(euler) end
function CS.UnityEngine.Quaternion:ToEuler() end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:EulerAngles(x,y,z) end
--[[
	@euler CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:EulerAngles(euler) end
--[[
	@axis CS.UnityEngine.Vector3&
	@angle CS.System.Single&
--]]
function CS.UnityEngine.Quaternion:ToAxisAngle(axis,angle) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
--]]
function CS.UnityEngine.Quaternion:SetEulerAngles(x,y,z) end
--[[
	@euler CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Quaternion:SetEulerAngles(euler) end
--[[
	@rotation CS.UnityEngine.Quaternion
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Quaternion:ToEulerAngles(rotation) end
function CS.UnityEngine.Quaternion:ToEulerAngles() end
--[[
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
--]]
function CS.UnityEngine.Quaternion:SetAxisAngle(axis,angle) end
--[[
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
	@return [luaIde#CS.UnityEngine.Quaternion]
--]]
function CS.UnityEngine.Quaternion:AxisAngle(axis,angle) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Color = {}
--[[
	@r CS.System.Single
	@g CS.System.Single
	@b CS.System.Single
	@a CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
]]
function CS.UnityEngine.Color(r,g,b,a) end
--[[
	@r CS.System.Single
	@g CS.System.Single
	@b CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
]]
function CS.UnityEngine.Color(r,g,b) end
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.red = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.green = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.blue = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.white = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.black = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.yellow = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.cyan = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.magenta = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.gray = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.grey = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.clear = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Color.grayscale = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.linear = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 
--]]
CS.UnityEngine.Color.gamma = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Color.maxColorComponent = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Color.r = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Color.g = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Color.b = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Color.a = nil
function CS.UnityEngine.Color:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Color:ToString(format) end
function CS.UnityEngine.Color:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Color:Equals(other) end
--[[
	@other CS.UnityEngine.Color
	return CS.System.Boolean
--]]
function CS.UnityEngine.Color:Equals(other) end
--[[
	@a CS.UnityEngine.Color
	@b CS.UnityEngine.Color
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Addition(a,b) end
--[[
	@a CS.UnityEngine.Color
	@b CS.UnityEngine.Color
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Subtraction(a,b) end
--[[
	@a CS.UnityEngine.Color
	@b CS.UnityEngine.Color
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Multiply(a,b) end
--[[
	@a CS.UnityEngine.Color
	@b CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Multiply(a,b) end
--[[
	@b CS.System.Single
	@a CS.UnityEngine.Color
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Multiply(b,a) end
--[[
	@a CS.UnityEngine.Color
	@b CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Division(a,b) end
--[[
	@lhs CS.UnityEngine.Color
	@rhs CS.UnityEngine.Color
	return CS.System.Boolean
--]]
function CS.UnityEngine.Color:op_Equality(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Color
	@rhs CS.UnityEngine.Color
	return CS.System.Boolean
--]]
function CS.UnityEngine.Color:op_Inequality(lhs,rhs) end
--[[
	@a CS.UnityEngine.Color
	@b CS.UnityEngine.Color
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:Lerp(a,b,t) end
--[[
	@a CS.UnityEngine.Color
	@b CS.UnityEngine.Color
	@t CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:LerpUnclamped(a,b,t) end
--[[
	@c CS.UnityEngine.Color
	@return [luaIde#CS.UnityEngine.Vector4]
--]]
function CS.UnityEngine.Color:op_Implicit(c) end
--[[
	@v CS.UnityEngine.Vector4
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:op_Implicit(v) end
--[[
	@rgbColor CS.UnityEngine.Color
	@H CS.System.Single&
	@S CS.System.Single&
	@V CS.System.Single&
--]]
function CS.UnityEngine.Color:RGBToHSV(rgbColor,H,S,V) end
--[[
	@H CS.System.Single
	@S CS.System.Single
	@V CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:HSVToRGB(H,S,V) end
--[[
	@H CS.System.Single
	@S CS.System.Single
	@V CS.System.Single
	@hdr CS.System.Boolean
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Color:HSVToRGB(H,S,V,hdr) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Ray = {}
--[[
	@origin CS.UnityEngine.Vector3
	@direction CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Ray]
]]
function CS.UnityEngine.Ray(origin,direction) end
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Ray.origin = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Ray.direction = nil
--[[
	@distance CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Ray:GetPoint(distance) end
function CS.UnityEngine.Ray:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Ray:ToString(format) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Bounds = {}
--[[
	@center CS.UnityEngine.Vector3
	@size CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Bounds]
]]
function CS.UnityEngine.Bounds(center,size) end
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Bounds.center = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Bounds.size = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Bounds.extents = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Bounds.min = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Bounds.max = nil
function CS.UnityEngine.Bounds:GetHashCode() end
--[[
	@other CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:Equals(other) end
--[[
	@other CS.UnityEngine.Bounds
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:Equals(other) end
--[[
	@lhs CS.UnityEngine.Bounds
	@rhs CS.UnityEngine.Bounds
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:op_Equality(lhs,rhs) end
--[[
	@lhs CS.UnityEngine.Bounds
	@rhs CS.UnityEngine.Bounds
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:op_Inequality(lhs,rhs) end
--[[
	@min CS.UnityEngine.Vector3
	@max CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Bounds:SetMinMax(min,max) end
--[[
	@point CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Bounds:Encapsulate(point) end
--[[
	@bounds CS.UnityEngine.Bounds
--]]
function CS.UnityEngine.Bounds:Encapsulate(bounds) end
--[[
	@amount CS.System.Single
--]]
function CS.UnityEngine.Bounds:Expand(amount) end
--[[
	@amount CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Bounds:Expand(amount) end
--[[
	@bounds CS.UnityEngine.Bounds
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:Intersects(bounds) end
--[[
	@ray CS.UnityEngine.Ray
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:IntersectRay(ray) end
--[[
	@ray CS.UnityEngine.Ray
	@distance CS.System.Single&
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:IntersectRay(ray,distance) end
function CS.UnityEngine.Bounds:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Bounds:ToString(format) end
--[[
	@point CS.UnityEngine.Vector3
	return CS.System.Boolean
--]]
function CS.UnityEngine.Bounds:Contains(point) end
--[[
	@point CS.UnityEngine.Vector3
	return CS.System.Single
--]]
function CS.UnityEngine.Bounds:SqrDistance(point) end
--[[
	@point CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Bounds:ClosestPoint(point) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Ray2D = {}
--[[
	@origin CS.UnityEngine.Vector2
	@direction CS.UnityEngine.Vector2
	@return [luaIde#CS.UnityEngine.Ray2D]
]]
function CS.UnityEngine.Ray2D(origin,direction) end
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 	 Set 
--]]
CS.UnityEngine.Ray2D.origin = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector2]
	 Get 	 Set 
--]]
CS.UnityEngine.Ray2D.direction = nil
--[[
	@distance CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector2]
--]]
function CS.UnityEngine.Ray2D:GetPoint(distance) end
function CS.UnityEngine.Ray2D:ToString() end
--[[
	@format CS.System.String
	return CS.System.String
--]]
function CS.UnityEngine.Ray2D:ToString(format) end

--@SuperType [luaIde#CS.System.Object]
CS.UnityEngine.Time = {}
--[[
	@return [luaIde#CS.UnityEngine.Time]
]]
function CS.UnityEngine.Time() end
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.time = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.timeSinceLevelLoad = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.deltaTime = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.fixedTime = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.unscaledTime = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.fixedUnscaledTime = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.unscaledDeltaTime = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.fixedUnscaledDeltaTime = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Time.fixedDeltaTime = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Time.maximumDeltaTime = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.smoothDeltaTime = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Time.maximumParticleDeltaTime = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Time.timeScale = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.Time.frameCount = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.Time.renderedFrameCount = nil
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.Time.realtimeSinceStartup = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Time.captureDeltaTime = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Time.captureFramerate = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.Time.inFixedTimeStep = nil

--@SuperType [luaIde#CS.UnityEngine.Object]
CS.UnityEngine.GameObject = {}
--[[
	@name CS.System.String
	@return [luaIde#CS.UnityEngine.GameObject]
]]
function CS.UnityEngine.GameObject(name) end
--[[
	@return [luaIde#CS.UnityEngine.GameObject]
]]
function CS.UnityEngine.GameObject() end
--[[
	@name CS.System.String
	@components CS.System.Type{}
	@return [luaIde#CS.UnityEngine.GameObject]
]]
function CS.UnityEngine.GameObject(name,components) end
--[[
	@RefType [luaIde#CS.UnityEngine.Transform]
	 Get 
--]]
CS.UnityEngine.GameObject.transform = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.GameObject.layer = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.GameObject.activeSelf = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.GameObject.activeInHierarchy = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.GameObject.isStatic = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.UnityEngine.GameObject.tag = nil
--[[
	CS.UnityEngine.SceneManagement.Scene
	 Get 
--]]
CS.UnityEngine.GameObject.scene = nil
--[[
	@RefType [luaIde#CS.UnityEngine.GameObject]
	 Get 
--]]
CS.UnityEngine.GameObject.gameObject = nil
--[[
	@type CS.UnityEngine.PrimitiveType
	@return [luaIde#CS.UnityEngine.GameObject]
--]]
function CS.UnityEngine.GameObject:CreatePrimitive(type) end
--[[
	@type CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:GetComponent(type) end
--[[
	@type CS.System.String
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:GetComponent(type) end
--[[
	@type CS.System.Type
	@includeInactive CS.System.Boolean
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:GetComponentInChildren(type,includeInactive) end
--[[
	@type CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:GetComponentInChildren(type) end
--[[
	@type CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:GetComponentInParent(type) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.GameObject:GetComponents(type) end
--[[
	@type CS.System.Type
	@results CS.System.Collections.Generic.List`1{{UnityEngine.Component, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.UnityEngine.GameObject:GetComponents(type,results) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.GameObject:GetComponentsInChildren(type) end
--[[
	@type CS.System.Type
	@includeInactive CS.System.Boolean
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.GameObject:GetComponentsInChildren(type,includeInactive) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.GameObject:GetComponentsInParent(type) end
--[[
	@type CS.System.Type
	@includeInactive CS.System.Boolean
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.GameObject:GetComponentsInParent(type,includeInactive) end
--[[
	@type CS.System.Type
	@component CS.UnityEngine.Component&
	return CS.System.Boolean
--]]
function CS.UnityEngine.GameObject:TryGetComponent(type,component) end
--[[
	@tag CS.System.String
	@return [luaIde#CS.UnityEngine.GameObject]
--]]
function CS.UnityEngine.GameObject:FindWithTag(tag) end
--[[
	@methodName CS.System.String
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName,options) end
--[[
	@methodName CS.System.String
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.GameObject:SendMessage(methodName,options) end
--[[
	@methodName CS.System.String
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.GameObject:BroadcastMessage(methodName,options) end
--[[
	@componentType CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:AddComponent(componentType) end
--[[
	@value CS.System.Boolean
--]]
function CS.UnityEngine.GameObject:SetActive(value) end
--[[
	@state CS.System.Boolean
--]]
function CS.UnityEngine.GameObject:SetActiveRecursively(state) end
--[[
	@tag CS.System.String
	return CS.System.Boolean
--]]
function CS.UnityEngine.GameObject:CompareTag(tag) end
--[[
	@tag CS.System.String
	@return [luaIde#CS.UnityEngine.GameObject]
--]]
function CS.UnityEngine.GameObject:FindGameObjectWithTag(tag) end
--[[
	@tag CS.System.String
	return CS.UnityEngine.GameObject{}
--]]
function CS.UnityEngine.GameObject:FindGameObjectsWithTag(tag) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName,value,options) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
--]]
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName,value) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.GameObject:SendMessageUpwards(methodName) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.GameObject:SendMessage(methodName,value,options) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
--]]
function CS.UnityEngine.GameObject:SendMessage(methodName,value) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.GameObject:SendMessage(methodName) end
--[[
	@methodName CS.System.String
	@parameter CS.System.Object
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.GameObject:BroadcastMessage(methodName,parameter,options) end
--[[
	@methodName CS.System.String
	@parameter CS.System.Object
--]]
function CS.UnityEngine.GameObject:BroadcastMessage(methodName,parameter) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.GameObject:BroadcastMessage(methodName) end
--[[
	@name CS.System.String
	@return [luaIde#CS.UnityEngine.GameObject]
--]]
function CS.UnityEngine.GameObject:Find(name) end
--[[
	@clip CS.UnityEngine.Object
	@time CS.System.Single
--]]
function CS.UnityEngine.GameObject:SampleAnimation(clip,time) end
--[[
	@className CS.System.String
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.GameObject:AddComponent(className) end
--[[
	@animation CS.UnityEngine.Object
--]]
function CS.UnityEngine.GameObject:PlayAnimation(animation) end
function CS.UnityEngine.GameObject:StopAnimation() end

--@SuperType [luaIde#CS.UnityEngine.Object]
CS.UnityEngine.Component = {}
--[[
	@return [luaIde#CS.UnityEngine.Component]
]]
function CS.UnityEngine.Component() end
--[[
	@RefType [luaIde#CS.UnityEngine.Transform]
	 Get 
--]]
CS.UnityEngine.Component.transform = nil
--[[
	@RefType [luaIde#CS.UnityEngine.GameObject]
	 Get 
--]]
CS.UnityEngine.Component.gameObject = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.UnityEngine.Component.tag = nil
--[[
	@type CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.Component:GetComponent(type) end
--[[
	@type CS.System.Type
	@component CS.UnityEngine.Component&
	return CS.System.Boolean
--]]
function CS.UnityEngine.Component:TryGetComponent(type,component) end
--[[
	@type CS.System.String
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.Component:GetComponent(type) end
--[[
	@t CS.System.Type
	@includeInactive CS.System.Boolean
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.Component:GetComponentInChildren(t,includeInactive) end
--[[
	@t CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.Component:GetComponentInChildren(t) end
--[[
	@t CS.System.Type
	@includeInactive CS.System.Boolean
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.Component:GetComponentsInChildren(t,includeInactive) end
--[[
	@t CS.System.Type
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.Component:GetComponentsInChildren(t) end
--[[
	@t CS.System.Type
	@return [luaIde#CS.UnityEngine.Component]
--]]
function CS.UnityEngine.Component:GetComponentInParent(t) end
--[[
	@t CS.System.Type
	@includeInactive CS.System.Boolean
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.Component:GetComponentsInParent(t,includeInactive) end
--[[
	@t CS.System.Type
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.Component:GetComponentsInParent(t) end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Component{}
--]]
function CS.UnityEngine.Component:GetComponents(type) end
--[[
	@type CS.System.Type
	@results CS.System.Collections.Generic.List`1{{UnityEngine.Component, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.UnityEngine.Component:GetComponents(type,results) end
--[[
	@tag CS.System.String
	return CS.System.Boolean
--]]
function CS.UnityEngine.Component:CompareTag(tag) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.Component:SendMessageUpwards(methodName,value,options) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
--]]
function CS.UnityEngine.Component:SendMessageUpwards(methodName,value) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.Component:SendMessageUpwards(methodName) end
--[[
	@methodName CS.System.String
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.Component:SendMessageUpwards(methodName,options) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
--]]
function CS.UnityEngine.Component:SendMessage(methodName,value) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.Component:SendMessage(methodName) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.Component:SendMessage(methodName,value,options) end
--[[
	@methodName CS.System.String
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.Component:SendMessage(methodName,options) end
--[[
	@methodName CS.System.String
	@parameter CS.System.Object
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.Component:BroadcastMessage(methodName,parameter,options) end
--[[
	@methodName CS.System.String
	@parameter CS.System.Object
--]]
function CS.UnityEngine.Component:BroadcastMessage(methodName,parameter) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.Component:BroadcastMessage(methodName) end
--[[
	@methodName CS.System.String
	@options CS.UnityEngine.SendMessageOptions
--]]
function CS.UnityEngine.Component:BroadcastMessage(methodName,options) end

--@SuperType [luaIde#CS.UnityEngine.Component]
CS.UnityEngine.Behaviour = {}
--[[
	@return [luaIde#CS.UnityEngine.Behaviour]
]]
function CS.UnityEngine.Behaviour() end
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Behaviour.enabled = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.Behaviour.isActiveAndEnabled = nil

--@SuperType [luaIde#CS.UnityEngine.Component]
CS.UnityEngine.Transform = {}
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.position = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.localPosition = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.eulerAngles = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.localEulerAngles = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.right = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.up = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.forward = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Quaternion]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.rotation = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Quaternion]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.localRotation = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.localScale = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Transform]
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.parent = nil
--[[
	CS.UnityEngine.Matrix4x4
	 Get 
--]]
CS.UnityEngine.Transform.worldToLocalMatrix = nil
--[[
	CS.UnityEngine.Matrix4x4
	 Get 
--]]
CS.UnityEngine.Transform.localToWorldMatrix = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Transform]
	 Get 
--]]
CS.UnityEngine.Transform.root = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.Transform.childCount = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 
--]]
CS.UnityEngine.Transform.lossyScale = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.hasChanged = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Transform.hierarchyCapacity = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.Transform.hierarchyCount = nil
--[[
	@p CS.UnityEngine.Transform
--]]
function CS.UnityEngine.Transform:SetParent(p) end
--[[
	@parent CS.UnityEngine.Transform
	@worldPositionStays CS.System.Boolean
--]]
function CS.UnityEngine.Transform:SetParent(parent,worldPositionStays) end
--[[
	@position CS.UnityEngine.Vector3
	@rotation CS.UnityEngine.Quaternion
--]]
function CS.UnityEngine.Transform:SetPositionAndRotation(position,rotation) end
--[[
	@translation CS.UnityEngine.Vector3
	@relativeTo CS.UnityEngine.Space
--]]
function CS.UnityEngine.Transform:Translate(translation,relativeTo) end
--[[
	@translation CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Transform:Translate(translation) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@relativeTo CS.UnityEngine.Space
--]]
function CS.UnityEngine.Transform:Translate(x,y,z,relativeTo) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
--]]
function CS.UnityEngine.Transform:Translate(x,y,z) end
--[[
	@translation CS.UnityEngine.Vector3
	@relativeTo CS.UnityEngine.Transform
--]]
function CS.UnityEngine.Transform:Translate(translation,relativeTo) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@relativeTo CS.UnityEngine.Transform
--]]
function CS.UnityEngine.Transform:Translate(x,y,z,relativeTo) end
--[[
	@eulers CS.UnityEngine.Vector3
	@relativeTo CS.UnityEngine.Space
--]]
function CS.UnityEngine.Transform:Rotate(eulers,relativeTo) end
--[[
	@eulers CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Transform:Rotate(eulers) end
--[[
	@xAngle CS.System.Single
	@yAngle CS.System.Single
	@zAngle CS.System.Single
	@relativeTo CS.UnityEngine.Space
--]]
function CS.UnityEngine.Transform:Rotate(xAngle,yAngle,zAngle,relativeTo) end
--[[
	@xAngle CS.System.Single
	@yAngle CS.System.Single
	@zAngle CS.System.Single
--]]
function CS.UnityEngine.Transform:Rotate(xAngle,yAngle,zAngle) end
--[[
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
	@relativeTo CS.UnityEngine.Space
--]]
function CS.UnityEngine.Transform:Rotate(axis,angle,relativeTo) end
--[[
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
--]]
function CS.UnityEngine.Transform:Rotate(axis,angle) end
--[[
	@point CS.UnityEngine.Vector3
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
--]]
function CS.UnityEngine.Transform:RotateAround(point,axis,angle) end
--[[
	@target CS.UnityEngine.Transform
	@worldUp CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Transform:LookAt(target,worldUp) end
--[[
	@target CS.UnityEngine.Transform
--]]
function CS.UnityEngine.Transform:LookAt(target) end
--[[
	@worldPosition CS.UnityEngine.Vector3
	@worldUp CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Transform:LookAt(worldPosition,worldUp) end
--[[
	@worldPosition CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Transform:LookAt(worldPosition) end
--[[
	@direction CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:TransformDirection(direction) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:TransformDirection(x,y,z) end
--[[
	@direction CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:InverseTransformDirection(direction) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:InverseTransformDirection(x,y,z) end
--[[
	@vector CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:TransformVector(vector) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:TransformVector(x,y,z) end
--[[
	@vector CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:InverseTransformVector(vector) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:InverseTransformVector(x,y,z) end
--[[
	@position CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:TransformPoint(position) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:TransformPoint(x,y,z) end
--[[
	@position CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:InverseTransformPoint(position) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	@z CS.System.Single
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.UnityEngine.Transform:InverseTransformPoint(x,y,z) end
function CS.UnityEngine.Transform:DetachChildren() end
function CS.UnityEngine.Transform:SetAsFirstSibling() end
function CS.UnityEngine.Transform:SetAsLastSibling() end
--[[
	@index CS.System.Int32
--]]
function CS.UnityEngine.Transform:SetSiblingIndex(index) end
function CS.UnityEngine.Transform:GetSiblingIndex() end
--[[
	@n CS.System.String
	@return [luaIde#CS.UnityEngine.Transform]
--]]
function CS.UnityEngine.Transform:Find(n) end
--[[
	@parent CS.UnityEngine.Transform
	return CS.System.Boolean
--]]
function CS.UnityEngine.Transform:IsChildOf(parent) end
--[[
	@n CS.System.String
	@return [luaIde#CS.UnityEngine.Transform]
--]]
function CS.UnityEngine.Transform:FindChild(n) end
function CS.UnityEngine.Transform:GetEnumerator() end
--[[
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
--]]
function CS.UnityEngine.Transform:RotateAround(axis,angle) end
--[[
	@axis CS.UnityEngine.Vector3
	@angle CS.System.Single
--]]
function CS.UnityEngine.Transform:RotateAroundLocal(axis,angle) end
--[[
	@index CS.System.Int32
	@return [luaIde#CS.UnityEngine.Transform]
--]]
function CS.UnityEngine.Transform:GetChild(index) end
function CS.UnityEngine.Transform:GetChildCount() end

--@SuperType [luaIde#CS.System.Object]
CS.UnityEngine.Resources = {}
--[[
	@return [luaIde#CS.UnityEngine.Resources]
]]
function CS.UnityEngine.Resources() end
--[[
	@type CS.System.Type
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Resources:FindObjectsOfTypeAll(type) end
--[[
	@path CS.System.String
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Resources:Load(path) end
--[[
	@path CS.System.String
	@systemTypeInstance CS.System.Type
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Resources:Load(path,systemTypeInstance) end
--[[
	@path CS.System.String
	return CS.UnityEngine.ResourceRequest
--]]
function CS.UnityEngine.Resources:LoadAsync(path) end
--[[
	@path CS.System.String
	@type CS.System.Type
	return CS.UnityEngine.ResourceRequest
--]]
function CS.UnityEngine.Resources:LoadAsync(path,type) end
--[[
	@path CS.System.String
	@systemTypeInstance CS.System.Type
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Resources:LoadAll(path,systemTypeInstance) end
--[[
	@path CS.System.String
	return CS.UnityEngine.Object{}
--]]
function CS.UnityEngine.Resources:LoadAll(path) end
--[[
	@type CS.System.Type
	@path CS.System.String
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Resources:GetBuiltinResource(type,path) end
--[[
	@assetToUnload CS.UnityEngine.Object
--]]
function CS.UnityEngine.Resources:UnloadAsset(assetToUnload) end
function CS.UnityEngine.Resources:UnloadUnusedAssets() end
--[[
	@assetPath CS.System.String
	@type CS.System.Type
	@return [luaIde#CS.UnityEngine.Object]
--]]
function CS.UnityEngine.Resources:LoadAssetAtPath(assetPath,type) end

--@SuperType [luaIde#CS.UnityEngine.Object]
CS.UnityEngine.TextAsset = {}
--[[
	@return [luaIde#CS.UnityEngine.TextAsset]
]]
function CS.UnityEngine.TextAsset() end
--[[
	@text CS.System.String
	@return [luaIde#CS.UnityEngine.TextAsset]
]]
function CS.UnityEngine.TextAsset(text) end
--[[
	CS.System.String
	 Get 
--]]
CS.UnityEngine.TextAsset.text = nil
--[[
	CS.System.Byte{}
	 Get 
--]]
CS.UnityEngine.TextAsset.bytes = nil
function CS.UnityEngine.TextAsset:ToString() end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Keyframe = {}
--[[
	@time CS.System.Single
	@value CS.System.Single
	@return [luaIde#CS.UnityEngine.Keyframe]
]]
function CS.UnityEngine.Keyframe(time,value) end
--[[
	@time CS.System.Single
	@value CS.System.Single
	@inTangent CS.System.Single
	@outTangent CS.System.Single
	@return [luaIde#CS.UnityEngine.Keyframe]
]]
function CS.UnityEngine.Keyframe(time,value,inTangent,outTangent) end
--[[
	@time CS.System.Single
	@value CS.System.Single
	@inTangent CS.System.Single
	@outTangent CS.System.Single
	@inWeight CS.System.Single
	@outWeight CS.System.Single
	@return [luaIde#CS.UnityEngine.Keyframe]
]]
function CS.UnityEngine.Keyframe(time,value,inTangent,outTangent,inWeight,outWeight) end
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.time = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.value = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.inTangent = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.outTangent = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.inWeight = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.outWeight = nil
--[[
	CS.UnityEngine.WeightedMode
	 Get 	 Set 
--]]
CS.UnityEngine.Keyframe.weightedMode = nil

--@SuperType [luaIde#CS.System.Object]
CS.UnityEngine.AnimationCurve = {}
--[[
	@keys CS.UnityEngine.Keyframe{}
	@return [luaIde#CS.UnityEngine.AnimationCurve]
]]
function CS.UnityEngine.AnimationCurve(keys) end
--[[
	@return [luaIde#CS.UnityEngine.AnimationCurve]
]]
function CS.UnityEngine.AnimationCurve() end
--[[
	CS.UnityEngine.Keyframe{}
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationCurve.keys = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.AnimationCurve.length = nil
--[[
	CS.UnityEngine.WrapMode
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationCurve.preWrapMode = nil
--[[
	CS.UnityEngine.WrapMode
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationCurve.postWrapMode = nil
--[[
	@time CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.AnimationCurve:Evaluate(time) end
--[[
	@time CS.System.Single
	@value CS.System.Single
	return CS.System.Int32
--]]
function CS.UnityEngine.AnimationCurve:AddKey(time,value) end
--[[
	@key CS.UnityEngine.Keyframe
	return CS.System.Int32
--]]
function CS.UnityEngine.AnimationCurve:AddKey(key) end
--[[
	@index CS.System.Int32
	@key CS.UnityEngine.Keyframe
	return CS.System.Int32
--]]
function CS.UnityEngine.AnimationCurve:MoveKey(index,key) end
--[[
	@index CS.System.Int32
--]]
function CS.UnityEngine.AnimationCurve:RemoveKey(index) end
--[[
	@index CS.System.Int32
	@weight CS.System.Single
--]]
function CS.UnityEngine.AnimationCurve:SmoothTangents(index,weight) end
--[[
	@timeStart CS.System.Single
	@timeEnd CS.System.Single
	@value CS.System.Single
	@return [luaIde#CS.UnityEngine.AnimationCurve]
--]]
function CS.UnityEngine.AnimationCurve:Constant(timeStart,timeEnd,value) end
--[[
	@timeStart CS.System.Single
	@valueStart CS.System.Single
	@timeEnd CS.System.Single
	@valueEnd CS.System.Single
	@return [luaIde#CS.UnityEngine.AnimationCurve]
--]]
function CS.UnityEngine.AnimationCurve:Linear(timeStart,valueStart,timeEnd,valueEnd) end
--[[
	@timeStart CS.System.Single
	@valueStart CS.System.Single
	@timeEnd CS.System.Single
	@valueEnd CS.System.Single
	@return [luaIde#CS.UnityEngine.AnimationCurve]
--]]
function CS.UnityEngine.AnimationCurve:EaseInOut(timeStart,valueStart,timeEnd,valueEnd) end
--[[
	@o CS.System.Object
	return CS.System.Boolean
--]]
function CS.UnityEngine.AnimationCurve:Equals(o) end
--[[
	@other CS.UnityEngine.AnimationCurve
	return CS.System.Boolean
--]]
function CS.UnityEngine.AnimationCurve:Equals(other) end
function CS.UnityEngine.AnimationCurve:GetHashCode() end

--@SuperType [luaIde#CS.UnityEngine.Motion]
CS.UnityEngine.AnimationClip = {}
--[[
	@return [luaIde#CS.UnityEngine.AnimationClip]
]]
function CS.UnityEngine.AnimationClip() end
--[[
	CS.System.Single
	 Get 
--]]
CS.UnityEngine.AnimationClip.length = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationClip.frameRate = nil
--[[
	CS.UnityEngine.WrapMode
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationClip.wrapMode = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Bounds]
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationClip.localBounds = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationClip.legacy = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.AnimationClip.humanMotion = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.AnimationClip.empty = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.AnimationClip.hasGenericRootTransform = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.AnimationClip.hasMotionFloatCurves = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.AnimationClip.hasMotionCurves = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.AnimationClip.hasRootCurves = nil
--[[
	CS.UnityEngine.AnimationEvent{}
	 Get 	 Set 
--]]
CS.UnityEngine.AnimationClip.events = nil
--[[
	@go CS.UnityEngine.GameObject
	@time CS.System.Single
--]]
function CS.UnityEngine.AnimationClip:SampleAnimation(go,time) end
--[[
	@relativePath CS.System.String
	@type CS.System.Type
	@propertyName CS.System.String
	@curve CS.UnityEngine.AnimationCurve
--]]
function CS.UnityEngine.AnimationClip:SetCurve(relativePath,type,propertyName,curve) end
function CS.UnityEngine.AnimationClip:EnsureQuaternionContinuity() end
function CS.UnityEngine.AnimationClip:ClearCurves() end
--[[
	@evt CS.UnityEngine.AnimationEvent
--]]
function CS.UnityEngine.AnimationClip:AddEvent(evt) end

--@SuperType [luaIde#CS.UnityEngine.Behaviour]
CS.UnityEngine.MonoBehaviour = {}
--[[
	@return [luaIde#CS.UnityEngine.MonoBehaviour]
]]
function CS.UnityEngine.MonoBehaviour() end
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.MonoBehaviour.useGUILayout = nil
function CS.UnityEngine.MonoBehaviour:IsInvoking() end
function CS.UnityEngine.MonoBehaviour:CancelInvoke() end
--[[
	@methodName CS.System.String
	@time CS.System.Single
--]]
function CS.UnityEngine.MonoBehaviour:Invoke(methodName,time) end
--[[
	@methodName CS.System.String
	@time CS.System.Single
	@repeatRate CS.System.Single
--]]
function CS.UnityEngine.MonoBehaviour:InvokeRepeating(methodName,time,repeatRate) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.MonoBehaviour:CancelInvoke(methodName) end
--[[
	@methodName CS.System.String
	return CS.System.Boolean
--]]
function CS.UnityEngine.MonoBehaviour:IsInvoking(methodName) end
--[[
	@methodName CS.System.String
	return CS.UnityEngine.Coroutine
--]]
function CS.UnityEngine.MonoBehaviour:StartCoroutine(methodName) end
--[[
	@methodName CS.System.String
	@value CS.System.Object
	return CS.UnityEngine.Coroutine
--]]
function CS.UnityEngine.MonoBehaviour:StartCoroutine(methodName,value) end
--[[
	@routine CS.System.Collections.IEnumerator
	return CS.UnityEngine.Coroutine
--]]
function CS.UnityEngine.MonoBehaviour:StartCoroutine(routine) end
--[[
	@routine CS.System.Collections.IEnumerator
	return CS.UnityEngine.Coroutine
--]]
function CS.UnityEngine.MonoBehaviour:StartCoroutine_Auto(routine) end
--[[
	@routine CS.System.Collections.IEnumerator
--]]
function CS.UnityEngine.MonoBehaviour:StopCoroutine(routine) end
--[[
	@routine CS.UnityEngine.Coroutine
--]]
function CS.UnityEngine.MonoBehaviour:StopCoroutine(routine) end
--[[
	@methodName CS.System.String
--]]
function CS.UnityEngine.MonoBehaviour:StopCoroutine(methodName) end
function CS.UnityEngine.MonoBehaviour:StopAllCoroutines() end
--[[
	@message CS.System.Object
--]]
function CS.UnityEngine.MonoBehaviour:print(message) end

--@SuperType [luaIde#CS.UnityEngine.Component]
CS.UnityEngine.ParticleSystem = {}
--[[
	@return [luaIde#CS.UnityEngine.ParticleSystem]
]]
function CS.UnityEngine.ParticleSystem() end
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.ParticleSystem.isPlaying = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.ParticleSystem.isEmitting = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.ParticleSystem.isStopped = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.ParticleSystem.isPaused = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.ParticleSystem.particleCount = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.ParticleSystem.time = nil
--[[
	CS.System.UInt32
	 Get 	 Set 
--]]
CS.UnityEngine.ParticleSystem.randomSeed = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.ParticleSystem.useAutoRandomSeed = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.ParticleSystem.proceduralSimulationSupported = nil
--[[
	CS.UnityEngine.ParticleSystem.MainModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.main = nil
--[[
	CS.UnityEngine.ParticleSystem.EmissionModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.emission = nil
--[[
	CS.UnityEngine.ParticleSystem.ShapeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.shape = nil
--[[
	CS.UnityEngine.ParticleSystem.VelocityOverLifetimeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.velocityOverLifetime = nil
--[[
	CS.UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.limitVelocityOverLifetime = nil
--[[
	CS.UnityEngine.ParticleSystem.InheritVelocityModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.inheritVelocity = nil
--[[
	CS.UnityEngine.ParticleSystem.ForceOverLifetimeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.forceOverLifetime = nil
--[[
	CS.UnityEngine.ParticleSystem.ColorOverLifetimeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.colorOverLifetime = nil
--[[
	CS.UnityEngine.ParticleSystem.ColorBySpeedModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.colorBySpeed = nil
--[[
	CS.UnityEngine.ParticleSystem.SizeOverLifetimeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.sizeOverLifetime = nil
--[[
	CS.UnityEngine.ParticleSystem.SizeBySpeedModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.sizeBySpeed = nil
--[[
	CS.UnityEngine.ParticleSystem.RotationOverLifetimeModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.rotationOverLifetime = nil
--[[
	CS.UnityEngine.ParticleSystem.RotationBySpeedModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.rotationBySpeed = nil
--[[
	CS.UnityEngine.ParticleSystem.ExternalForcesModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.externalForces = nil
--[[
	CS.UnityEngine.ParticleSystem.NoiseModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.noise = nil
--[[
	CS.UnityEngine.ParticleSystem.CollisionModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.collision = nil
--[[
	CS.UnityEngine.ParticleSystem.TriggerModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.trigger = nil
--[[
	CS.UnityEngine.ParticleSystem.SubEmittersModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.subEmitters = nil
--[[
	CS.UnityEngine.ParticleSystem.TextureSheetAnimationModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.textureSheetAnimation = nil
--[[
	CS.UnityEngine.ParticleSystem.LightsModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.lights = nil
--[[
	CS.UnityEngine.ParticleSystem.TrailModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.trails = nil
--[[
	CS.UnityEngine.ParticleSystem.CustomDataModule
	 Get 
--]]
CS.UnityEngine.ParticleSystem.customData = nil
--[[
	@position CS.UnityEngine.Vector3
	@velocity CS.UnityEngine.Vector3
	@size CS.System.Single
	@lifetime CS.System.Single
	@color CS.UnityEngine.Color32
--]]
function CS.UnityEngine.ParticleSystem:Emit(position,velocity,size,lifetime,color) end
--[[
	@particle CS.UnityEngine.ParticleSystem.Particle
--]]
function CS.UnityEngine.ParticleSystem:Emit(particle) end
--[[
	@particles CS.UnityEngine.ParticleSystem.Particle{}
	@size CS.System.Int32
	@offset CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:SetParticles(particles,size,offset) end
--[[
	@particles CS.UnityEngine.ParticleSystem.Particle{}
	@size CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:SetParticles(particles,size) end
--[[
	@particles CS.UnityEngine.ParticleSystem.Particle{}
--]]
function CS.UnityEngine.ParticleSystem:SetParticles(particles) end
--[[
	@particles CS.UnityEngine.ParticleSystem.Particle{}
	@size CS.System.Int32
	@offset CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:GetParticles(particles,size,offset) end
--[[
	@particles CS.UnityEngine.ParticleSystem.Particle{}
	@size CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:GetParticles(particles,size) end
--[[
	@particles CS.UnityEngine.ParticleSystem.Particle{}
	return CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:GetParticles(particles) end
--[[
	@customData CS.System.Collections.Generic.List`1{{UnityEngine.Vector4, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@streamIndex CS.UnityEngine.ParticleSystemCustomData
--]]
function CS.UnityEngine.ParticleSystem:SetCustomParticleData(customData,streamIndex) end
--[[
	@customData CS.System.Collections.Generic.List`1{{UnityEngine.Vector4, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
	@streamIndex CS.UnityEngine.ParticleSystemCustomData
	return CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:GetCustomParticleData(customData,streamIndex) end
--[[
	@t CS.System.Single
	@withChildren CS.System.Boolean
	@restart CS.System.Boolean
	@fixedTimeStep CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Simulate(t,withChildren,restart,fixedTimeStep) end
--[[
	@t CS.System.Single
	@withChildren CS.System.Boolean
	@restart CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Simulate(t,withChildren,restart) end
--[[
	@t CS.System.Single
	@withChildren CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Simulate(t,withChildren) end
--[[
	@t CS.System.Single
--]]
function CS.UnityEngine.ParticleSystem:Simulate(t) end
--[[
	@withChildren CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Play(withChildren) end
function CS.UnityEngine.ParticleSystem:Play() end
--[[
	@withChildren CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Pause(withChildren) end
function CS.UnityEngine.ParticleSystem:Pause() end
--[[
	@withChildren CS.System.Boolean
	@stopBehavior CS.UnityEngine.ParticleSystemStopBehavior
--]]
function CS.UnityEngine.ParticleSystem:Stop(withChildren,stopBehavior) end
--[[
	@withChildren CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Stop(withChildren) end
function CS.UnityEngine.ParticleSystem:Stop() end
--[[
	@withChildren CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:Clear(withChildren) end
function CS.UnityEngine.ParticleSystem:Clear() end
--[[
	@withChildren CS.System.Boolean
	return CS.System.Boolean
--]]
function CS.UnityEngine.ParticleSystem:IsAlive(withChildren) end
function CS.UnityEngine.ParticleSystem:IsAlive() end
--[[
	@count CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:Emit(count) end
--[[
	@emitParams CS.UnityEngine.ParticleSystem.EmitParams
	@count CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:Emit(emitParams,count) end
--[[
	@subEmitterIndex CS.System.Int32
--]]
function CS.UnityEngine.ParticleSystem:TriggerSubEmitter(subEmitterIndex) end
--[[
	@subEmitterIndex CS.System.Int32
	@particle CS.UnityEngine.ParticleSystem.Particle&
--]]
function CS.UnityEngine.ParticleSystem:TriggerSubEmitter(subEmitterIndex,particle) end
--[[
	@subEmitterIndex CS.System.Int32
	@particles CS.System.Collections.Generic.List`1{{UnityEngine.ParticleSystem.Particle, UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.UnityEngine.ParticleSystem:TriggerSubEmitter(subEmitterIndex,particles) end
function CS.UnityEngine.ParticleSystem:ResetPreMappedBufferMemory() end

--@SuperType [luaIde#CS.UnityEngine.Renderer]
CS.UnityEngine.SkinnedMeshRenderer = {}
--[[
	@return [luaIde#CS.UnityEngine.SkinnedMeshRenderer]
]]
function CS.UnityEngine.SkinnedMeshRenderer() end
--[[
	CS.UnityEngine.SkinQuality
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.quality = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.updateWhenOffscreen = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.forceMatrixRecalculationPerRender = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Transform]
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.rootBone = nil
--[[
	CS.UnityEngine.Transform{}
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.bones = nil
--[[
	CS.UnityEngine.Mesh
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.sharedMesh = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.skinnedMotionVectors = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Bounds]
	 Get 	 Set 
--]]
CS.UnityEngine.SkinnedMeshRenderer.localBounds = nil
--[[
	@index CS.System.Int32
	return CS.System.Single
--]]
function CS.UnityEngine.SkinnedMeshRenderer:GetBlendShapeWeight(index) end
--[[
	@index CS.System.Int32
	@value CS.System.Single
--]]
function CS.UnityEngine.SkinnedMeshRenderer:SetBlendShapeWeight(index,value) end
--[[
	@mesh CS.UnityEngine.Mesh
--]]
function CS.UnityEngine.SkinnedMeshRenderer:BakeMesh(mesh) end

--@SuperType [luaIde#CS.UnityEngine.Component]
CS.UnityEngine.Renderer = {}
--[[
	@return [luaIde#CS.UnityEngine.Renderer]
]]
function CS.UnityEngine.Renderer() end
--[[
	@RefType [luaIde#CS.UnityEngine.Bounds]
	 Get 
--]]
CS.UnityEngine.Renderer.bounds = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.enabled = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.Renderer.isVisible = nil
--[[
	CS.UnityEngine.Rendering.ShadowCastingMode
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.shadowCastingMode = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.receiveShadows = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.forceRenderingOff = nil
--[[
	CS.UnityEngine.MotionVectorGenerationMode
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.motionVectorGenerationMode = nil
--[[
	CS.UnityEngine.Rendering.LightProbeUsage
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.lightProbeUsage = nil
--[[
	CS.UnityEngine.Rendering.ReflectionProbeUsage
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.reflectionProbeUsage = nil
--[[
	CS.System.UInt32
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.renderingLayerMask = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.rendererPriority = nil
--[[
	CS.UnityEngine.Experimental.Rendering.RayTracingMode
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.rayTracingMode = nil
--[[
	CS.System.String
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.sortingLayerName = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.sortingLayerID = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.sortingOrder = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.allowOcclusionWhenDynamic = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.Renderer.isPartOfStaticBatch = nil
--[[
	CS.UnityEngine.Matrix4x4
	 Get 
--]]
CS.UnityEngine.Renderer.worldToLocalMatrix = nil
--[[
	CS.UnityEngine.Matrix4x4
	 Get 
--]]
CS.UnityEngine.Renderer.localToWorldMatrix = nil
--[[
	@RefType [luaIde#CS.UnityEngine.GameObject]
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.lightProbeProxyVolumeOverride = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Transform]
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.probeAnchor = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.lightmapIndex = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.realtimeLightmapIndex = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.lightmapScaleOffset = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.realtimeLightmapScaleOffset = nil
--[[
	CS.UnityEngine.Material{}
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.materials = nil
--[[
	CS.UnityEngine.Material
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.material = nil
--[[
	CS.UnityEngine.Material
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.sharedMaterial = nil
--[[
	CS.UnityEngine.Material{}
	 Get 	 Set 
--]]
CS.UnityEngine.Renderer.sharedMaterials = nil
function CS.UnityEngine.Renderer:HasPropertyBlock() end
--[[
	@properties CS.UnityEngine.MaterialPropertyBlock
--]]
function CS.UnityEngine.Renderer:SetPropertyBlock(properties) end
--[[
	@properties CS.UnityEngine.MaterialPropertyBlock
	@materialIndex CS.System.Int32
--]]
function CS.UnityEngine.Renderer:SetPropertyBlock(properties,materialIndex) end
--[[
	@properties CS.UnityEngine.MaterialPropertyBlock
--]]
function CS.UnityEngine.Renderer:GetPropertyBlock(properties) end
--[[
	@properties CS.UnityEngine.MaterialPropertyBlock
	@materialIndex CS.System.Int32
--]]
function CS.UnityEngine.Renderer:GetPropertyBlock(properties,materialIndex) end
--[[
	@m CS.System.Collections.Generic.List`1{{UnityEngine.Material, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.UnityEngine.Renderer:GetMaterials(m) end
--[[
	@m CS.System.Collections.Generic.List`1{{UnityEngine.Material, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.UnityEngine.Renderer:GetSharedMaterials(m) end
--[[
	@result CS.System.Collections.Generic.List`1{{UnityEngine.Rendering.ReflectionProbeBlendInfo, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null}}
--]]
function CS.UnityEngine.Renderer:GetClosestReflectionProbes(result) end

--@SuperType [luaIde#CS.UnityEngine.Behaviour]
CS.UnityEngine.Light = {}
--[[
	@return [luaIde#CS.UnityEngine.Light]
]]
function CS.UnityEngine.Light() end
--[[
	CS.UnityEngine.LightType
	 Get 	 Set 
--]]
CS.UnityEngine.Light.type = nil
--[[
	CS.UnityEngine.LightShape
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shape = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.spotAngle = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.innerSpotAngle = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Color]
	 Get 	 Set 
--]]
CS.UnityEngine.Light.color = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.colorTemperature = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Light.useColorTemperature = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.intensity = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.bounceIntensity = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Light.useBoundingSphereOverride = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector4]
	 Get 	 Set 
--]]
CS.UnityEngine.Light.boundingSphereOverride = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowCustomResolution = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowBias = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowNormalBias = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowNearPlane = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Light.useShadowMatrixOverride = nil
--[[
	CS.UnityEngine.Matrix4x4
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowMatrixOverride = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.range = nil
--[[
	CS.UnityEngine.Flare
	 Get 	 Set 
--]]
CS.UnityEngine.Light.flare = nil
--[[
	CS.UnityEngine.LightBakingOutput
	 Get 	 Set 
--]]
CS.UnityEngine.Light.bakingOutput = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Light.cullingMask = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.UnityEngine.Light.renderingLayerMask = nil
--[[
	CS.UnityEngine.LightShadowCasterMode
	 Get 	 Set 
--]]
CS.UnityEngine.Light.lightShadowCasterMode = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowRadius = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowAngle = nil
--[[
	CS.UnityEngine.LightShadows
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadows = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowStrength = nil
--[[
	CS.UnityEngine.Rendering.LightShadowResolution
	 Get 	 Set 
--]]
CS.UnityEngine.Light.shadowResolution = nil
--[[
	CS.System.Single{}
	 Get 	 Set 
--]]
CS.UnityEngine.Light.layerShadowCullDistances = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Light.cookieSize = nil
--[[
	CS.UnityEngine.Texture
	 Get 	 Set 
--]]
CS.UnityEngine.Light.cookie = nil
--[[
	CS.UnityEngine.LightRenderMode
	 Get 	 Set 
--]]
CS.UnityEngine.Light.renderMode = nil
--[[
	CS.System.Int32
	 Get 
--]]
CS.UnityEngine.Light.commandBufferCount = nil
function CS.UnityEngine.Light:Reset() end
function CS.UnityEngine.Light:SetLightDirty() end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
	@buffer CS.UnityEngine.Rendering.CommandBuffer
--]]
function CS.UnityEngine.Light:AddCommandBuffer(evt,buffer) end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
	@buffer CS.UnityEngine.Rendering.CommandBuffer
	@shadowPassMask CS.UnityEngine.Rendering.ShadowMapPass
--]]
function CS.UnityEngine.Light:AddCommandBuffer(evt,buffer,shadowPassMask) end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
	@buffer CS.UnityEngine.Rendering.CommandBuffer
	@queueType CS.UnityEngine.Rendering.ComputeQueueType
--]]
function CS.UnityEngine.Light:AddCommandBufferAsync(evt,buffer,queueType) end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
	@buffer CS.UnityEngine.Rendering.CommandBuffer
	@shadowPassMask CS.UnityEngine.Rendering.ShadowMapPass
	@queueType CS.UnityEngine.Rendering.ComputeQueueType
--]]
function CS.UnityEngine.Light:AddCommandBufferAsync(evt,buffer,shadowPassMask,queueType) end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
	@buffer CS.UnityEngine.Rendering.CommandBuffer
--]]
function CS.UnityEngine.Light:RemoveCommandBuffer(evt,buffer) end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
--]]
function CS.UnityEngine.Light:RemoveCommandBuffers(evt) end
function CS.UnityEngine.Light:RemoveAllCommandBuffers() end
--[[
	@evt CS.UnityEngine.Rendering.LightEvent
	return CS.UnityEngine.Rendering.CommandBuffer{}
--]]
function CS.UnityEngine.Light:GetCommandBuffers(evt) end
--[[
	@type CS.UnityEngine.LightType
	@layer CS.System.Int32
	return CS.UnityEngine.Light{}
--]]
function CS.UnityEngine.Light:GetLights(type,layer) end

--@SuperType [luaIde#CS.System.ValueType]
CS.UnityEngine.Mathf = {}
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Mathf.PI = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Mathf.Infinity = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Mathf.NegativeInfinity = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Mathf.Deg2Rad = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Mathf.Rad2Deg = nil
--[[
	CS.System.Single
	 Get 	 Set 
--]]
CS.UnityEngine.Mathf.Epsilon = nil
--[[
	@value CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:ClosestPowerOfTwo(value) end
--[[
	@value CS.System.Int32
	return CS.System.Boolean
--]]
function CS.UnityEngine.Mathf:IsPowerOfTwo(value) end
--[[
	@value CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:NextPowerOfTwo(value) end
--[[
	@value CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:GammaToLinearSpace(value) end
--[[
	@value CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:LinearToGammaSpace(value) end
--[[
	@kelvin CS.System.Single
	@return [luaIde#CS.UnityEngine.Color]
--]]
function CS.UnityEngine.Mathf:CorrelatedColorTemperatureToRGB(kelvin) end
--[[
	@val CS.System.Single
	return CS.System.UInt16
--]]
function CS.UnityEngine.Mathf:FloatToHalf(val) end
--[[
	@val CS.System.UInt16
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:HalfToFloat(val) end
--[[
	@x CS.System.Single
	@y CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:PerlinNoise(x,y) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Sin(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Cos(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Tan(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Asin(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Acos(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Atan(f) end
--[[
	@y CS.System.Single
	@x CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Atan2(y,x) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Sqrt(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Abs(f) end
--[[
	@value CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:Abs(value) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Min(a,b) end
--[[
	@values CS.System.Single{}
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Min(values) end
--[[
	@a CS.System.Int32
	@b CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:Min(a,b) end
--[[
	@values CS.System.Int32{}
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:Min(values) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Max(a,b) end
--[[
	@values CS.System.Single{}
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Max(values) end
--[[
	@a CS.System.Int32
	@b CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:Max(a,b) end
--[[
	@values CS.System.Int32{}
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:Max(values) end
--[[
	@f CS.System.Single
	@p CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Pow(f,p) end
--[[
	@power CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Exp(power) end
--[[
	@f CS.System.Single
	@p CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Log(f,p) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Log(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Log10(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Ceil(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Floor(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Round(f) end
--[[
	@f CS.System.Single
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:CeilToInt(f) end
--[[
	@f CS.System.Single
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:FloorToInt(f) end
--[[
	@f CS.System.Single
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:RoundToInt(f) end
--[[
	@f CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Sign(f) end
--[[
	@value CS.System.Single
	@min CS.System.Single
	@max CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Clamp(value,min,max) end
--[[
	@value CS.System.Int32
	@min CS.System.Int32
	@max CS.System.Int32
	return CS.System.Int32
--]]
function CS.UnityEngine.Mathf:Clamp(value,min,max) end
--[[
	@value CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Clamp01(value) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	@t CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Lerp(a,b,t) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	@t CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:LerpUnclamped(a,b,t) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	@t CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:LerpAngle(a,b,t) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@maxDelta CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:MoveTowards(current,target,maxDelta) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@maxDelta CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:MoveTowardsAngle(current,target,maxDelta) end
--[[
	@from CS.System.Single
	@to CS.System.Single
	@t CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothStep(from,to,t) end
--[[
	@value CS.System.Single
	@absmax CS.System.Single
	@gamma CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Gamma(value,absmax,gamma) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	return CS.System.Boolean
--]]
function CS.UnityEngine.Mathf:Approximately(a,b) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@currentVelocity CS.System.Single&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothDamp(current,target,currentVelocity,smoothTime,maxSpeed) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@currentVelocity CS.System.Single&
	@smoothTime CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothDamp(current,target,currentVelocity,smoothTime) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@currentVelocity CS.System.Single&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	@deltaTime CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothDamp(current,target,currentVelocity,smoothTime,maxSpeed,deltaTime) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@currentVelocity CS.System.Single&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothDampAngle(current,target,currentVelocity,smoothTime,maxSpeed) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@currentVelocity CS.System.Single&
	@smoothTime CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothDampAngle(current,target,currentVelocity,smoothTime) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	@currentVelocity CS.System.Single&
	@smoothTime CS.System.Single
	@maxSpeed CS.System.Single
	@deltaTime CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:SmoothDampAngle(current,target,currentVelocity,smoothTime,maxSpeed,deltaTime) end
--[[
	@t CS.System.Single
	@length CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:Repeat(t,length) end
--[[
	@t CS.System.Single
	@length CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:PingPong(t,length) end
--[[
	@a CS.System.Single
	@b CS.System.Single
	@value CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:InverseLerp(a,b,value) end
--[[
	@current CS.System.Single
	@target CS.System.Single
	return CS.System.Single
--]]
function CS.UnityEngine.Mathf:DeltaAngle(current,target) end

--@SuperType [luaIde#CS.System.Object]
CS.UnityEngine.Debug = {}
--[[
	@return [luaIde#CS.UnityEngine.Debug]
]]
function CS.UnityEngine.Debug() end
--[[
	CS.UnityEngine.ILogger
	 Get 
--]]
CS.UnityEngine.Debug.unityLogger = nil
--[[
	CS.System.Boolean
	 Get 	 Set 
--]]
CS.UnityEngine.Debug.developerConsoleVisible = nil
--[[
	CS.System.Boolean
	 Get 
--]]
CS.UnityEngine.Debug.isDebugBuild = nil
--[[
	@start CS.UnityEngine.Vector3
	@end_ CS.UnityEngine.Vector3
	@color CS.UnityEngine.Color
	@duration CS.System.Single
--]]
function CS.UnityEngine.Debug:DrawLine(start,end_,color,duration) end
--[[
	@start CS.UnityEngine.Vector3
	@end_ CS.UnityEngine.Vector3
	@color CS.UnityEngine.Color
--]]
function CS.UnityEngine.Debug:DrawLine(start,end_,color) end
--[[
	@start CS.UnityEngine.Vector3
	@end_ CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Debug:DrawLine(start,end_) end
--[[
	@start CS.UnityEngine.Vector3
	@end_ CS.UnityEngine.Vector3
	@color CS.UnityEngine.Color
	@duration CS.System.Single
	@depthTest CS.System.Boolean
--]]
function CS.UnityEngine.Debug:DrawLine(start,end_,color,duration,depthTest) end
--[[
	@start CS.UnityEngine.Vector3
	@dir CS.UnityEngine.Vector3
	@color CS.UnityEngine.Color
	@duration CS.System.Single
--]]
function CS.UnityEngine.Debug:DrawRay(start,dir,color,duration) end
--[[
	@start CS.UnityEngine.Vector3
	@dir CS.UnityEngine.Vector3
	@color CS.UnityEngine.Color
--]]
function CS.UnityEngine.Debug:DrawRay(start,dir,color) end
--[[
	@start CS.UnityEngine.Vector3
	@dir CS.UnityEngine.Vector3
--]]
function CS.UnityEngine.Debug:DrawRay(start,dir) end
--[[
	@start CS.UnityEngine.Vector3
	@dir CS.UnityEngine.Vector3
	@color CS.UnityEngine.Color
	@duration CS.System.Single
	@depthTest CS.System.Boolean
--]]
function CS.UnityEngine.Debug:DrawRay(start,dir,color,duration,depthTest) end
function CS.UnityEngine.Debug:Break() end
function CS.UnityEngine.Debug:DebugBreak() end
--[[
	@message CS.System.Object
--]]
function CS.UnityEngine.Debug:Log(message) end
--[[
	@message CS.System.Object
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:Log(message,context) end
--[[
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogFormat(format,args) end
--[[
	@context CS.UnityEngine.Object
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogFormat(context,format,args) end
--[[
	@logType CS.UnityEngine.LogType
	@logOptions CS.UnityEngine.LogOption
	@context CS.UnityEngine.Object
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogFormat(logType,logOptions,context,format,args) end
--[[
	@message CS.System.Object
--]]
function CS.UnityEngine.Debug:LogError(message) end
--[[
	@message CS.System.Object
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:LogError(message,context) end
--[[
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogErrorFormat(format,args) end
--[[
	@context CS.UnityEngine.Object
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogErrorFormat(context,format,args) end
function CS.UnityEngine.Debug:ClearDeveloperConsole() end
--[[
	@exception CS.System.Exception
--]]
function CS.UnityEngine.Debug:LogException(exception) end
--[[
	@exception CS.System.Exception
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:LogException(exception,context) end
--[[
	@message CS.System.Object
--]]
function CS.UnityEngine.Debug:LogWarning(message) end
--[[
	@message CS.System.Object
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:LogWarning(message,context) end
--[[
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogWarningFormat(format,args) end
--[[
	@context CS.UnityEngine.Object
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogWarningFormat(context,format,args) end
--[[
	@condition CS.System.Boolean
--]]
function CS.UnityEngine.Debug:Assert(condition) end
--[[
	@condition CS.System.Boolean
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:Assert(condition,context) end
--[[
	@condition CS.System.Boolean
	@message CS.System.Object
--]]
function CS.UnityEngine.Debug:Assert(condition,message) end
--[[
	@condition CS.System.Boolean
	@message CS.System.String
--]]
function CS.UnityEngine.Debug:Assert(condition,message) end
--[[
	@condition CS.System.Boolean
	@message CS.System.Object
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:Assert(condition,message,context) end
--[[
	@condition CS.System.Boolean
	@message CS.System.String
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:Assert(condition,message,context) end
--[[
	@condition CS.System.Boolean
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:AssertFormat(condition,format,args) end
--[[
	@condition CS.System.Boolean
	@context CS.UnityEngine.Object
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:AssertFormat(condition,context,format,args) end
--[[
	@message CS.System.Object
--]]
function CS.UnityEngine.Debug:LogAssertion(message) end
--[[
	@message CS.System.Object
	@context CS.UnityEngine.Object
--]]
function CS.UnityEngine.Debug:LogAssertion(message,context) end
--[[
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogAssertionFormat(format,args) end
--[[
	@context CS.UnityEngine.Object
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:LogAssertionFormat(context,format,args) end
--[[
	@condition CS.System.Boolean
	@format CS.System.String
	@args CS.System.Object{}
--]]
function CS.UnityEngine.Debug:Assert(condition,format,args) end

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

--@SuperType [luaIde#CS.UnityEngine.MonoBehaviour]
CS.XLuaTest.LuaBehaviour = {}
--[[
	@return [luaIde#CS.XLuaTest.LuaBehaviour]
]]
function CS.XLuaTest.LuaBehaviour() end
--[[
	@RefType [luaIde#CS.UnityEngine.TextAsset]
	 Get 	 Set 
--]]
CS.XLuaTest.LuaBehaviour.luaScript = nil
--[[
	CS.XLuaTest.Injection{}
	 Get 	 Set 
--]]
CS.XLuaTest.LuaBehaviour.injections = nil

--@SuperType [luaIde#CS.System.ValueType]
CS.XLuaTest.Pedding = {}
--[[
	CS.System.Byte
	 Get 	 Set 
--]]
CS.XLuaTest.Pedding.c = nil

--@SuperType [luaIde#CS.System.ValueType]
CS.XLuaTest.MyStruct = {}
--[[
	@p1 CS.System.Int32
	@p2 CS.System.Int32
	@return [luaIde#CS.XLuaTest.MyStruct]
]]
function CS.XLuaTest.MyStruct(p1,p2) end
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.XLuaTest.MyStruct.a = nil
--[[
	CS.System.Int32
	 Get 	 Set 
--]]
CS.XLuaTest.MyStruct.b = nil
--[[
	CS.System.Decimal
	 Get 	 Set 
--]]
CS.XLuaTest.MyStruct.c = nil
--[[
	@RefType [luaIde#CS.XLuaTest.Pedding]
	 Get 	 Set 
--]]
CS.XLuaTest.MyStruct.e = nil

--@SuperType [luaIde#CS.System.Enum]
CS.XLuaTest.MyEnum = {}
--[[
	CS.XLuaTest.MyEnum
	 Get 	 Set 
--]]
CS.XLuaTest.MyEnum.E1 = 0
--[[
	CS.XLuaTest.MyEnum
	 Get 	 Set 
--]]
CS.XLuaTest.MyEnum.E2 = 1

--@SuperType [luaIde#CS.UnityEngine.MonoBehaviour]
CS.XLuaTest.NoGc = {}
--[[
	@return [luaIde#CS.XLuaTest.NoGc]
]]
function CS.XLuaTest.NoGc() end
--[[
	CS.System.Double{}
	 Get 	 Set 
--]]
CS.XLuaTest.NoGc.a1 = nil
--[[
	CS.UnityEngine.Vector3{}
	 Get 	 Set 
--]]
CS.XLuaTest.NoGc.a2 = nil
--[[
	CS.XLuaTest.MyStruct{}
	 Get 	 Set 
--]]
CS.XLuaTest.NoGc.a3 = nil
--[[
	CS.XLuaTest.MyEnum{}
	 Get 	 Set 
--]]
CS.XLuaTest.NoGc.a4 = nil
--[[
	CS.System.Decimal{}
	 Get 	 Set 
--]]
CS.XLuaTest.NoGc.a5 = nil
--[[
	@p CS.System.Single
	return CS.System.Single
--]]
function CS.XLuaTest.NoGc:FloatParamMethod(p) end
--[[
	@p CS.UnityEngine.Vector3
	@return [luaIde#CS.UnityEngine.Vector3]
--]]
function CS.XLuaTest.NoGc:Vector3ParamMethod(p) end
--[[
	@p CS.XLuaTest.MyStruct
	@return [luaIde#CS.XLuaTest.MyStruct]
--]]
function CS.XLuaTest.NoGc:StructParamMethod(p) end
--[[
	@p CS.XLuaTest.MyEnum
	return CS.XLuaTest.MyEnum
--]]
function CS.XLuaTest.NoGc:EnumParamMethod(p) end
--[[
	@p CS.System.Decimal
	return CS.System.Decimal
--]]
function CS.XLuaTest.NoGc:DecimalParamMethod(p) end

--@SuperType [luaIde#CS.UnityEngine.YieldInstruction]
CS.UnityEngine.WaitForSeconds = {}
--[[
	@seconds CS.System.Single
	@return [luaIde#CS.UnityEngine.WaitForSeconds]
]]
function CS.UnityEngine.WaitForSeconds(seconds) end

--@SuperType [luaIde#CS.XLuaTest.BaseTestBase`1[[XLuaTest.InnerTypeTest, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]]
CS.XLuaTest.BaseTest = {}
--[[
	@return [luaIde#CS.XLuaTest.BaseTest]
]]
function CS.XLuaTest.BaseTest() end
--[[
	@p CS.System.Int32
--]]
function CS.XLuaTest.BaseTest:Foo(p) end
--[[
	@p CS.System.Int32
--]]
function CS.XLuaTest.BaseTest:Proxy(p) end
function CS.XLuaTest.BaseTest:ToString() end

--@SuperType [luaIde#CS.System.Object]
CS.XLuaTest.Foo1Parent = {}
--[[
	@return [luaIde#CS.XLuaTest.Foo1Parent]
]]
function CS.XLuaTest.Foo1Parent() end

--@SuperType [luaIde#CS.System.Object]
CS.XLuaTest.Foo2Parent = {}
--[[
	@return [luaIde#CS.XLuaTest.Foo2Parent]
]]
function CS.XLuaTest.Foo2Parent() end

--@SuperType [luaIde#CS.XLuaTest.Foo1Parent]
CS.XLuaTest.Foo1Child = {}
--[[
	@return [luaIde#CS.XLuaTest.Foo1Child]
]]
function CS.XLuaTest.Foo1Child() end

--@SuperType [luaIde#CS.XLuaTest.Foo2Parent]
CS.XLuaTest.Foo2Child = {}
--[[
	@return [luaIde#CS.XLuaTest.Foo2Child]
]]
function CS.XLuaTest.Foo2Child() end

--@SuperType [luaIde#CS.System.Object]
CS.XLuaTest.Foo = {}
--[[
	@return [luaIde#CS.XLuaTest.Foo]
]]
function CS.XLuaTest.Foo() end

--@SuperType [luaIde#CS.System.Object]
CS.XLuaTest.FooExtension = {}

--@SuperType [luaIde#CS.System.Object]
CS.Util.Listener = {}
--[[
	@RefType [luaIde#CS.Util.Listener]
	 Get 
--]]
CS.Util.Listener.Instance = nil
function CS.Util.Listener:Init() end
--[[
	@code CS.System.Int32
	@action CS.Util.Listener.AsyncCall
--]]
function CS.Util.Listener:Register(code,action) end
--[[
	@code CS.System.Int32
	@o1 CS.System.Object
	@o2 CS.System.Object
	@o3 CS.System.Object
--]]
function CS.Util.Listener:Call(code,o1,o2,o3) end

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

CS.Pool.IPool = {}
function CS.Pool.IPool:Create() end
--[[
	@value CS.System.Object
	return CS.System.Boolean
--]]
function CS.Pool.IPool:Store(value) end
--[[
	@value CS.System.Object
--]]
function CS.Pool.IPool:Destory(value) end
function CS.Pool.IPool:Get() end
function CS.Pool.IPool:GetUnique() end
function CS.Pool.IPool:Size() end
function CS.Pool.IPool:AutoResize() end
--[[
	@size CS.System.Int32
	return CS.System.Boolean
--]]
function CS.Pool.IPool:Expand(size) end

--@SuperType [luaIde#CS.System.Object]
CS.Pool.ObjectPool = {}
--[[
	@maxSize CS.System.Int32
	@return [luaIde#CS.Pool.ObjectPool]
]]
function CS.Pool.ObjectPool(maxSize) end
--[[
	@p CS.UnityEngine.Object
	@return [luaIde#CS.System.Object]
--]]
function CS.Pool.ObjectPool:Create(p) end
function CS.Pool.ObjectPool:Create() end
--[[
	@value CS.System.Object
	return CS.System.Boolean
--]]
function CS.Pool.ObjectPool:Store(value) end
--[[
	@value CS.System.Object
--]]
function CS.Pool.ObjectPool:Destory(value) end
function CS.Pool.ObjectPool:Get() end
function CS.Pool.ObjectPool:GetUnique() end
function CS.Pool.ObjectPool:Size() end
function CS.Pool.ObjectPool:AutoResize() end
--[[
	@size CS.System.Int32
	return CS.System.Boolean
--]]
function CS.Pool.ObjectPool:Expand(size) end

--@SuperType [luaIde#CS.System.Object]
CS.Pool.PoolManager = {}
--[[
	@return [luaIde#CS.Pool.PoolManager]
]]
function CS.Pool.PoolManager() end

--@SuperType [luaIde#CS.System.Object]
CS.Net.NetHelper = {}
function CS.Net.NetHelper:GetInstance() end
function CS.Net.NetHelper:Init() end
--[[
	@msg CS.Util.Msg
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
function CS.Net.NetHelper:Connect() end
function CS.Net.NetHelper:Disconnect() end
function CS.Net.NetHelper:Update() end
--[[
	@version CS.System.String
	return CS.System.Boolean
--]]
function CS.Net.NetHelper:CheckVersion(version) end

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
	@RefType [luaIde#CS.System.Object]
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
	@RefType [luaIde#CS.System.Object]
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
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].startValue = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
	 Get 	 Set 
--]]
CS.DG.Tweening.Core.TweenerCore`3[[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[UnityEngine.Vector3, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[DG.Tweening.Plugins.Options.VectorOptions, DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]].endValue = nil
--[[
	@RefType [luaIde#CS.UnityEngine.Vector3]
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

