using Global;
using UnityEngine;

namespace MainScene
{
    public class StoryButton : MonoBehaviour
    {
        public void ShowStoryView()
        {
            Navigator.NavigateTo("StoryScene");   
        }

//        private void Start()
//        {
//            this.GetComponent<Button>().onClick.AddListener(ShowStoryView);
//        }
    }
}