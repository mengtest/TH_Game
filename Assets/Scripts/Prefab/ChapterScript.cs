using System;
using Game.Entity.Chapters;
using Global;
using Prefab;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using XLua;
using Object = UnityEngine.Object;

namespace Tutorial
{
        [LuaCallCSharp]
        public class LuaCallCsTest
        {
            public static void Call()
            {
                var obj = ChapterScript.CreateChapter(null);
                obj.transform.SetParent(Object.FindObjectOfType<Canvas>().transform);
                obj.transform.position = new Vector3();
                obj.transform.localScale = new Vector3(1, 1, 1);
            }
        }
}

namespace Prefab
{
    public class ChapterScript : MonoBehaviour
    {
//        [HideInInspector]
        [Tooltip("章节的标题")]
        public Text Content;

//        [HideInInspector]
        [Tooltip("章节名")]
        public Text Title;

        
//        [HideInInspector]
        [Tooltip("文字所在区域的图片")]
        public RawImage Background;
        
        [Tooltip("背景图片")]
        public Image BackgroundImage;

        //之所以不写死是为了方便之后对这个组件的功能做扩展
        private Action _buttonDown;

        //通过一个章节信息创建章节对象
        public static GameObject CreateChapter(Chapter chapterInfo)
        {
            //直接通过预制资源创建这个对象
            var ins = Instantiate(Resources.Load("Prefab/Chapter")) as GameObject;

            if (ins == null)
            {
                return ins;
            }
            
            if (chapterInfo != null)
            {
                ins.name = chapterInfo.Name;
                
                var obj = ins.GetComponent<ChapterScript>();
                obj.AddButtonClickEvent(() =>
                {
                    Navigator.NavigateTo(chapterInfo.Scene);
                });
                
                obj.BackgroundImage.sprite = Resources.Load<Sprite>(chapterInfo.Img);
                obj.Title.text = chapterInfo.Name;
                obj.Content.text = chapterInfo.Content;
            }
            else
            {
                //如果走的这一条分支的话，那么现实出来的章节将不带有任何效果
                ins.name = "Chapter";
            }

            return ins;
        }

//        private void Start()
//        {
//            var luaEngine = LuaEngine.LuaEngine.Instance();
//            luaEngine.DoString(Resources.Load<TextAsset>("LuaScript/Chapter.lua").text);
//            luaEngine.Global.Get("button_down", out buttonDown);
//        }
//        private void OnEnable()
//        {
//            
//        }

        private void Start()
        {
            //在所有组件都创建好，并且对象关系明确之后对章节做出初始化
            transform.localPosition = new Vector3();
            transform.localScale = new Vector3(1, 1, 1);
        }

        public void AddButtonClickEvent(Action action)
        {
            _buttonDown += action;
        }

        //点击这个组件之后跳转到对应的场景之中
        private void OnMouseDown()
        {
            Debug.Log(this.name);
        }

        //当鼠标弹起的时候触发这个事件，跳转到标题对应的场景
        private void OnMouseUpAsButton()
        {
            //主要就是场景的跳转
            _buttonDown?.Invoke();
        }

        //鼠标悬浮在章节目录选择器上面的事件
        private void OnMouseOver()
        {
            Debug.Log(this.name);
        }
    }
}