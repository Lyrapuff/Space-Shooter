using System;
using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    public class HitOnTouch : MonoBehaviour
    {
        public Action OnHit { get; set; }
        
        [SerializeField] private int _damage;
        [SerializeField] private LayerMask _layerMask;
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            int layer = other.gameObject.layer;
            int layerMask = _layerMask.value;

            if (layerMask == (layerMask | (1 << layer)))
            {
                Health health = other.GetComponent<Health>();

                if (health != null)
                {
                    health.Hit(_damage);
                    OnHit?.Invoke();
                }
            }
        }
    }
}