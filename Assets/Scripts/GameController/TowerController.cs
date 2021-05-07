using System;
using System.Collections;
using GameManagers;
using Pool;
using TMPro;
using Types;
using UnityEngine;

namespace GameController
{
    public class TowerController : MonoBehaviour
    {
        [Header("Instance")]
        [SerializeField] private MinionController _prefab;
        [SerializeField] private Transform _attackSpawnTransform;
        [SerializeField] private TextMeshProUGUI _minionCountText;
        [SerializeField] private Renderer _renderer;
        [SerializeField] private Material _loyalMaterial;
        [Header("Values")]
        [SerializeField] private TowerType _towerType = TowerType.EMPTY;
        [SerializeField] private float _attackSpawnDelay = 0.3f;
        [SerializeField] private float _minionSpawnDelay = 1f;
        [SerializeField] private LoyaltyState _loyaltyState;
        
        private int _preparedMinionCount = 5;
        private float _deltaAttackPosition = 0.5f;
        private Coroutine _spawnCoroutine;

        private void Awake()
        {
            if (_towerType == TowerType.MAIN)
            {
                _preparedMinionCount = 30;
                _loyaltyState = new LoyaltyState(_loyalMaterial);
                _renderer.material = _loyalMaterial;
            }
            _minionCountText.text = _preparedMinionCount.ToString();
        }

        private void OnEnable()
        {
            Activate();
        }

        public void Attack(TowerController towerController)
        {
            StartCoroutine(AttackCoroutine(towerController));
        }

        public void Activate()
        {
            _spawnCoroutine = StartCoroutine(SpawnCoroutine());
        }

        public void Deactivate()
        {
            StopCoroutine(_spawnCoroutine);
        }

        public void Damage(LoyaltyState loyalty)
        {
            if (loyalty == _loyaltyState)
            {
                _preparedMinionCount++;
                _minionCountText.text = _preparedMinionCount.ToString();
            }
            else
            {
                _preparedMinionCount--;
                _minionCountText.text = _preparedMinionCount.ToString();
                if (_preparedMinionCount == 0)
                {
                    ChangeLoyalty(loyalty);
                }
            }
        }

        private void ChangeLoyalty(LoyaltyState loyalty)
        {
            _loyaltyState = loyalty;
            _renderer.material = loyalty.Material;
        }
        
        private IEnumerator AttackCoroutine(TowerController towerController)
        {
            var waiter = new WaitForSeconds(_attackSpawnDelay);
            for (int i = 0; i < _preparedMinionCount / 2; i++)
            {
                _preparedMinionCount--;
                _minionCountText.text = _preparedMinionCount.ToString();
                SpawnAttackMinion(towerController);
                yield return waiter; 
            }
        }

        private void SpawnAttackMinion(TowerController towerController)
        {
            MinionController minionController =
                ObjectPool.Instance.Get<MinionController>(_prefab, _attackSpawnTransform.position);
            minionController.LoyaltyState = _loyaltyState;
            minionController.SetAim(towerController);
        }

        private IEnumerator SpawnCoroutine()
        {
            var waiter = new WaitForSeconds(_minionSpawnDelay);

            while (true)
            {
                yield return waiter;
                _preparedMinionCount++;
                _minionCountText.text = _preparedMinionCount.ToString();
            }
        }
    }
}