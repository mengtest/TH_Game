using System.Collections;
using System.Collections.Generic;
using Scene.SettingScene;
using ScriptObject;
using UnityEngine;

public class test : MonoBehaviour
{
    public VoicePanel panel1;
    public VoicePanel panel2;
    public Config config;
    public Config memoryConfig;
    
    // Start is called before the first frame update
    void Start()
    {
        config = Resources.Load<Config>("Config/config");
        var list = GetComponentsInChildren<VoicePanel>();
        if (list.Length == 2)
        {
            panel1 = list[0];
            panel1.AddSliderChangeEvent((v) => { config.bgmVol = v; });
            panel2 = list[1];
            panel2.AddSliderChangeEvent((v) => { config.effVol = v; });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
