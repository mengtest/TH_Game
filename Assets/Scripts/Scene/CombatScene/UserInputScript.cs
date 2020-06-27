using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Prefab;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Scene.CombatScene
{
    /// <summary>
    /// 这里是处理用户与战斗场景中对象层交互的脚本
    /// </summary>
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

            // GetComponent<PlayerInput>().onActionTriggered += context =>
            // {
            //     Global.Log(context.action.name);
            // };
            // GetComponent<PlayerInput>().uiInputModule.leftClick.action.started += Click;
            // GetComponent<PlayerInput>().uiInputModule.leftClick.action.canceled += Click;
            // GetComponent<PlayerInput>().uiInputModule.leftClick.action.performed += Click;
            // // fActions
            // Action<InputAction.CallbackContext> tellMeYourName = (context) =>
            // {
            //     // context.control.device.ReadValueAsObject();
            //     Debug.Log("my keyboard is " + context.action.activeControl);
            // };
            //
            // fActions.performed += tellMeYourName;
            // GetComponent<PlayerInput>().
            fMouseUp.performed += MouseUpEvent;
        }

        public void MouseUpEvent(InputAction.CallbackContext context)
        {
            // //用户鼠标弹起的时候，发出一条射线，检测是否与slot层发生碰撞
            
            // var list = GraphicRaycaster(Mouse.current.position.ReadValue());
            // var flag = false;
            // foreach (var l in list)
            // {
            //     var script = l.gameObject.GetComponent<CombatPanelSlotScript>();
            //     if (script != null)
            //     {
            //         Global.Log(script.name);
            //         Global.Log(script.GetCurSlotIndex().ToString());
            //     } 
            // }
            
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Global.Log(hit.collider.transform.name);
            }
            // ————————————————
            // 版权声明：本文为CSDN博主「烧仙草奶茶」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
            // 原文链接：https://blog.csdn.net/K86338236/article/details/100046076
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

        public void OnClick(string name1)
        {
            // Global.Log(name1);
        }


        // public void OnPointerUp(PointerEventData eventData)
        // {
        //     Global.Log("点击了UserInput层");
        // }
        //
        // public void OnPointerDown(PointerEventData eventData)
        // {
        //     Global.Log("点击了UserInput层");
        // }
        //
        // public void OnPointerClick(PointerEventData eventData)
        // {
        //     Global.Log("点击了UserInput层");
        // }
        
        
    }
}