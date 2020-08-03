using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Windows;
using XLua;

namespace Net
{
    //从服务端上下载文件
    //现在需要的功能是，任何的下载都会有一个弹窗，在弹窗中间显示有一个进度条，右边有当前的进度
    //中间上方有当前下载的内容的大小，以及要下载的资源的大小
    //有一个暂停的按钮，点击暂停之后暂停下载，并且按钮切换成继续
    //同时还有一个取消的按钮，点击后取消下载
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

        public void Begin(string[] uri)
        {
            StartCoroutine(DownLoad(uri[0]));
        }

        private void RefreshProgress(double value)
        {
            //

        }

        //所有下载的文件资源都会随机
        private void Save(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        public IEnumerator DownLoad(string uri)
        {
            using (request = UnityWebRequest.Get(uri))
            {
                int index = 10;
                request.SendWebRequest();
                while (!request.downloadHandler.isDone)
                {
                    index++;
                    switch (index % 30)
                    {
                        //每30次刷新一次界面
                        case 0:
                        {
                            RefreshProgress(request.downloadProgress);
                            yield break;
                        }
                        default:
                        {
                            yield break;
                        }
                    }
                    // yield return 1;
                }

                // char[] delm = {"AssetBundles/"};
                //所有放在资源服务器上的资源文件，全部都在AssetBundles路径下面，直接根据这个来切割
                string delm = "AssetBundles/";
                var s = uri.Split(delm.ToCharArray());
                Save(s[s.Length - 1], request.downloadHandler.data);

                //如果想要做暂停继续的功能，好像只能用断点续传来完成
                //要利用DownloadHandle，以及request的abort方法来实现
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