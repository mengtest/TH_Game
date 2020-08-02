using UnityEditor;
using UnityEngine.Windows;

namespace Editor
{
    [CustomEditor(typeof(ABPackage))]
    public class ABPackage : UnityEditor.Editor
    {
        [MenuItem("AssetBundles/Build AssetBundles")] //特性
        public static void BuildAssetBundle()
        {
            string dir = "AssetBundles"; //相对路径
            if(!Directory.Exists(dir))   //判断是否存在
            {
                Directory.CreateDirectory(dir);
            }
            BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        }
    }
}