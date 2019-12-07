using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace EX
{
    //会对给定的图片自动做出切割
    [RequireComponent(typeof(Image))]
    public class SpliceButtonEx : Button
    {
        [Tooltip("图片被切割后的数量")]
        public int count = 2;

        [Tooltip("是否是水平切割")] 
        public bool horiz = true;

        [SerializeField]
        [Tooltip("当前图片是否已经切割过")]
        private bool _spliced = false;

        [SerializeField]
        [Tooltip("按钮最原始的图片")]
        private Sprite _oriSprite;
        
        
        protected override void Awake()
        {
            base.Awake();

            if (!_spliced)
            {
                this.Splice();
            }
        }
        
        
        private void Splice()
        {
            if (count <= 1)
            {
                return;
            }
            
            transition = Transition.SpriteSwap;
            var sp = GetComponent<Image>().sprite;
            if (_oriSprite == null)
            {
                _oriSprite = sp;
            }
            var oriTxture = _oriSprite.texture;

            Texture2D[] textures = null;
            if (horiz)
            {
                var height = oriTxture.height / count;
                textures = Enumerable.Range(0, count).Select(v => new Texture2D(oriTxture.width, height)).ToArray();
                
                for (int i = 0; i < count; i++)
                {
                    for (int w = 0; w < oriTxture.width ; w++)
                    {
                        for (int h = i  * height; h < (i + 1) * height ; h++)
                        {
                            textures[i].SetPixel(w, h, oriTxture.GetPixel(w, h));
                        }
                    }
                    textures[i].Apply();
                }
            }
            else
            {
                var width = oriTxture.width / count;
                textures = Enumerable.Range(0, count).Select(v => new Texture2D(width, oriTxture.height)).ToArray();
                
                for (int i = 0; i < count; i++)
                {
                    for (int w = (i) * width; w < (i + 1) * width ; w++)
                    {
                        for (int h = 0; h < oriTxture.height ; h++)
                        {
                            textures[i].SetPixel(w, h, oriTxture.GetPixel(w, h));
                        }
                    }
                    textures[i].Apply();
                }
            }
            
            var s = Sprite.Create(textures[0], 
                new Rect(0, 0, textures[0].width, textures[0].height),
                new Vector2(1, 1));
//            s.name = "o";
            GetComponent<Image>().sprite = s;

            var sps = new SpriteState();
            if (textures.Length >=2)
            {
                var t = textures[1];
                sps.pressedSprite = Sprite.Create(t, 
                    new Rect(0, 0, t.width, t.height),
                    new Vector2(1, 1));
//                sps.pressedSprite.name = "1";
            }

            if (textures.Length >=3)
            {
                var t = textures[2];
                sps.highlightedSprite = Sprite.Create(t, 
                    new Rect(0, 0, t.width, t.height),
                    new Vector2(1, 1));
//                sps.highlightedSprite.name = "2";
            }

            spriteState = sps;
            _spliced = true;
            GetComponent<Image>().SetNativeSize();
        }
    }
}