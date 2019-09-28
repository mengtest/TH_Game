using UnityEngine;
using UnityEngine.UI;

namespace StartScene
{
    public class ContinueButton : MonoBehaviour
    {
//    protected Button btn;

        // Start is called before the first frame update
        void Start()
        {
            var btn = GetComponent<Button>();
            //按钮的禁用
            btn.interactable = false;
        }

        public void ContinueEvent()
        {

        }

        // Update is called once per frame
//    void Update()
//    {
//        
//    }
    }
}
