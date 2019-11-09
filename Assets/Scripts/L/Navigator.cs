using System;
using System.Collections.Generic;
using LoadingScene;
using UnityEngine;
using UnityEngine.SceneManagement;
using XLua;
using Object = UnityEngine.Object;

namespace L
{
    [LuaCallCSharp]
    public static class Navigator
    {
        private static Stack<int> _sceneStack = new Stack<int>();

        //跳转到name场景中
        //是否需要加载loading界面
        public static void NavigateTo(string name, bool loading = true)
        {
            _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);
            if (!name.Contains("/"))
            {
                name = "Scenes/" + name;
            }

            SceneManager.LoadScene(name);
            //            //序号为2的场景就是loading场景，加载loading场景之后再异步加载我们需要的场景
            //            SceneManager.LoadScene(2);
            //
            //            //实际情况下，感觉这样做就已经达到了需要的效果了
            //            SceneManager.LoadSceneAsync(name).allowSceneActivation = true;

            //如果传入的名字当中没有/的话，说明是相对路径，这里会从Scenes文件夹下面去寻找这个场景
//            NavigateTo(name, 5);
        }

        public static void NavigateTo(string name, int id)
        {
            Debug.Log($"{name},{id}");
        }

        //跳转到id场景中
        //是否需要加载loading界面
        public static void NavigateTo(int id, bool loading = true)
        {
            _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);   
            
//            SceneManager.LoadScene(2);
//
//            //实际情况下，感觉这样做就已经达到了需要的效果了
//            SceneManager.LoadSceneAsync(id).allowSceneActivation = true;

            NavigateTo(id, 5);
        }

        //刷新当前场景
        public static void Refresh()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //返回到上个场景
        public static void Return()
        {
            if (_sceneStack.Count > 0)
            {
                //如果上一个场景的id有效则跳转到对应的场景
                SceneManager.LoadScene(_sceneStack.Pop());
            }
            else
            {
                //否则的话回提示是否退出游戏
//                NavigateTo("Scenes/Game/MainScene");
            }
        }

        static void NavigateTo(int id, float cacheTime)
        {
            _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);
            //这个就是人为的添加延迟，让loading效果更明显
            SceneManager.LoadSceneAsync(2).completed += delegate (AsyncOperation operation)
            {
                operation.allowSceneActivation = true;
                Object.FindObjectOfType<LoadingScript>().NavigateTo(id);
            };
        }
        
        static void NavigateTo(string name, float cacheTime)
        {
            _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);
            //这个就是人为的添加延迟，让loading效果更明显
            SceneManager.LoadSceneAsync(2).completed += delegate (AsyncOperation operation)
            {
                operation.allowSceneActivation = true;
                Object.FindObjectOfType<LoadingScript>().NavigateTo(name);
            };
        }
    }
}