using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Prefab
{
    public class CardDescriptionScript : MonoBehaviour
    {
        [SerializeField]
        private Text _desc;

        private static CardDescriptionScript _instance;

        //这个不会创建对象
        public static CardDescriptionScript Current()
        {
            if (_instance == null)
            {
                //如果这个实例对象没有
                var obj = (GameObject)Instantiate(Resources.Load("Prefab/CardDescription"));
                obj.name = "Description";
                _instance = obj.GetComponent<CardDescriptionScript>();
                //因为这个对象是一个ui元素，所以需要添加到画布上
                obj.transform.SetParent(Object.FindObjectOfType<Canvas>().transform);
                obj.transform.localScale = new Vector3(2, 2, 1);
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
            _desc = GetComponentInChildren<Text>();
        }

        public void Show(string desc)
        {
            _desc.text = desc;
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void Move(Vector3 position)
        {
            transform.position = position;
        }

        public void SetDescription(string desc)
        {
            _desc.text = desc;
        }
    }
}