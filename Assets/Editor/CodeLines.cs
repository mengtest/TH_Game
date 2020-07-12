using System;
using System.IO;
using UnityEngine;
using UnityEditor;
 
public class CodeLines
{
    [MenuItem("输出总代码行数/输出")]
    private static void PrintTotalLine()
    {
        string[] fileName = Directory.GetFiles("Assets/Scripts", "*.cs", SearchOption.AllDirectories);
        string[] fileName2 = Directory.GetFiles("Assets/Resources/LuaScript/", "*.txt", SearchOption.AllDirectories);
        string[] fileName3 = Directory.GetFiles("Assets/Resources/LuaScript/", "*.lua", SearchOption.AllDirectories);
 
        int totalLine = 0;
        foreach (var temp in fileName)
        {
            int nowLine = 0;
            StreamReader sr = new StreamReader(temp);
            while (sr.ReadLine() != null)
            {
                nowLine++;
            }
            
            totalLine += nowLine;
        }
        
        foreach (var temp in fileName2)
        {
            int nowLine = 0;
            StreamReader sr = new StreamReader(temp);
            while (sr.ReadLine() != null)
            {
                nowLine++;
            }
            
            totalLine += nowLine;
        }
        
        foreach (var temp in fileName3)
        {
            int nowLine = 0;
            StreamReader sr = new StreamReader(temp);
            while (sr.ReadLine() != null)
            {
                nowLine++;
            }
            
            totalLine += nowLine;
        }
 
        Debug.Log(String.Format("总代码行数：{0}", totalLine));
    }
    
    [MenuItem("Assets/Sprite Sheet Packer/Process to Sprites")]
    static void ProcessToSprite()
    {
        Texture2D image = Selection.activeObject as Texture2D;//获取旋转的对象
        string rootPath = Path.GetDirectoryName(@"D:\projects\unity\THGame3\THGame3\Assets\Resources\Image\UI\");//获取路径名称
        string path = "Assets/Resources/Image/UI" + image.name + ".bmp";//图片路径名称

        TextureImporter texImp = AssetImporter.GetAtPath(path) as TextureImporter;
        
        // AssetDatabase.CreateFolder(rootPath, image.name);//创建文件夹

        foreach (SpriteMetaData metaData in texImp.spritesheet)//遍历小图集
        {
            Texture2D myimage = new Texture2D((int)metaData.rect.width, (int)metaData.rect.height);

            for (int y = (int)metaData.rect.y; y < metaData.rect.y + metaData.rect.height; y++)//Y轴像素
            {
                for (int x = (int)metaData.rect.x; x < metaData.rect.x + metaData.rect.width; x++)
                    myimage.SetPixel(x - (int)metaData.rect.x, y - (int)metaData.rect.y, image.GetPixel(x, y));
            }

            //转换纹理到EncodeToPNG兼容格式
            if (myimage.format != TextureFormat.ARGB32 && myimage.format != TextureFormat.RGB24)
            {
                Texture2D newTexture = new Texture2D(myimage.width, myimage.height);
                newTexture.SetPixels(myimage.GetPixels(0), 0);
                myimage = newTexture;
            }
            var pngData = myimage.EncodeToPNG();

            File.WriteAllBytes(rootPath + "/" + image.name + "/" + metaData.name + ".PNG", pngData);
        }
    }
    // ————————————————
    // 版权声明：本文为CSDN博主「angelsmiles」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
    // 原文链接：https://blog.csdn.net/angelsmiles/article/details/50464369
}