﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Util;

partial class Global
{
    private static Stack<int> _sceneStack = new Stack<int>();
    private static AsyncOperation _async;

    //跳转到name场景中
    //是否需要加载loading界面
    public static void NavigateTo(string name, bool loading = true)
    {
        _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);
        
        //如果传入的名字当中没有/的话，说明是相对路径，这里会从Scenes文件夹下面去寻找这个场景
        if (!name.Contains("/"))
        {
            name = "Scenes/" + name;
        }

        Listener.Instance.Event("scene_change", null, name);
        if (loading)
        {
            //如果需要加载loading场景的话，会先去加载loading场景，在loading场景中再去加载目标场景
            Cache.SetSceneParam(name);
            SceneManager.LoadSceneAsync("Scenes/LoadingScene");
        }
        else
        {
            SceneManager.LoadSceneAsync(name).completed += asyncOperation =>
            {
                Listener.Instance.Event("scene_changed", null, name);
            };
        }
    }
    
    //跳转到id场景中
    //是否需要加载loading界面
    public static void NavigateTo(int id, bool loading = true)
    {
        _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);

        Listener.Instance.Event("scene_change", null, id);
        if (loading)
        {
            //如果需要加载loading场景的话，会先去加载loading场景，在loading场景中再去加载目标场景
            SceneManager.LoadSceneAsync("Scenes/LoadingScene").completed += operation =>
                {
                    SceneManager.LoadSceneAsync(id).completed += (op) =>
                    {
                        Listener.Instance.Event("scene_changed", null, id);
                    };
                };
        }
        else
        {
            SceneManager.LoadSceneAsync(id).completed += operation =>
            {
                Listener.Instance.Event("scene_changed", null, id);
            };
        }
    }

    //刷新当前场景
    public static void Refresh()
    {
        //直接重新加载当前的场景一次，不会被添加到场景栈中
        Listener.Instance.Event("scene_refresh");
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex).completed += operation =>
        {
            Listener.Instance.Event("scene_refreshd", null);
        };
    }

    //返回到上个场景
    public static void Return()
    {
        if (_sceneStack.Count > 0)
        {
            //如果上一个场景的id有效则跳转到对应的场景
            NavigateTo(_sceneStack.Pop(), false);
        }
        else
        {
            
        }
    }
}
