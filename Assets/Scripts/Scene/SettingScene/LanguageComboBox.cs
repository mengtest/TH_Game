using L;
using UnityEngine;
using UnityEngine.UI;

namespace Scene.SettingScene
{
    public class LanguageComboBox : MonoBehaviour
    {
        //默认情况下使用的是这个回调，可以在这个组件被加载的时候切换语言
        //为了避免出现死循环，这里不刷新场景
//        public void LanguageChange()
//        {
//            //选择不同的项会直接修改当前的语言
//            //但是不会立刻反应出
//            Singleton.Singleton.Instance.Language.CurrentLanguage = Config.Load().Language[GetComponent<Dropdown>().value];
//        }

        //除了切换语言外，这里还做了一次场景的刷新
        private void Refresh(int value)
        {
            //选择不同的项会直接修改当前的语言
            Singleton.Instance.Language.CurrentLanguage = Config.Load().Language[value];

            //重新加载当前的场景
            //充当刷新的作用，刷新语言
            Global.Refresh();
        }

        // Start is called before the first frame update
        void Start()
        {
            var dropDown = GetComponent<Dropdown>();
            dropDown.options.Clear();

            //加载配置文件，读取所有的语言文件，并存入到下拉列表中
            var config = Config.Load();
            dropDown.AddOptions(config.Language);

            //将下拉列表选择的值设置为当前的语言
            dropDown.value = config.Language.BinarySearch(Singleton.Instance.Language.CurrentLanguage);

            //先移除所有的事件监听器
            dropDown.onValueChanged.RemoveAllListeners();
            //添加新的事件监听器
            dropDown.onValueChanged.AddListener(Refresh);
        }
    }
}
