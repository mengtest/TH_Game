using UnityEngine;
using UnityEngine.UI;

namespace BattleScene
{
    public class PauseButton : MonoBehaviour
    {
        [SerializeField]
        private Sprite _pauseSprite;
        
        [SerializeField]
        private Sprite _normalSprite;
        
        private bool _pause = false;

        private void StateChange()
        {
            _pause = !_pause;
            if (_pause)
            {
                GetComponent<Image>().sprite = _normalSprite;
                //暂停游戏
                Debug.Log("游戏暂停");
            }
            else
            {
                GetComponent<Image>().sprite = _pauseSprite;
                //继续游戏
                Debug.Log("继续游戏");
            }
        }

        private void OnMouseUpAsButton()
        {
            StateChange();
        }
    }
}