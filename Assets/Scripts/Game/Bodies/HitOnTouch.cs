using System;
using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    public class HitOnTouch : MonoBehaviour
    {
        public Action OnHit { get; set; }
        
        [SerializeField] private int _damage;
        [SerializeField] private HealthType _targetHealthType;

        private void OnTriggerEnter2D(Collider2D other)
        {
            Health health = other.GetComponent<Health>();

            if (health != null && health.HealthType == _targetHealthType)
            {
                health.Hit(_damage);
                OnHit?.Invoke();
            }
        }
    }
}