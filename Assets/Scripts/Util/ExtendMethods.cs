using System;
using Common;
using UnityEngine;
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
            var rect1MinX = self.position.x - self.rect.width * self.pivot.x;
            var rect1MaxX = self.position.x + self.rect.width * (1- self.pivot.x);
            var rect1MinY = self.position.y - self.rect.height * self.pivot.y;
            var rect1MaxY = self.position.y + self.rect.height * (1- self.pivot.y);

            var rect2MinX = rect.position.x - rect.rect.width * rect.pivot.x;
            var rect2MaxX = rect.position.x + rect.rect.width * (1- rect.pivot.x);
            var rect2MinY = rect.position.y - rect.rect.height * rect.pivot.y;
            var rect2MaxY = rect.position.y + rect.rect.height * (1- rect.pivot.y);

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
            var rect1MinX = self.position.x - self.rect.width * self.pivot.x;
            var rect1MaxX = self.position.x + self.rect.width * (1- self.pivot.x);
            var rect1MinY = self.position.y - self.rect.height * self.pivot.y;
            var rect1MaxY = self.position.y + self.rect.height * (1- self.pivot.y);

            var rect2MinX = rect.position.x - rect.rect.width * rect.pivot.x;
            var rect2MaxX = rect.position.x + rect.rect.width * (1- rect.pivot.x);
            var rect2MinY = rect.position.y - rect.rect.height * rect.pivot.y;
            var rect2MaxY = rect.position.y + rect.rect.height * (1- rect.pivot.y);

            var inX = rect1MinX >= rect2MinX && rect1MaxX <= rect2MaxX;
            var inY = rect1MinY >= rect2MinY && rect1MaxY <= rect2MaxY;
            
            // self.rect.Contains()
            
            return inX && inY;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static bool Contain(this RectTransform self, Vector3 point)
        {
            var minX = self.position.x - self.rect.width * self.pivot.x;
            var maxX = self.position.x + self.rect.width * (1- self.pivot.x);
            var minY = self.position.y - self.rect.height * self.pivot.y;
            var maxY = self.position.y + self.rect.height * (1- self.pivot.y);
            Global.Log("1223123123");
            return point.x >= minX && point.x <= maxX && point.y >= minY && point.y <= maxY;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static bool Contain(this RectTransform self, Vector2 point)
        {
            var minX = self.position.x - self.rect.width * self.pivot.x;
            var maxX = self.position.x + self.rect.width * (1- self.pivot.x);
            var minY = self.position.y - self.rect.height * self.pivot.y;
            var maxY = self.position.y + self.rect.height * (1- self.pivot.y);

            return point.x >= minX && point.x <= maxX && point.y >= minY && point.y <= maxY;
        }

        /// <summary>
        /// 如果直接调用unity的api的话，可能会因为模糊重载而无法取得hit参数
        /// </summary>
        /// <returns></returns>
        public static bool InnocentRayHit(this Vector3 point, out RaycastHit hit)
        {
            var ray = Camera.main.ScreenPointToRay(point);
            return Physics.Raycast(ray, out hit);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static bool Clicked(this Transform self)
        {
            var ray = new RaycastHit2D();
            
            return true;
        }
        
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="self"></param>
        /// <param name="name"></param>
        /// <returns></returns>
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
        
        /// <summary>
        /// 
        /// </summary>
        public static void AddClickEvent(this RectTransform self, string signal)
        {
            if (self.GetComponent<Clickable>() == null)
            {
                var clickable = self.gameObject.AddComponent<Clickable>();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doTween"></param>
        /// <param name="act"></param>
        /// <returns></returns>
        public static DG.Tweening.Tween Complete(this DG.Tweening.Tween doTween, DG.Tweening.TweenCallback act)
        {
            doTween.onComplete += act;
            return doTween;
        }
    }
}