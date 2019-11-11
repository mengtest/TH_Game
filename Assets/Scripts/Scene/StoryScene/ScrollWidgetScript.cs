using EX;
using Prefab;
using UnityEngine;
using UnityEngine.UI;

namespace StoryScene
{
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(CanvasRenderer))]
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(ScrollViewEx))]
    public class ScrollWidgetScript : MonoBehaviour
    {
        //添加一个ScrollEx对象
//        [MenuItem("GameObject/yuki/ScrollEx")]
        public static void AddScrollEx()
        {
            var scroll = CreateScrollEx();
            scroll.transform.SetParent(GameObject.FindObjectOfType<Canvas>().transform);
            scroll.transform.localScale = Vector3.one;
            scroll.transform.position = Vector3.zero;
        }
        
        public static GameObject CreateScrollEx()
        {
            var scroll = Instantiate(Resources.Load("Prefab/ScrollView")) as GameObject;
            if (scroll != null)
            {
                scroll.name = "Scroll View";
            }
            return scroll;
        }

//        private void Awake()
//        {
//            luaenv = new XLua.LuaEnv();
//            var scriptEnv = luaenv.NewTable();
//            LuaTable meta = luaenv.NewTable();
//            meta.Set("__index", luaenv.Global);
//            scriptEnv.SetMetaTable(meta);
//            meta.Dispose();
//            scriptEnv.Set("self", this);
//            luaenv.DoString(text.text, "Data", scriptEnv);
//            scriptEnv.Get("start", out start);
//            scriptEnv.Get("update",out update);
//        }

        private void OnEnable()
        {
            ContentInit();
            
            this.GetComponent<ScrollRect>().onValueChanged.AddListener(Scrolled);
        }

        //所有章节信息的初始化
        private void ContentInit()
        {
            var view = GetComponent<ScrollViewEx>();
            var array = Global.ResourceManager.Instance.Chapters.ChaptersChapters;
            Transform[] trans = new Transform[array.Length];
            for (int index = 0; index < array.Length; index++)
            {
                trans[index] = ChapterScript.CreateChapter(array[index]).transform;
            }
            view.AddChildren(trans);
        }

        private void Scrolled(Vector2 vec)
        {
            Debug.Log(vec);
        }

        private void OnMouseDown()
        {
            Debug.Log("MouseDown");
        }
    }
}