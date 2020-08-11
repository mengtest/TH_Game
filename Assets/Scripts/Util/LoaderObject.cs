using System.Collections;
using UnityEngine;

namespace Util
{
    //异步加载资源时要用到挂载了这个脚本的对象
    public class LoaderObject : MonoBehaviour 
    {
        // private bool _mutil = false;
        [SerializeField]
        private Object[] _objs;

        private static LoaderObject _instance;

        public static LoaderObject GetLoader()
        {
            if (_instance == null)
            {
                var go = new GameObject("Loader");
                _instance = go.AddComponent<LoaderObject>();
                DontDestroyOnLoad(go);
            }
            return _instance;
        }

        public void LoadAsync(string[] files, LoadAsyncsCallback callback)
        {
            _objs = new Object[files.Length];
            StartCoroutine(LoadAsyncImpl(files));
            callback?.Invoke(true, _objs);
            _objs = null;
        }

        private IEnumerator LoadAsyncImpl(string[] files)
        {
            // var objs = new Object[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                var request = Resources.LoadAsync(files[i]);
                while(!request.isDone)
                {
                    yield return 1;
                }
                _objs[i] = request.asset;
            }
        }

        public void LoadAsync(string file, LoadAsyncCallback callback)
        {
            _objs = new Object[1];
            StartCoroutine(LoadAsyncImpl(file));
            callback?.Invoke(true, _objs[0]);
            _objs = null;
        }

        public IEnumerator LoadAsyncImpl(string file)
        {
            var request = Resources.LoadAsync(file);
            while(!request.isDone)
            {
                yield return 1;
            }
        }



        //其实所有的棋子相关的信息已经加载的差不多了
        public void LoadAllPawns(int combatId, int playerId)
        {
            var player = LuaApi.GetPlayer(combatId, playerId);
            for (int i = 0; i < player.pawns.Length; i++)
            {
                //我觉得应该是通过某个api获取到uid与卡牌id的键值对
                var p = player.pawns[i];
                var c = player.cards[i];
            }
        }
    }
}