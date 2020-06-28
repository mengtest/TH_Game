using System;
using System.Collections.Generic;
using System.Globalization;
using Prefab;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using XLua;


namespace Scene.CombatScene
{
    /// <summary>
    /// 个人感觉可以这样做，Slot，Panel，Card等协同工作，
    /// 将当前鼠标所在的slot，card等都设置到UserInput当中
    /// 在点击事件等触发的时候在lua端中获取到这些被设置的对象来完成交互
    ///
    /// 这里是处理用户与战斗场景中对象层交互的脚本
    /// 接收玩家的输入并处理，同时处理服务端(Core)的输出
    /// </summary>
    [LuaCallCSharp]
    public class UserInputScript : MonoBehaviour
    {
        [Tooltip("当前玩家的panel")]
        public CombatScenePanelScript myPanel;
        
        [Tooltip("敌方玩家的panel")]
        public CombatScenePanelScript enemyPanel;

        [Tooltip("当前正被玩家拖拽的卡牌")]
        public RectTransform dragCardTransform;

        [Tooltip("当前鼠标所在的卡槽")]
        public CombatPanelSlotScript curSlot;

        private static UserInputScript _instance;

        public InputAction fMouseUp;
        
        public EventSystem eventSystem;
        public GraphicRaycaster graphic;
        
        public static UserInputScript GetCurUserInput()
        {
            return _instance;
        }

        public void RemoveDragObject()
        {
            DestroyImmediate(dragCardTransform.gameObject);
            dragCardTransform = null;
        }

        public int GetCurSlotIndex()
        {
            if (curSlot != null)
            {
                return curSlot.GetCurSlotIndex();
            }
            return -1;
        }

        public int GetCurSlotPlayerId()
        {
            if (curSlot != null)
            {
                return curSlot.GetPlayer();
            }
            return 0;
        }

        public void SetDragObject(CombatSceneCombatCardScript script)
        {
            if (dragCardTransform != null)
            {
                RemoveDragObject();
            }
            else
            {
                dragCardTransform = script.GetComponent<RectTransform>();
            }
        }
        
        public void SetDragObject(RectTransform script)
        {
            if (script.GetComponent<CombatSceneCombatCardScript>() != null)
            {
                if (dragCardTransform != null)
                {
                    RemoveDragObject();
                }
                else
                {
                    dragCardTransform = script;
                }
            }
            else
            {
                throw new Exception($"无法设置{script.name}为拖拽对象");
            }
        }

        public void ResetCurSlot()
        {
            curSlot = null;
        }

        public void SetCurSlot(CombatPanelSlotScript script)
        {
            curSlot = script;
        }

        private void OnEnable()
        {
            fMouseUp.Enable();
        }

        private void OnDisable()
        {
            fMouseUp.Disable();
        }

        private void Awake()
        {
            if (_instance != null)
            {
                DestroyImmediate(_instance.gameObject);
                _instance = null;
            }
            _instance = GetComponent<UserInputScript>();
            
            //射线检测不到目标物体
            //所以现在不再触发鼠标弹起的事件
            // fMouseUp.performed += MouseUpEvent;
        }

        public CombatScenePanelScript GetPanel(int uid)
        {
            if (myPanel.PlayerId == uid)
            {
                return myPanel;
            }
            else if(enemyPanel.PlayerId == uid)
            {
                return enemyPanel;
            }
            else
            {
                return null;
            }
        }

        public void MouseUpEvent(InputAction.CallbackContext context)
        {
            // //用户鼠标弹起的时候，发出一条射线，检测是否与slot层发生碰撞
//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;
//            if (Physics.Raycast(ray, out hit))
//            {
//                Global.Log(hit.collider.transform.name);
//            }
        }
        
        private List<RaycastResult> GraphicRaycaster(Vector2 pos)
        {
            var mPointerEventData = new PointerEventData(eventSystem) {position = pos};
            var results = new List<RaycastResult>();
 
            graphic.Raycast(mPointerEventData, results);
            return results;
        }

        public void Click(InputAction.CallbackContext callback)
        {
            Global.Log(Mouse.current.leftButton.isPressed);
            Global.Log(Mouse.current.rightButton.isPressed);
            
            Global.Log(callback.ReadValue<float>().ToString(CultureInfo.InvariantCulture));
            switch (callback.phase)
            {
                case InputActionPhase.Disabled:
                    Debug.Log("new input system1");
                    break;
                case InputActionPhase.Waiting:
                    Debug.Log("new input system2");
                    break;
                case InputActionPhase.Started:
                    Debug.Log("new input system3");
                    break;
                case InputActionPhase.Performed:
                    Debug.Log("new input system4");
                    break;
                case InputActionPhase.Canceled:
                    Debug.Log("new input system5");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public void Click2(InputAction.CallbackContext callback)
        {
            Global.Log(callback.ReadValue<Vector2>().ToString());
            switch (callback.phase)
            {
                case InputActionPhase.Disabled:
                    Debug.Log("new input system1");
                    break;
                case InputActionPhase.Waiting:
                    Debug.Log("new input system2");
                    break;
                case InputActionPhase.Started:
                    Debug.Log("new input system3");
                    break;
                case InputActionPhase.Performed:
                    Debug.Log("new input system4");
                    break;
                case InputActionPhase.Canceled:
                    Debug.Log("new input system5");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        public void Click3(InputAction.CallbackContext callback)
        {
            
            Global.Log(callback.ReadValue<float>().ToString(CultureInfo.InvariantCulture));
            switch (callback.phase)
            {
                case InputActionPhase.Disabled:
                    Debug.Log("new input system1");
                    break;
                case InputActionPhase.Waiting:
                    Debug.Log("new input system2");
                    break;
                case InputActionPhase.Started:
                    Debug.Log("new input system3");
                    break;
                case InputActionPhase.Performed:
                    Debug.Log("new input system4");
                    break;
                case InputActionPhase.Canceled:
                    Debug.Log("new input system5");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}