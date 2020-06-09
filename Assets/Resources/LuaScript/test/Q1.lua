---------------------------------------------------------------------
-- Project: THGame
-- Created by: yuki@代壮
-- Date: 2020-06-09 16:53:32
---------------------------------------------------------------------

---@class Base 基类
local Base = {}

function Base:new(o)
	o = o or {}
	setmetatable(o, self)
	self.__index = self
	return o
end

function Base:hello()
	print(self.name)
end

function Base:calc()
	if self.width and self.height then
		self.rect = self.width * self.height
	end
	return self.rect or 0
end

function Base.init()
	print "你调用了init方法"
end

---@class Child:Base 子类1
local Child = Base:new()
function Child:hello()
	print(self.name)
	print(self.rect)
	print(self)
end

---@class Child2:Base 子类2
local Child2 = Base:new()
function Child2:hello()
	print("123123")
	print(self.rect)
end

function Child2:asd()
	print(self)
end

local child = Child:new({width = 100, height = 50})
print(child:calc())
child:hello()
child.init()

local child2 = Child2:new()
print(child2:calc())
child2:hello()
child2:asd()
child2.init()

print(getmetatable(getmetatable(child)))
print(getmetatable(getmetatable(child2)))


---以下为正式的答案代码

---@class Pawn
local pawn = {}


---@class IBuff
local IBuff = {
	_id = 0,
	_name = "",
	_type = "",
	_pawn = pawn,
}

function IBuff:new(o)
	o = o or {}
	setmetatable(o, self)
	self.__index = self
	return o
end

function IBuff:execute()
	
end

local Buff1 = IBuff:new()
function Buff1:execute()
		
end

local Buff2 = IBuff:new()
function Buff2:execute()
	
end