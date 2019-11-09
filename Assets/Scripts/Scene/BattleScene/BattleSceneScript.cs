﻿using Manager;
using UnityEngine;

namespace BattleScene
{
    public class BattleSceneScript : MonoBehaviour
    {
        [Tooltip("战斗时候播放的背景音乐")]
        [SerializeField]
        public string[] sounds;

        //敌方棋盘
        [SerializeField]
        private BattleBoard _enemyBoard;

        //我方棋盘
        [SerializeField]
        private BattleBoard _selfBoard;
        
        // Start is called before the first frame update
        void Awake()
        {
            BattleInit();
        }
        
        //战斗中有
        //    两个玩家或者电脑
        //    卡组
        //    场地上的卡牌
        //    战斗的逻辑
        private void Start()
        {
            
        }

        //战斗开始
        public void BattleStart()
        {
            
        }

        //战斗场景初始化
        //包含有：
        //    1、玩家信息的初始化
        //    2、双方卡组的初始化
        //    3、
        private void BattleInit()
        {
            BoardInit();
            CardInit();
            Sound.PlayBgm(sounds, false);
        }

        //对战双方卡组的初始化
        private void CardInit()
        {
            
        }

        //棋盘的初始化
        private void BoardInit()
        {
            if (_enemyBoard == null)
            {
                _enemyBoard = ((GameObject) Instantiate(Resources.Load("Prefab/EnemyBoard")))
                    .GetComponent<BattleBoard>();
                _enemyBoard.name = "EnemyBoard";
            }
            
            if (_selfBoard == null)
            {
                _selfBoard = ((GameObject) Instantiate(Resources.Load("Prefab/SelfBoard")))
                    .GetComponent<BattleBoard>();
                _selfBoard.name = "SelfBoard";
            }
        }
    }
}
