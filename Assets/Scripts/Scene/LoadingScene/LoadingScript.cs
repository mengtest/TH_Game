using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//载入场景
namespace Scene.LoadingScene
{
    public class LoadingScript : MonoBehaviour
    {
        public Text _text;
        //保留有展示图片的功能，但是默认不使用
        public Image _image;
        private int _index;
        private string _primText;

        private int _nextSceneId = -1;
        private string _nextSceneName = null;

        // Start is called before the first frame update
        void Start()
        {
            _index = 0;
            _primText = _text.text;

            //unity提供的延迟调用
            Invoke(nameof(Timer), 0.5f);
        }

        public void NavigateTo(int id)
        {
            _nextSceneId = id;
            _nextSceneName = null;

            Invoke(nameof(Load), 10);
        
//            var obj = Resources.Load("Music/上海アリス幻樂団 - 幽雅に咲かせ、墨染の桜 ～ Border of Life");
//            Resources.Load("Music/上海アリス幻樂団 - 幽雅に咲かせ、墨染の桜 ～ Border of Life");
//            Resources.Load("Music/上海アリス幻樂団 - 幽雅に咲かせ、墨染の桜 ～ Border of Life");
//            Resources.Load("Music/上海アリス幻樂団 - 幽雅に咲かせ、墨染の桜 ～ Border of Life");
//            Resources.Load("Music/上海アリス幻樂団 - 幽雅に咲かせ、墨染の桜 ～ Border of Life");
//            Resources.Load("Music/上海アリス幻樂団 - 幽雅に咲かせ、墨染の桜 ～ Border of Life");
        }

        private void Load()
        {
            if (_nextSceneId != -1)
            {
                SceneManager.LoadSceneAsync(_nextSceneId).allowSceneActivation = true;
            }
            else if(_nextSceneName != null)
            {
                SceneManager.LoadSceneAsync(_nextSceneName).allowSceneActivation = true;
            }
        }

        public void NavigateTo(string sceneName)
        {
            _nextSceneName = sceneName;
            _nextSceneId = -1;

            Invoke(nameof(Load), 5);
        }

        //文字的动态变化
        void Timer()
        {
            _index++;
            switch (_index % 4)
            {
                case 0:
                    _text.text = _primText + ".";
                    break;
                case 1:
                    _text.text = _primText + "..";
                    break;
                case 2:
                    _text.text = _primText + "...";
                    break;
                case 4:
                    _text.text = _primText;
                    break;
                default:
                    _text.text = _primText;
                    break;
            }
        
            Invoke(nameof(Timer), 0.5f);
        }
    }
}
