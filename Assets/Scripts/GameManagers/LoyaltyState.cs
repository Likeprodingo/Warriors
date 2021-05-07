using UnityEngine;

namespace GameManagers
{
    public class LoyaltyState
    {
        private Material _material;

        public LoyaltyState(Material material)
        {
            _material = material;
        }

        public Material Material => _material;
    }
}