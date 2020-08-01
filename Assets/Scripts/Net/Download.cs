using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
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
            request = UnityWebRequest.Get(name);
            yield return request.SendWebRequest();
            if (request.isNetworkError)
            {
                Global.Log("error");
            }
            else
            {
                Debug.Log(request.downloadHandler.text);
                Debug.Log(request.downloadedBytes);
            }
        }
    }
}