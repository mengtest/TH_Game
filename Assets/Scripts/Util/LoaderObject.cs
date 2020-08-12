using System.Collections;
using UnityEngine;

namespace Util
{
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
            StartCoroutine(LoadAsyncImpl(files, callback));
        }

        private IEnumerator LoadAsyncImpl(string[] files, LoadAsyncsCallback callback)
        {
            // var objs = new Object[files.Length];
            _objs = new Object[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                var request = Resources.LoadAsync(files[i]);
                while(!request.isDone)
                {
                    yield return 1;
                }
                _objs[i] = request.asset;
            }
            callback?.Invoke(true, _objs);
            _objs = null;
        }

        public void LoadAsync(string file, LoadAsyncCallback callback)
        {
            StartCoroutine(LoadAsyncImpl(file, callback));
        }

        public IEnumerator LoadAsyncImpl(string file, LoadAsyncCallback callback)
        {
            _objs = new Object[1];
            var request = Resources.LoadAsync(file);
            while(!request.isDone)
            {
                yield return 1;
            }
            callback?.Invoke(true, _objs[0]);
            _objs = null;
        }



        public void LoadAllPawns(int combatId, int playerId)
        {
            var player = LuaApi.GetPlayer(combatId, playerId);
            for (int i = 0; i < player.pawns.Length; i++)
            {
                var p = player.pawns[i];
                var c = player.cards[i];
            }
        }
    }
}