﻿using System.Collections;
using Pool;
using Scripts.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameController
{
    public class StarterManager : MonoBehaviour
    {
        private const int FirstScene = 1;
        IEnumerator Start()
        {
            DontDestroyOnLoad(gameObject);
            Init();
            yield return StartCoroutine(LoadScene());
            Destroy(gameObject);
        }

        private void Init()
        {
            AssetManager.GetInstance();
            GameManager.GetInstance();
            ObjectPool.GetInstance();
        }

        IEnumerator LoadScene()
        {
            yield return SceneManager.LoadSceneAsync(FirstScene);
        }
    }
}