using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace EX
{
    [LuaCallCSharp]
    //会对给定的图片自动做出切割
    [RequireComponent(typeof(Button))]
    public class SpliceButtonEx : MonoBehaviour
    {
        [System.Serializable]
        public enum Direction
        {
            Horiz,
            Vert,
        }
        
        [Tooltip("图片被切割后的数量")]
        public int count = 2;

        [Tooltip("是否是水平切割")] 
        public Direction direction = Direction.Horiz;
        
        [SerializeField]
        [Tooltip("当前图片是否已经切割过")]
        private bool spliced = false;
        
        [SerializeField]
        [Tooltip("按钮最原始的图片")]
        private Sprite oriSprite;

        // private Button _btn; 
        
        private void Awake()
        {
            // _btn = GetComponent<Button>();
            if (!spliced)
            {
                Splice();
            }
        }

        private void Splice()
        {
            if (count <= 1)
            {
                return;
            }

            var btn = this.GetComponent<Button>();
            btn.transition = Selectable.Transition.SpriteSwap;
            var sp = GetComponent<Image>().sprite;
            if (oriSprite == null)
            {
                oriSprite = sp;
            }
            var oriTexture = oriSprite.texture;

            Texture2D[] textures = null;
            if (direction == Direction.Horiz)
            {
                var height = oriTexture.height / count;
                textures = Enumerable.Range(0, count).Select(v => new Texture2D(oriTexture.width, height)).ToArray();
                
                for (int i = 0; i < count; i++)
                {
                    for (int w = 0; w < oriTexture.width ; w++)
                    {
                        for (int h = i  * height; h < (i + 1) * height ; h++)
                        {
                            textures[i].SetPixel(w, h, oriTexture.GetPixel(w, h));
                        }
                    }
                    textures[i].Apply();
                }
            }
            else
            {
                var width = oriTexture.width / count;
                textures = Enumerable.Range(0, count).Select(v => new Texture2D(width, oriTexture.height)).ToArray();
                
                for (int i = 0; i < count; i++)
                {
                    for (int w = (i) * width; w < (i + 1) * width ; w++)
                    {
                        for (int h = 0; h < oriTexture.height ; h++)
                        {
                            textures[i].SetPixel(w, h, oriTexture.GetPixel(w, h));
                        }
                    }
                    textures[i].Apply();
                }
            }
            
            var s = Sprite.Create(textures[0], 
                new Rect(0, 0, textures[0].width, textures[0].height),
                new Vector2(1, 1));
            GetComponent<Image>().sprite = s;

            var sps = new SpriteState();
            if (textures.Length >=2)
            {
                var t = textures[1];
                sps.pressedSprite = Sprite.Create(t, 
                    new Rect(0, 0, t.width, t.height),
                    new Vector2(1, 1));
            }

            if (textures.Length >=3)
            {
                var t = textures[2];
                sps.highlightedSprite = Sprite.Create(t, 
                    new Rect(0, 0, t.width, t.height),
                    new Vector2(1, 1));
            }

            btn.spriteState = sps;
            spliced = true;
            GetComponent<Image>().SetNativeSize();
        }
    }
}