using EX;
using Prefab;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Editor
{
    public static class EditorExtend
    {
        [MenuItem("GameObject/yuki/ButtonGroup")]
        public static void AddGroupButton()
        {
            var obj = (GameObject)Object.Instantiate(Resources.Load("Prefab/panel"));
            obj.name = "ButtonGroup";
        }
        
        [MenuItem("GameObject/yuki/ButtonEX")]
        public static void AddButtonEx()
        {
            var btnEx = new GameObject("ButtonEX", typeof(ButtonEx));
            var text = new GameObject("Text", typeof(Text));
            text.GetComponent<Text>().text = "Button";
            text.GetComponent<Text>().color = Color.black;
            text.transform.parent = btnEx.transform;
        }
        
        [MenuItem("GameObject/yuki/EnemyBoard")]
        public static GameObject AddEnemyBoard()
        {
            var obj = Object.Instantiate(Resources.Load("Prefab/EnemyBoard")) as GameObject;
            if (obj != null)
            {
                obj.name = "EnemyBoard";
            }
            return obj;
        }
        
        [MenuItem("GameObject/yuki/SelfBoard")]
        public static GameObject AddSelfBoard()
        {
            var obj = Object.Instantiate(Resources.Load("Prefab/SelfBoard")) as GameObject;
            if (obj != null)
            {
                obj.name = "SelfBoard";
            }
            return obj;
        }
        
//        [MenuItem("GameObject/yuki/Card")]
//        public static void AddCard()
//        {
//            var card = Object.Instantiate(Resources.Load("Prefab/Card")) as GameObject;
//            if (card != null)
//            {
//                card.GetComponent<CardView>()._content = 
//                    Resources.Load<Sprite>("Card/alice_big_png");
//                //CardCtrl就是Ctrl
//                card.AddComponent<CardCtrl>();
//                //CardModel就是Model
//                var model =  card.AddComponent<CardModel>();
//                model.Init("alice");
//                card.name = "alice";
//            }
//        }
        
        [MenuItem("GameObject/yuki/Chapter")]
        public static void AddChapter()
        {
            var obj = ChapterScript.CreateChapter(null);
            obj.transform.SetParent(Object.FindObjectOfType<Canvas>().transform);
            obj.transform.position = new Vector3();
            obj.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}