using System;
using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    public class Health : MonoBehaviour
    {
        public Action OnDied { get; set; }
        public Action OnHit { get; set; }
        
        public int MaxHitCount => _maxHitCount;
        public int HitCount => _hitCount;

        [SerializeField] private int _maxHitCount;

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
            }
        }

        public void Reset()
        {
            _hitCount = _maxHitCount;
        }
    }
}