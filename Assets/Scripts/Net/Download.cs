using System.Collections;
using UnityEngine.Networking;

namespace Net
{
    //从服务端上下载文件
    public class Download
    {
        private UnityWebRequest request;

        public static bool Has(string name)
        {  
            return false;
        }

        public IEnumerator DownLoad(string name)
        {
            request = UnityWebRequestAssetBundle.GetAssetBundle("123");
            request.SendWebRequest();
            yield return request.SendWebRequest();
        }
    }
}