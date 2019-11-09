using UnityEngine;

namespace StartScene
{
    public class Background : MonoBehaviour
    {
        //背景图片
        public Sprite bg = null;
        //x轴上的缩放
        public float scaleX;
        //y轴上的缩放
        public float scaleY;

        // Start is called before the first frame update
        void Start()
        {
        
//        var prefab = Resources.Load<Sprite>(path);
//        this.gameObject.AddComponent<SpriteRenderer>().sprite = prefab;

            var render =  this.gameObject.AddComponent<SpriteRenderer>();
            render.sprite = bg;
            this.GetComponent<Transform>().localScale = new Vector3(scaleX, scaleY);
            this.GetComponent<Transform>().localPosition = new Vector3(0, 0, 1);
        }

        // Update is called once per frame
//    void Update()
//    {
//        
//    }
    }
}
