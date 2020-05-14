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
}