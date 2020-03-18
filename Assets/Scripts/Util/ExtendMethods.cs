﻿using UnityEngine;
using XLua;

namespace Util
{
    [LuaCallCSharp]
    public static class ExtendMethods
    {
        /**
         * <summary>
         *  self与rect是否相交(由重合的部分)
         * </summary>
         */
        public static bool IsOverlap(this RectTransform self, RectTransform rect)
        {
            var rect1MinX = self.position.x - self.rect.width / 2;
            var rect1MaxX = self.position.x + self.rect.width / 2;
            var rect1MinY = self.position.y - self.rect.height / 2;
            var rect1MaxY = self.position.y + self.rect.height / 2;

            var rect2MinX = rect.position.x - rect.rect.width / 2;
            var rect2MaxX = rect.position.x + rect.rect.width / 2;
            var rect2MinY = rect.position.y - rect.rect.height / 2;
            var rect2MaxY = rect.position.y + rect.rect.height / 2;

            var xNotOverlap = rect1MaxX < rect2MinX || rect2MaxX < rect1MinX;
            var yNotOverlap = rect1MaxY < rect2MinY || rect2MaxY < rect1MinY;

            var notOverlap = xNotOverlap || yNotOverlap;

            return !notOverlap;
        }

        /**
         * <summary>
         * self是否在rect内部
         * </summary>
         */
        public static bool IsInRect(this RectTransform self, RectTransform rect)
        {
            var rect1MinX = self.position.x - self.rect.width / 2;
            var rect1MaxX = self.position.x + self.rect.width / 2;
            var rect1MinY = self.position.y - self.rect.height / 2;
            var rect1MaxY = self.position.y + self.rect.height / 2;

            var rect2MinX = rect.position.x - rect.rect.width / 2;
            var rect2MaxX = rect.position.x + rect.rect.width / 2;
            var rect2MinY = rect.position.y - rect.rect.height / 2;
            var rect2MaxY = rect.position.y + rect.rect.height / 2;

            var inX = rect1MinX >= rect2MinX && rect1MaxX <= rect2MaxX;
            var inY = rect1MinY >= rect2MinY && rect1MaxY <= rect2MaxY;

            return inX && inY;
        }

        [LuaCallCSharp]
        [CSharpCallLua]
        public static Transform GetChildByName(Transform self, string name)
        {
            foreach (Transform value in self)
            {
                if (value.name == name)
                {
                    return value;
                }
            }
            return null;
        }
    }
}