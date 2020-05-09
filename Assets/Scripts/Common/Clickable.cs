using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Common
{
    /// <summary>
    /// 可点击对象
    /// </summary>
    [LuaCallCSharp]
    public class Clickable: MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        // private string _signal;

        /// <summary>
        /// 
        /// </summary>
        [LuaCallCSharp]
        [CSharpCallLua]
        public delegate void Func();

        /// <summary>
        /// 
        /// </summary>
        [LuaCallCSharp]
        [CSharpCallLua]
        public event Func clickEvent;

        private void Awake()
        {
            clickEvent = () => { };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerClick(PointerEventData eventData)
        {
            clickEvent?.Invoke();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerDown(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventData"></param>
        public void OnPointerUp(PointerEventData eventData)
        {
            // throw new System.NotImplementedException();
        }
    }
}