using System;
using UnityEngine;

namespace ScriptObject
{
    [CreateAssetMenu(fileName = "config", menuName = "config/config", order = 0)]
    public class Config : ScriptableObject
    {
        public enum GraphQuality
        {
            low,
            normal,
            high,
            extra,
        }
        
        [Range(0, 100)]
        public float bgmVol = 50;
        
        [Range(0, 100)]
        public float effVol = 50;

        [Range(0, 100)]
        public float chaVol = 50;

        public bool playBgmVol = true;
        
        public bool playEffVol = true;

        public bool playChaVol = true;

        public GraphQuality graph = GraphQuality.normal;
    }
}