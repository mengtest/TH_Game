using UnityEngine;
using UnityEngine.UI;

namespace Prefab
{
    public class ToastScript: MonoBehaviour
    {
        [Tooltip("toast对应的文本")]
        public Text content;
        
        public RectTransform imageRect;

        public int maxWidth = 500;
        public int maxHeight = 300;

        public void Make(string text, float sec)
        {
            content.text = text;
            Redraw();
            Destroy(gameObject, sec);
        }

        private void Awake()
        {
            if (imageRect == null)
            {
                imageRect = GetComponent<RectTransform>();
                content.alignment = TextAnchor.MiddleCenter;
            }
            
            Redraw();
        }

        public void Redraw()
        {
            if (imageRect == null)
            {
                imageRect = GetComponent<RectTransform>();
            }
            
            GetChineseEnglishNumber(content.text, out var c, out var e);
            
            var size = content.fontSize;
            var width = size * (c + e / 2 + 1);

            if (width > maxWidth)
            {
                width = maxWidth;
            }

            var textRect = content.GetComponent<RectTransform>();
            textRect.sizeDelta = new Vector2(width, maxHeight);
            var preferredHeight = content.preferredHeight;
            var height = preferredHeight > maxHeight ? maxHeight : preferredHeight;

            imageRect.sizeDelta = new Vector2(width + 30 * 2, height + 10 * 2);

            textRect.sizeDelta = new Vector2(width, height);
        }

        private void OnGUI()
        {
            Redraw();
        }

        private void GetChineseEnglishNumber(string str, out int chinese, out int english)
        {
            int c = 0;
            int e = 0;
            foreach (var ch in str)
            {
                if (ch > 127)
                {
                    c++;
                }
                else
                {
                    e++;
                }
            }
            chinese = c;
            english = e;
        }
    }
}