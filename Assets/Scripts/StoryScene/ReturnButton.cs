using Global;
using UnityEngine;

namespace StoryScene
{
    public class ReturnButton : MonoBehaviour
    {
        public void Return()
        {
            Navigator.Return();
        }
    }
}