using System.Collections;
using System.Collections.Generic;
using LoadingScene;
using Prefab;
using UnityEngine;
using UnityEngine.SceneManagement;

partial class Global
{
    private static Stack<int> _sceneStack = new Stack<int>();

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
        
        if (loading)
        {
            //如果需要加载loading场景的话，会先去加载loading场景，在loading场景中再去加载目标场景
            var layer = Object.Instantiate(Resources.Load<GameObject>("Prefab/LoadingLayer"));
            SceneManager.MoveGameObjectToScene(layer, SceneManager.GetActiveScene());

            layer.GetComponent<LoadingLayerScript>().StartCoroutine(LoadScene(name));

//            var asyn = SceneManager.LoadSceneAsync(name);
//            asyn.allowSceneActivation = false;
//            Timer.Register(5.0f, () =>
//            {
//                Log($"{name}加载完成");
//                asyn.allowSceneActivation = true;
//            });
        }
        else
        {
            SceneManager.LoadScene(name);
        }
    }
    
    //跳转到id场景中
    //是否需要加载loading界面
    public static void NavigateTo(int id, bool loading = true)
    {
        _sceneStack.Push(SceneManager.GetActiveScene().buildIndex);

        if (loading)
        {
            //如果需要加载loading场景的话，会先去加载loading场景，在loading场景中再去加载目标场景
            var layer = Object.Instantiate(Resources.Load<GameObject>("Prefab/LoadingLayer"));
            SceneManager.MoveGameObjectToScene(layer, SceneManager.GetActiveScene());
            var asyn = SceneManager.LoadSceneAsync(id);
            asyn.completed += delegate(AsyncOperation operation)
            {
                if (operation.isDone)
                {
                    Log($"id为{id}的场景加载完成");
                }
            };
        }
        else
        {
            SceneManager.LoadScene(id);
        }
    }
    
    private static IEnumerator LoadScene(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
    
    private static IEnumerator LoadScene(int sceneId)
    {
        yield return SceneManager.LoadSceneAsync(sceneId);
    }

    //刷新当前场景
    public static void Refresh()
    {
        //直接重新加载当前的场景一次，不会被添加到场景栈中
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
            
        }
    }
}
