﻿using UnityEngine;
using Util;

namespace StartScene
{
    public class ExitButton : MonoBehaviour
    {
        public void ExitGame()
        {
            var dialog = new ModelDialog("Dialog_ExitGame", 
                "Ok", 
                "Cancel",
                () =>
                {
                    Application.Quit(0);
                });
            dialog.ShowDialog();
        }
    }
}
