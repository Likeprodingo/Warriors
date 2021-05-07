using System;
using Scripts.Core;
using UnityEngine;

namespace GameController
{
    public class GameManager : GameObjectSingleton<GameManager>
    {
        
        public static event Action GameEnded = delegate { };
        public static event Action GameStarted = delegate { };
        
        public void EndLevel()
        {
            GameEnded?.Invoke();
        }

        public void StartLevel()
        {
            Time.timeScale = 1;
            GameStarted?.Invoke();
        }
    }
}