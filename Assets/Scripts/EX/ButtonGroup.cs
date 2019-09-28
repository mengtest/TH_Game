using UnityEngine;
using Button = UnityEngine.UI.Button;

//主要是做一个支持单选的按钮组
namespace EX
{
    [AddComponentMenu("yuki/ButtonGroup")]
    public class ButtonGroup : MonoBehaviour
    {
        [Tooltip("当前选择的按钮的序号")] 
        [SerializeField]
        private int _selected = -1;
    
        [Tooltip("当前Group所包含的button")]
        public Button[] _buttons;

        public Button CurrentButton => _selected >= 0 ? _buttons[_selected] : null;

        private void SelectButton(int index)
        {
            //这一个就不可能存在，这样做是为了防止其他操作调用这个函数
            if (index < 0)
            {
                return;
            }

            //禁用掉当前选择的按钮
            _buttons[index].interactable = false;
            //启用之前禁用的按钮
            if (_selected >= 0 && _selected != index)
            {
                _buttons[_selected].interactable = true;
            }
            _selected = index;
        }

        // Start is called before the first frame update
        void Start()
        {
            _buttons = GetComponentsInChildren<Button>();
            for (int id = 0; id < _buttons.Length; id++)
            {
                var btn = _buttons[id];
                var index = id;
                btn.onClick.AddListener(() =>
                {
                    SelectButton(index);
                });
            }
        }
    
    }
}
