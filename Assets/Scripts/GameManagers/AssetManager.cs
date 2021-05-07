using System.Collections.Generic;
using Scripts.Core;
using UnityEngine;

namespace Scripts.Core
{
    public partial class AssetManager : GameObjectSingleton<AssetManager>
    {
        [SerializeField] private List<MinionPrefab> _minionPrefabs = new List<MinionPrefab>();

        public List<MinionPrefab> MinionPrefabs => _minionPrefabs;
    }
}