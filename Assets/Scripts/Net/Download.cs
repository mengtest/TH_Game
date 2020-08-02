using System.Collections;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using XLua;

namespace Net
{
    //从服务端上下载文件
    [LuaCallCSharp]
    public class Download : MonoBehaviour
    {
        private UnityWebRequest request;

        public static bool Has(string name)
        {  
            return false;
        }

        public void Begin(string uri)
        {
            StartCoroutine(DownLoad(uri));
        }

        public IEnumerator DownLoad(string uri)
        {
            using (request = UnityWebRequest.Get(uri))
            {
                // request.
                request.SendWebRequest();
                while (!request.downloadHandler.isDone)
                {
                    Global.Log(request.downloadProgress);
                    yield return 1;
                }
                Global.Log(request.downloadProgress);
            
                if (request.isNetworkError)
                {
                    Global.Log("下载文件时遇到了错误");
                }
                else
                {
                    Global.Log(request.downloadedBytes);
                }
            }
            
            
            // else
            // {
            //     File.WriteAllBytes("Res/target_name", request.downloadHandler.data);
            //     
            //     // var ab = AssetBundle.LoadFromMemory(request.downloadHandler.data);
            //     // if (ab.Contains("Ocean1"))
            //     // {
            //     //     var sp = ab.LoadAsset<Sprite>("Ocean1");
            //     //     var go = new GameObject();
            //     //     go.AddComponent<Image>().sprite = Sprite.Instantiate(sp);
            //     //     go.transform.SetParent(Global.GetCurCanvas().transform, true);
            //     //     go.transform.localPosition = Vector3.zero;
            //     // }
            //     // Debug.Log(request.downloadHandler.text);
            //     // Debug.Log(request.downloadedBytes);
            // }
        }
    }
}