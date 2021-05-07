using System;
using GameManagers;
using Pool;
using Types;
using UnityEngine;
using UnityEngine.AI;

namespace GameController
{
    public class MinionController : PooledObject
    {
        [SerializeField] private NavMeshAgent _navMeshAgent;
        [SerializeField] private Renderer _renderer;

        private LoyaltyState _loyaltyState;
        private TowerController _aimTower;

        public LoyaltyState LoyaltyState
        {
            get => _loyaltyState;
            set
            {
                _loyaltyState = value;
                _renderer.material = _loyaltyState.Material;
            }
        }

        public void SetAim(TowerController towerController)
        {
            _navMeshAgent.SetDestination(towerController.transform.position);
            _aimTower = towerController;
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out TowerController towerController))
            {
                if (_aimTower == towerController)
                {
                    towerController.Damage(_loyaltyState);
                    ObjectPool.Instance.FreeObject(this);
                }
            }
        }
    }
}