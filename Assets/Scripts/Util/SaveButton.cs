using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace Util
{
    /// <summary>
    /// 
    /// </summary>
    public class SaveButton : Button
    {
        protected override void Awake()
        {
            base.Awake();
            onClick.AddListener(() =>
                {
                    SaveTextureToFile(@"D:/projects/unity/THGame//Assets/Resources/Image/UI/123.png",
                        GetComponent<Image>().sprite.texture);
                });
        }

        public void SaveTextureToFile(string file, Texture2D tex)
        {
            // Texture2D text = new Texture2D(tex.width, tex.height);
            // text = tex;
            var bytes = tex.EncodeToPNG();
            // SaveToFile(file, bytes);
            File.WriteAllBytes(file, bytes);
        }

        public void SaveToFile(string file, byte[] data)
        {
            FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write);
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
            //// https://msdn.microsoft.com/library/ms182334.aspx
            //// fs.Dispose();
        }
    }
}