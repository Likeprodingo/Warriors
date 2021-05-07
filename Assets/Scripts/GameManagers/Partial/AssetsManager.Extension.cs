using System;
using GameController;
using UnityEngine;

namespace Scripts.Core
{
    public partial class AssetManager
    {
        [Serializable]
        public class MinionPrefab
        {
            [SerializeField] private MinionController _prefab;
            [SerializeField] private int _poolCount;

            public MinionController Prefab => _prefab;

            public int PoolCount => _poolCount;
        }
    }
}