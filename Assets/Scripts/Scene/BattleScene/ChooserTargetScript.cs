using System;
using UnityEngine;

namespace BattleScene
{
    public class ChooserTargetScript : MonoBehaviour
    {
        private static ChooserTargetScript _instance;
        
        public static ChooserTargetScript Current()
        {
            if (_instance == null)
            {
//                //如果这个实例对象没有
//                var obj = new GameObject("TargetChooser");
//                var img = obj.AddComponent<Image>();
//                img.sprite = Resources.Load<Sprite>("");
//                img.color = Color.red;
//                _instance = obj.GetComponent<ChooserTargetScript>();
//                //因为这个对象是一个ui元素，所以需要添加到画布上
//                obj.transform.SetParent(Object.FindObjectOfType<Canvas>().transform);
//                obj.transform.localScale = new Vector3(2, 2, 1);
                throw new Exception("error");
            }
            return _instance;
        }

        private void Awake()
        {
            //如果已经存在了一个描述的实例的话，则创建新的实例之前，将之前的实例删除
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            this.Hide();
        }

        public void SetOriginPosition(Vector3 position)
        {
            transform.position = position;
        }

        public void SetTargetPosition(Vector3 position)
        {
            //主要是计算角度
//            var quaternion = new Quaternion();
            
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public bool Visible()
        {
            return gameObject.activeSelf;
        }
    }
}