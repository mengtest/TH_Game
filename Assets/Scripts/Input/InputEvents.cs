using UnityEngine;
using UnityEngine.InputSystem;

namespace Input
{
    public class InputEvents : MonoBehaviour
    {
        public void KeyAPress(InputAction.CallbackContext context)
        {
            //键盘上的A键被按下，将这个事件分发给Listener

            Lib.Listener.Instance.DistributeKeyboard(Lib.KeyCode.A, Lib.Phase.Press);
        }

        public void KeyEnterPress(InputAction.CallbackContext context)
        {
            Lib.Listener.Instance.DistributeKeyboard(Lib.KeyCode.Return, Lib.Phase.Press);
        }
        
        public void MouseLeftPress(InputAction.CallbackContext context)
        {
            Lib.Listener.Instance.DistributeMouse(Lib.KeyCode.Mouse0, Lib.Phase.Press, context.ReadValue<Vector2>());
        }
    }
}