using System;
using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    public class Health : MonoBehaviour
    {
        public static Action<HealthType> OnAnyDied { get; set; }
        public Action OnDied { get; set; }
        public Action OnHit { get; set; }
        public int MaxHitCount => _maxHitCount;
        public int HitCount => _hitCount;
        public HealthType HealthType => _healthType;

        [SerializeField] private int _maxHitCount;
        [SerializeField] private HealthType _healthType;

        private int _hitCount;

        private void Awake()
        {
            Reset();
        }

        public void Hit(int damage = 1)
        {
            _hitCount -= damage;
            
            OnHit?.Invoke();

            if (_hitCount <= 0)
            {
                OnDied?.Invoke();
                OnAnyDied?.Invoke(_healthType);
            }
        }

        public void Reset()
        {
            _hitCount = _maxHitCount;
        }
    }

    public enum HealthType
    {
        Player,
        Enemy
    }
}